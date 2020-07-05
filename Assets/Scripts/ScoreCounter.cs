using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour
{
    public Text countText;
    public GameObject Cube;
    public Text winText;
    public int count;
    void Start()
    {
        SetCountText();
    }
    void OnTriggerEnter(Collider temas)
    {
        if(temas.gameObject.tag == "1")
        {
            count = count +1;
            countText.text = "Point: " + count.ToString();
            Destroy(temas.gameObject);
       
            SetCountText();
        }
       
       if (temas.gameObject.tag == "3")
            {
                count = count + 3;
                countText.text = "Point: " + count.ToString();
                Destroy(temas.gameObject);

                SetCountText();
            }

        if (temas.gameObject.tag == "5")
        {
            count = count + 5;
            countText.text = "Point: " + count.ToString();
            Destroy(temas.gameObject);

            SetCountText();
        }

        if (temas.gameObject.tag == "7")
        {
            count = count + 7;
            countText.text = "Point: " + count.ToString();
            Destroy(temas.gameObject);
            SetCountText();
        }

        if (temas.gameObject.tag == "9")
        {
            count = count + 9;
            countText.text = "Point: " + count.ToString();
            Destroy(temas.gameObject);
            SetCountText();
        }
    }
    void SetCountText()
    {
        countText.text = "Count: " + count.ToString();
    }
}
