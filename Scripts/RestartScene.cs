using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestartScene : MonoBehaviour
{
    public void ChangeSceneToMainWBtn()
    {
        TimerManager.time = 180;
        gameflow.missnum = 0;
        UnityEngine.SceneManagement.SceneManager.LoadScene("Start");
    }
}
