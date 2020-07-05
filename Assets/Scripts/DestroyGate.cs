using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyGate : MonoBehaviour
{
    public string doorTag;
    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.name == "Player") {
            GameVariables.cubeCount++;
            Debug.Log(GameVariables.cubeCount);
            if (GameVariables.cubeCount == 5)
            {
                Debug.Log("Congratz you passed the level");
                GameObject door = GameObject.FindGameObjectWithTag(doorTag);
                door.SetActive(false);
            }     
            Destroy(gameObject);
        }
    }
}