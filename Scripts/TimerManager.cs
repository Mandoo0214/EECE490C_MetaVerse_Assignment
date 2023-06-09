using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerManager : MonoBehaviour
{
    
    public Text[] text_time; // 시간을 표시할 text
    public Text btn_text; //상태에 따라 버튼의 text를 변경 하기위한 text
    float time=300; // 시간.


    private void Start()
    {
        
    }
    
    private void Update() // 바뀌는 시간을 text에 반영 해 줄 update 생명주기
    {
        time -= Time.deltaTime;
        text_time[0].text = ((int)time / 60 % 60).ToString("D2");
        text_time[1].text = ((int)time % 60).ToString("D2");

        if(time<=0)
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("GameClear");
        }
    }
}