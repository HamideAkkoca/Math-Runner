using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchScenes : MonoBehaviour
{
    public void sahne_geciss()
    {
        SceneManager.LoadScene("Math_Runner");
    }
    public void mainmenu()
    {
        SceneManager.LoadScene("runner4");
    }
}
