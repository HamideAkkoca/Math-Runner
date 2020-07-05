using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gate : MonoBehaviour
{
    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.name == "Player") {
            Debug.Log("You need at least 5 cubes to pass the level");  
        }
    }
}