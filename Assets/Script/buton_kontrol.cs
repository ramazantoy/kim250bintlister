using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buton_kontrol : MonoBehaviour
{
  
    Manager m;
    void Start()
    {
        m = GameObject.Find("Manager").GetComponent<Manager>();
    }

    public void tikla()
    {
        m.cevapKontrol(gameObject.name);
    }
    void Update()
    {
        
    }
}
