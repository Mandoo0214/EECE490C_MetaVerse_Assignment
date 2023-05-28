using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class serveplate : MonoBehaviour
{
    public int thisPlate;

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
