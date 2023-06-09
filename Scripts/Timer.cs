using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    Image timerBar;
    public static float maxTime = 10f;
    float timeLeft;
    //public GameObject timesUpText;

    void Start()
    {
        //timesUpText.SetActive (false);
        timerBar = GetComponent<Image>();
        timeLeft = maxTime;
    }

    // Update is called once per frame
    void Update()
    {
        if (timeLeft > 0)
        {
            timeLeft = gameflow.orderTimer[0];
            timerBar.fillAmount = timeLeft / maxTime;
        }
        else
        {
            //timesUpText.SetActive(true);
            //Time.timeScale = 0;
        }
    }
}