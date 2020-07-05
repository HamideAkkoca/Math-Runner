using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour { 
        void OnTriggerEnter (Collider collider) {
        if (collider.gameObject.name == "player") {
            GameVariables.keyCount+=2;
            Destroy (gameObject);
        }
    }
}
