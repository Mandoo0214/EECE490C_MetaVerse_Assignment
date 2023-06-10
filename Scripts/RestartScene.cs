using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestartScene : MonoBehaviour
{
    public void ChangeSceneToMainWBtn()
    {
        TimerManager.time = 180;
        gameflow.missnum = 0;
        gameflow.orderTimer[0] = gameflow.MaxTimer;
        gameflow.orderTimer[1] = gameflow.MaxTimer;
        gameflow.orderTimer[2] = gameflow.MaxTimer;
        UnityEngine.SceneManagement.SceneManager.LoadScene("Start");
    }
}
