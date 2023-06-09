using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StarNumtext : MonoBehaviour
{

    public GameObject textObj;
    // Start is called before the first frame update
    void Start()
    {
        textObj.GetComponent<Text>().text = "5 / 5";
    }

    // Update is called once per frame
    void Update()
    {
        if (gameflow.missnum == 0)
        {
            textObj.GetComponent<Text>().text = "5 / 5";
        }
        else if (gameflow.missnum == 1)
        {
            textObj.GetComponent<Text>().text = "4 / 5";
        }
        else if (gameflow.missnum == 2)
        {
            textObj.GetComponent<Text>().text = "3 / 5";
        }
        else if (gameflow.missnum == 3)
        {
            textObj.GetComponent<Text>().text = "2 / 5";
        }
        else if (gameflow.missnum == 4)
        {
            textObj.GetComponent<Text>().text = "1 / 5";
        }
        else
        {
            textObj.GetComponent<Text>().text = "0 / 5";
        }

    }
}