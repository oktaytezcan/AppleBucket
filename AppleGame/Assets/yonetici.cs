using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class yonetici : MonoBehaviour
{
    float zaman_araligi=0.5f;
    float kalan_zaman=0.0f;


  public  GameObject elma;



    public void tekrar_oyna_btn()
    {
        SceneManager.LoadScene("Scenes/SampleScene");
        Time.timeScale = 1.0f;



    }

    void  elma_ekle()
    {
        float rast = Random.Range(4.0f, 12.0f);
        GameObject yeni_elma = Instantiate(elma, new Vector3(rast, 6, -12), Quaternion.identity);


    }


    private void Update()
    {


        if (Time.time >= kalan_zaman)
        {
            elma_ekle();
            kalan_zaman = zaman_araligi + Time.time;
        }




    }



}