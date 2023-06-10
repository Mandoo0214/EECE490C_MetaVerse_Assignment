using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer2 : MonoBehaviour
{
    Image timerBar2;
    float maxTime2 = gameflow.MaxTimer;
    public static float timeLeft2;
    //public GameObject timesUpText;

    void Start()
    {
        //timesUpText.SetActive (false);
        timerBar2 = GetComponent<Image>();
        timeLeft2 = maxTime2;
    }

    // Update is called once per frame
    void Update()
    {
        if (timeLeft2 > 0)
        {
            timeLeft2 = gameflow.orderTimer[2];
            timerBar2.fillAmount = timeLeft2 / maxTime2;
        }
        else
        {
            //timesUpText.SetActive(true);
            //Time.timeScale = 0;
        }
    }
}
