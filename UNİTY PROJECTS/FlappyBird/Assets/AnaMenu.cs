using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class AnaMenu : MonoBehaviour
{
    public Text puanText;
    public Text normalPuan;
    void Start()
    {
        int enYuksekPuan = PlayerPrefs.GetInt("yuksekPuanKayit");
        int puan = PlayerPrefs.GetInt("puanKayit");

        puanText.text = "Best Score = "+ enYuksekPuan;
        normalPuan.text = "Puan = " + puan;
    }

    
    void Update()
    {
        
    }
    public void oyunaGit()
    {
        SceneManager.LoadScene("Level");


    }
    public void oyundanCık()
    {

        Application.Quit();

    }
}
