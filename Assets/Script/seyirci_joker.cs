using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class seyirci_joker : MonoBehaviour
{
    string yanit;
    Manager m;
    public GameObject seyirci_buton;
    public Image[] barlar;


    void Start()
    {
        seyirci_buton.SetActive(true);
        m = GameObject.Find("Manager").GetComponent<Manager>();
        yanit = m.cevap;
        int rast = Random.Range(1, 3);
        if (rast == 1)
        {
            float rast2 = Random.Range(75.0f, 96.0f);
            for(int i = 0; i < m.cevap_buton.Length; i++)
            {
                if (m.cevap_buton[i].name == yanit)
                {
                    barlar[i].fillAmount = rast2 / 100;
                }
                else
                {
                    float rast3 = Random.Range(1.0f, 9.0f);
                    barlar[i].fillAmount = rast3 / 100;
                }
            }
        }
        else if(rast==2)
        {
            for(int i = 0; i < m.cevap_buton.Length; i++)
            {
                float rast3 = Random.Range(1.0f, 34.0f);
                barlar[i].fillAmount = rast3 / 100;

            }
        }

    }
    public void tmm_button()
    {
        seyirci_buton.SetActive(false);
        gameObject.SetActive(false);
    }

    void Update()
    {
        
    }
}
