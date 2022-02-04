using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OyunKontrol : MonoBehaviour
{
    public GameObject gokyuzu1;
    public GameObject gokyuzu2;
    public float arkaPlanHiz=-1.5f;

    Rigidbody2D fizik1;
    Rigidbody2D fizik2;

    float uzunluk = 0;

    public GameObject engel;
    public int kacAdetEngel;
    GameObject[] engeller;

    float degisimZaman = 0;
    int sayac =0;

    bool oyunBitir = true;



    void Start()
    {
        fizik1 = gokyuzu1.GetComponent<Rigidbody2D>();
        fizik2 = gokyuzu2.GetComponent<Rigidbody2D>();

        fizik1.velocity = new Vector2(arkaPlanHiz,0);
        fizik2.velocity = new Vector2(arkaPlanHiz, 0);

        uzunluk = gokyuzu1.GetComponent<BoxCollider2D>().size.x;

        engeller = new GameObject[kacAdetEngel];
        for (int i = 0; i < engeller.Length; i++)
        {
            engeller[i] = Instantiate(engel,new Vector2(-20,20),Quaternion.identity);
            Rigidbody2D fizikEngel=engeller[i].AddComponent<Rigidbody2D>();
            fizikEngel.gravityScale = 0;
            fizikEngel.velocity = new Vector2(arkaPlanHiz,0);
        }
    }

    
    void Update()
    {
        if (oyunBitir)
        {





            if (gokyuzu1.transform.position.x <= -uzunluk)
            {

                gokyuzu1.transform.position += new Vector3(uzunluk * 2, 0);

            }
            if (gokyuzu2.transform.position.x <= -uzunluk)
            {

                gokyuzu2.transform.position += new Vector3(uzunluk * 2, 0);

            }

            //----------------------------------------------------

            degisimZaman += Time.deltaTime;
            if (degisimZaman > 2f)
            {
                degisimZaman = 0;
                float Yekseni = Random.Range(-0.4f, 1.4f);
                engeller[sayac].transform.position = new Vector3(14, Yekseni);
                sayac++;
                if (sayac >= engeller.Length)
                {
                    sayac = 0;

                }


            }
        }
        else
        {

            
        }

    }

   public void oyunBitti()
    {

        for (int i = 0; i < engeller.Length; i++)
        {
            engeller[i].GetComponent<Rigidbody2D>().velocity =  Vector2.zero;
            fizik1.velocity = Vector2.zero;
            fizik2.velocity = Vector2.zero;

        }
        oyunBitir = false;


    }
}
