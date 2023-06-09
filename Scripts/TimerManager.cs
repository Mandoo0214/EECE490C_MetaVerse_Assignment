using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerManager : MonoBehaviour
{
    
    public Text[] text_time; // �ð��� ǥ���� text
    public Text btn_text; //���¿� ���� ��ư�� text�� ���� �ϱ����� text
    float time=300; // �ð�.


    private void Start()
    {
        
    }
    
    private void Update() // �ٲ�� �ð��� text�� �ݿ� �� �� update �����ֱ�
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