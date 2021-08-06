using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class telefon_joker : MonoBehaviour
{
    public Text verilen_cevap;
    public GameObject tel_buton;
    string yanit;
    Manager m;
  
    void Start()
    {
        tel_buton.SetActive(true);
        m = GameObject.Find("Manager").GetComponent<Manager>();
        yanit = m.cevap;
        int rast = Random.Range(1, 4);
        if (rast == 1)
        {
            verilen_cevap.text = "maalesef bu sorunun cevabını bilmiyorum";
        }
        else if (rast == 2)
        {
            verilen_cevap.text = "Cevabı biliyorum. Cevap : " + yanit;
        }
        else if (rast == 3)
        {
            int rast2 = Random.RandomRange(1, 3);
            if (rast2 == 1)
            {
                verilen_cevap.text = "Emin değilim ama " + yanit+" olabilir.";
            }
            else
            {
                foreach(Button btn in m.cevap_buton)
                {
                    if (btn.name !=yanit)
                    {
                        verilen_cevap.text = "Emin değilim ama " + btn.name + " olabilir.";
                        break;
                    }
                }
              
            }
        }
    }

public void tmm_button()
    {
        tel_buton.SetActive(false);
        gameObject.SetActive(false);
      
    }
}
