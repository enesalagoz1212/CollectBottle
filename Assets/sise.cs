using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class sise : MonoBehaviour
{
    public Transform sise2;
    public TextMeshProUGUI canYazisi;
    public int can;

    private void Update()
    {
        canYazisi.text = "Can : " + can;
        if (can==0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    float rastgele = Random.Range(-9f, 9f);
    void OnCollisionEnter(Collision temas)
    {
        if (temas.gameObject.tag == "zemin")
        {
            sise2.position = new Vector3(rastgele, 5.88f, 0f);
            can--;
        }
    }



}
