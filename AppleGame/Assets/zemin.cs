using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class zemin : MonoBehaviour
{

    float can = 100.0f;
    float suanki_can = 100.0f;
    public Image can_bari;
    public GameObject panel;


        private void OnCollisionEnter(Collision collision)
        {

            if (collision.gameObject.tag == "elma")
            {

                Destroy(collision.gameObject);
                suanki_can -= 10.0f;
                can_bari.fillAmount = suanki_can / can;

            }

        if (suanki_can <= 0)
        {
            panel.SetActive(true);
            Time.timeScale = 0.0f;
        }



        }

    





}
