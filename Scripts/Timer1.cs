using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer1 : MonoBehaviour
{
    Image timerBar1;
    float maxTime1 = 15f;
    public static float timeLeft1;
    //public GameObject timesUpText;

    void Start()
    {
        //timesUpText.SetActive (false);
        timerBar1 = GetComponent<Image>();
        timeLeft1 = maxTime1;
    }

    // Update is called once per frame
    void Update()
    {
        if (timeLeft1 > 0)
        {
            timeLeft1 = gameflow.orderTimer[1];
            timerBar1.fillAmount = timeLeft1 / maxTime1;
        }
        else
        {
            //timesUpText.SetActive(true);
            //Time.timeScale = 0;
        }
    }
}