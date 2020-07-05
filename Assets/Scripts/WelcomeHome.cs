using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WelcomeHome : MonoBehaviour
{
    public GameObject Welcomehome;

    // Start is called before the first frame update
    void Start()
    {
        Welcomehome = GameObject.Find("Welcomehome");
        Welcomehome.SetActive(false);
    }
    void OnCollisionEnter(Collision temas)
    {
        if (temas.gameObject.tag == "Engel")
        {
            SceneManager.LoadScene("Restartmenu");
            Cursor.lockState = CursorLockMode.None;
        }
        if (temas.gameObject.tag == "home")
        {
            Welcomehome.SetActive(true);
        }
    }
}
