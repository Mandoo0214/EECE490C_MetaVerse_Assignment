using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class serveplate : MonoBehaviour
{
    public int thisPlate;
    GameObject Destroywrong;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
  
        if (gameflow.orderValue[gameflow.plateNum] == gameflow.plateValue[gameflow.plateNum])
        {
            Debug.Log("correct"+ " "+ gameflow.plateNum+" "+gameflow.orderValue[gameflow.plateNum]);
            gameflow.plateValue[gameflow.plateNum] =0;      
        }
        else
        {
            if(gameflow.plateValue[gameflow.plateNum]==110000)
            {
                Destroywrong= GameObject.Find("Sushi_Shrimp Variant(Clone)");
                Destroy(Destroywrong, 1f);
            }

            if (gameflow.plateValue[gameflow.plateNum] == 101000)
            {
                Destroywrong = GameObject.Find("Sushi_Salmon Variant(Clone)");
                Destroy(Destroywrong, 1f);
            }

            if (gameflow.plateValue[gameflow.plateNum] == 100100)
            {
                Destroywrong = GameObject.Find("Sushi_Tuna Variant(Clone)");
                Destroy(Destroywrong, 1f);
            }

            if (gameflow.plateValue[gameflow.plateNum] == 100010)
            {
                Destroywrong = GameObject.Find("Sushi_Gizzard_Shad Variant(Clone)");
                Destroy(Destroywrong, 1f);
            }

            if (gameflow.plateValue[gameflow.plateNum] == 100001)
            {
                Destroywrong = GameObject.Find("Sushi_Squid Variant(Clone)");
                Destroy(Destroywrong, 1f);
            }

            //gameflow.plateValue[gameflow.plateNum] = 0;
        }

        gameflow.emptyPlateNow = transform.position.x;
        StartCoroutine(platereset());
        
    }

    IEnumerator platereset()
    {
        yield return new WaitForSeconds(.2f);
        gameflow.emptyPlateNow = -1;
        gameflow.totalCash += gameflow.orderTimer[thisPlate] * .10f;
    }
}
