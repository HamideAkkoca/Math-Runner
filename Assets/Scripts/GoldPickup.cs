using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldPickup : MonoBehaviour
{
    public int value;
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "player")
        {
            FindObjectOfType<GameManager>().AddGold(value);

            Destroy(gameObject);
        }
    }
}
