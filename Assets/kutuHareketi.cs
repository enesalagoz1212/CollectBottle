using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class kutuHareketi : MonoBehaviour
{
    public float hiz;
    public Transform sise;
    int puan;
    public TextMeshProUGUI puanYazisi;
   

   
    void Update()
    {
        puanYazisi.text = "Puan : " + puan;
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-hiz * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(hiz * Time.deltaTime, 0, 0);
        }
    }
    void OnCollisionEnter(Collision temas)
    {
        float rastgele = Random.Range(-9f, 9f);
        if (temas.gameObject.tag == "sise")
        {
            sise.position = new Vector3(rastgele, 5.88f, 0f);
            puan += 5;
        }
        
    }
}
