using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class OyunYoneticisi : MonoBehaviour
{
    GameObject donenCember;
    GameObject anaCember;
    public Animator animator;
    public Text DonenCemberLevel;
    public Text bir;
    public Text iki;
    public Text uc;
    public int kacTaneKucukCemberOlsun;
    bool kontrol = true;

    void Start()
    {
        PlayerPrefs.SetInt("kayit",int.Parse(SceneManager.GetActiveScene().name));
        

        donenCember = GameObject.FindGameObjectWithTag("donenCemberTag");
        anaCember = GameObject.FindGameObjectWithTag("AnaCemberTag");
        DonenCemberLevel.text = SceneManager.GetActiveScene().name;
        if (kacTaneKucukCemberOlsun<2)
        {
            bir.text = kacTaneKucukCemberOlsun+"";

        }
        else if (kacTaneKucukCemberOlsun<3)
        {
            bir.text = kacTaneKucukCemberOlsun + "";
            iki.text = (kacTaneKucukCemberOlsun - 1) + "";


        }
        else  
        {
            bir.text = kacTaneKucukCemberOlsun + "";
            iki.text = (kacTaneKucukCemberOlsun - 1) + "";
            uc.text = (kacTaneKucukCemberOlsun-2)+"";


        }

        

    }

    public void kucukCemberdeTextGosterme()
    {
        kacTaneKucukCemberOlsun--;
        if (kacTaneKucukCemberOlsun < 2)
        {
            bir.text = kacTaneKucukCemberOlsun + "";
            iki.text = "";
            uc.text = "";


        }
        else if (kacTaneKucukCemberOlsun < 3)
        {
            bir.text = kacTaneKucukCemberOlsun + "";
            iki.text = (kacTaneKucukCemberOlsun - 1) + "";
            uc.text = "";

        }
        else
        {
            bir.text = kacTaneKucukCemberOlsun + "";
            iki.text = (kacTaneKucukCemberOlsun - 1) + "";
            uc.text = (kacTaneKucukCemberOlsun - 2) + "";


        }
        if (kacTaneKucukCemberOlsun == 0)
        {
            yeniLevel();

        }
    }


        IEnumerator yeniLevel()
        {
                donenCember.GetComponent<Dndurme>().enabled = false;
                anaCember.GetComponent<AnaCember>().enabled = false;
            yield return new WaitForSeconds(1);
            if (kontrol)
            {
                SceneManager.LoadScene(int.Parse(SceneManager.GetActiveScene().name) + 1);


            }

       


        }






    

    public void oyunBitti()
    {

        StartCoroutine(cagrılanMetod());


    }


    IEnumerator cagrılanMetod()
    {

        donenCember.GetComponent<Dndurme>().enabled=false;
        anaCember.GetComponent<AnaCember>().enabled = false;
        animator.SetTrigger("oyunbitti");
        kontrol = false;

        yield return new WaitForSeconds(1);

       
        SceneManager.LoadScene("AnaMenu");


    }

}
