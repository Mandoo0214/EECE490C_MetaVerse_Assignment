using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class serveplate : MonoBehaviour
{
    public int thisPlate;
    GameObject Destroywrong;

    public AudioSource correctAudio;
    public AudioSource wrongAudio;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
  
        if (gameflow.orderValue[gameflow.plateNum] == gameflow.plateValue[gameflow.plateNum])
        {
            Debug.Log("correct" + " " + gameflow.plateNum + " " + gameflow.orderValue[gameflow.plateNum]);
            //success sound
            correctAudio.Stop();
            correctAudio.Play();

            //reset values
            //gameflow.plateValue[gameflow.plateNum] = 0;
            gameflow.orderTimer[gameflow.plateNum] = 0;
        }
        else
        {

            if(gameflow.plateValue[gameflow.plateNum]==110000)
            {
                wrongAudio.Stop();
                wrongAudio.Play();

                gameflow.plateValue[gameflow.plateNum] = 0;
            }

            if (gameflow.plateValue[gameflow.plateNum] == 101000)
            {
                wrongAudio.Stop();
                wrongAudio.Play();

                gameflow.plateValue[gameflow.plateNum] = 0;
            }

            if (gameflow.plateValue[gameflow.plateNum] == 100100)
            {
                wrongAudio.Stop();
                wrongAudio.Play();

                gameflow.plateValue[gameflow.plateNum] = 0;
            }

            if (gameflow.plateValue[gameflow.plateNum] == 100010)
            {
                wrongAudio.Stop();
                wrongAudio.Play();

                gameflow.plateValue[gameflow.plateNum] = 0;
            }

            if (gameflow.plateValue[gameflow.plateNum] == 100001)
            {
                wrongAudio.Stop();
                wrongAudio.Play();

                gameflow.plateValue[gameflow.plateNum] = 0;
            }

        }

    }

}
