using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour
{
    public TextMeshProUGUI soru_txt;
    public TextAsset sorular;
    public Button[] cevap_buton;
    public TextMeshProUGUI[] paralar;
    public GameObject kaybettin_pnl;
    public GameObject telefon_joker;
    public GameObject seyirci_joker;
    public GameObject tebrikler_pnl;
    public GameObject yari_buton;
    public string cevap;
    int ilk_satir = 0;
    int son_satir = 5;
    string[] soru;
    int dogru_cevap = 0;
    void Start()
    {
        yari_buton.SetActive(true);
        kaybettin_pnl.SetActive(false);
        soru = sorular.text.Split("\n"[0]);
        soru_ekle(ilk_satir,son_satir);
    }
    void soru_ekle(int ilk,int son)
    {
        soru_txt.text = soru[ilk];
        cevap = soru[son];
        cevap_buton[0].name = soru[ilk + 1];
        cevap_buton[1].name = soru[ilk + 2];
        cevap_buton[2].name = soru[ilk + 3];
        cevap_buton[3].name = soru[ilk + 4];
        cevap_buton[0].GetComponentInChildren<TextMeshProUGUI>().text= soru[ilk + 1];
        cevap_buton[1].GetComponentInChildren<TextMeshProUGUI>().text = soru[ilk + 2];
        cevap_buton[2].GetComponentInChildren<TextMeshProUGUI>().text = soru[ilk + 3];
        cevap_buton[3].GetComponentInChildren<TextMeshProUGUI>().text = soru[ilk + 4];
    }
    public void cevapKontrol(string deger)
    {
        if (deger == cevap)
        {
            Debug.Log("doğru cevap");
            ilk_satir = son_satir + 1;
            son_satir = ilk_satir + 5;
           // soru_ekle(ilk_satir, son_satir);
            paralar[dogru_cevap].color = Color.red;
            dogru_cevap++;
            if (ilk_satir + 1 == 25)   // Boş satıra gelinmişse
            {
                tebrikler_pnl.SetActive(true);   // Tebrikler panelini göster
            }
            else
            {
                soru_ekle(ilk_satir, son_satir);   //Boş satıra gelinmemişse bir sonraki soruyu göster           
            }
        }
        else
        {
            kaybettin_pnl.SetActive(true);
        }
    }
    public void tekrarOyna()
    {
        SceneManager.LoadScene(0);

    }
    public void cikisYap()
    {
        Application.Quit();
    }
 public void yariJoker()
    {
        int silinen_cevap = 0;
        foreach(Button btn in cevap_buton)
        {
            if (btn.name != cevap)
            {
                btn.GetComponentInChildren<TextMeshProUGUI>().text =null;
                silinen_cevap++;
            }
            if (silinen_cevap == 2)
            {
                break;
            }
        }
        yari_buton.SetActive(false);
    }
    public void telefonJoker()
    {
        telefon_joker.SetActive(true);
    }
    public void seyirciJoker()
    {
        seyirci_joker.SetActive(true);
    }
  
      
    

    void Update()
    {
        
    }
}
