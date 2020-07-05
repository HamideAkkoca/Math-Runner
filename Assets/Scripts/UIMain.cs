using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIMain : MonoBehaviour
{
    [Header("UIPages")]
    public GameObject settingsScreen;
    public GameObject mainScreen;
    public void STARTGAME()
    {
        //Oyunu başlatacak kısım.
        SceneManager.LoadScene("Math_Runner");
    }
    public void MAINMENU()
    {
        SceneManager.LoadScene("Anamenu");
    }
    public void EXIT()
    {
        Application.Quit();
    }
}
