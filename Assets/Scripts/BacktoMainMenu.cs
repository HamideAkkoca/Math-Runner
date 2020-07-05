using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BacktoMainMenu : MonoBehaviour
{
    public void BacktoMenu()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
