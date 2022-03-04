using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class sepet : MonoBehaviour
{

    TextMeshProUGUI skor_txt;

    public float hiz;
    int skor = 0;


    private void Start()
    {
        skor_txt = GameObject.Find("Canvas/skor_txt").GetComponent<TextMeshProUGUI>();




    }

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "elma")
        {
            skor += 10;
            skor_txt.text = skor.ToString();
            Destroy(collision.gameObject);


        }





    }


    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(hiz * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-hiz * Time.deltaTime, 0, 0);
        }

    }
}
