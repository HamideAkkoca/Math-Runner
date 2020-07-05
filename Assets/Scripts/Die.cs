using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Die : MonoBehaviour
{
    public GameObject yaziOlme, resimOlme;
    // Start is called before the first frame update
    void OnCollisionEnter(Collision temas)
    {
        if (temas.gameObject.tag == "engel")
        {
            yaziOlme.gameObject.SetActive(true);
            resimOlme.gameObject.SetActive(false);
            Time.timeScale = 0;
        }
    }
}