using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Startext : MonoBehaviour
{

    public GameObject textObj;
    // Start is called before the first frame update
    void Start()
    {
        textObj.GetComponent<Text>().text = "�� �� �� �� ��";
    }

    // Update is called once per frame
    void Update()
    {
        if(gameflow.missnum==0)
        {
            textObj.GetComponent<Text>().text = "�� �� �� �� ��";
        }
        else if(gameflow.missnum==1)
        {
            textObj.GetComponent<Text>().text = "�� �� �� ��";
        }
        else if (gameflow.missnum == 2)
        {
            textObj.GetComponent<Text>().text = "�� �� ��";
        }
        else if (gameflow.missnum == 3)
        {
            textObj.GetComponent<Text>().text = "�� ��";
        }
        else if (gameflow.missnum == 4)
        {
            textObj.GetComponent<Text>().text = "��";
        }
        else
        {
            textObj.GetComponent<Text>().text = "      ";
            UnityEngine.SceneManagement.SceneManager.LoadScene("GameOver");
        }

    }
}
