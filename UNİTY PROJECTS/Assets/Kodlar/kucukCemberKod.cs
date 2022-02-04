﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kucukCemberKod : MonoBehaviour
{
    Rigidbody2D fizik;
    public float hiz;
    bool hareketKontrol = false;
    public GameObject oyunYoneticisi;
    void Start()
    {
        fizik = GetComponent<Rigidbody2D>();
        oyunYoneticisi = GameObject.FindGameObjectWithTag("OyunYoneticisiTag");
    }


    void FixedUpdate()
    {
        if (!hareketKontrol) { 
        fizik.MovePosition(fizik.position + Vector2.up * hiz * Time.deltaTime);
    }
    }

     void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag=="donenCemberTag")
        {
            transform.SetParent(col.transform);
            hareketKontrol = true;
            

        }
        if (col.tag == "KucukCemberTag")
        {
            oyunYoneticisi.GetComponent<OyunYoneticisi>().oyunBitti();


        }
    }
}
