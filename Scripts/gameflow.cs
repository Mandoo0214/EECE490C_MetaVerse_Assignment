using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameflow : MonoBehaviour
{
    public static int [] orderValue= { 0,0,0};
    public static int [] plateValue = { 0,0,0};
    public static float [] orderTimer ={60,60,60};
    private int [] randomOrder= { 0, 0, 0 };

    public static int plateNum = 0;
    public static float plateXpos = -4;

    public Transform plateSelector;

    public MeshRenderer[] currentPic;

    public Texture[] orderPics;

    public static float emptyPlateNow = -1;

    public static float totalCash = 0;

    // Start is called before the first frame update
    void Start()
    {
        randomOrder[0] = Random.Range(1, 6);
        randomOrder[1] = Random.Range(1, 6);
        randomOrder[2] = Random.Range(1, 6);

        if (randomOrder[0] == 1)
            orderValue[0] = 110000;
        else if (randomOrder[0] == 2)
            orderValue[0] = 101000;
        else if (randomOrder[0] == 3)
            orderValue[0] = 100100;
        else if (randomOrder[0] == 4)
            orderValue[0] = 100010;
        else if (randomOrder[0] == 5)
            orderValue[0] = 100001;
        else
            orderValue[0] = 100100;

        if (randomOrder[1] == 1)
            orderValue[1] = 110000;
        else if (randomOrder[1] == 2)
            orderValue[1] = 101000;
        else if (randomOrder[1] == 3)
            orderValue[1] = 100100;
        else if (randomOrder[0] == 4)
            orderValue[1] = 100010;
        else if (randomOrder[1] == 5)
            orderValue[1] = 100001;
        else
            orderValue[1] = 101000;

        if (randomOrder[2] == 1)
            orderValue[2] = 110000;
        else if (randomOrder[2] == 2)
            orderValue[2] = 101000;
        else if (randomOrder[2] == 3)
            orderValue[2] = 100100;
        else if (randomOrder[2] == 4)
            orderValue[2] = 100010;
        else if (randomOrder[2] == 5)
            orderValue[2] = 100001;
        else
            orderValue[2] = 100100;


        for(int rep=0; rep<3; rep+=1)
        {
            if (orderValue[rep] == 110000)
                currentPic[rep].GetComponent<MeshRenderer>().material.mainTexture = orderPics[0];

            if (orderValue[rep] == 101000)
                currentPic[rep].GetComponent<MeshRenderer>().material.mainTexture = orderPics[1];

            if (orderValue[rep] == 100100)
                currentPic[rep].GetComponent<MeshRenderer>().material.mainTexture = orderPics[2];

            if (orderValue[rep] == 100010)
                currentPic[rep].GetComponent<MeshRenderer>().material.mainTexture = orderPics[3];

            if (orderValue[rep] == 100001)
                currentPic[rep].GetComponent<MeshRenderer>().material.mainTexture = orderPics[4];
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("tab"))
        {
            plateNum += 1;
            plateXpos += 4;

            if(plateNum>2)
            {
                plateNum = 0;
                plateXpos = -4;
            }
        }

        orderTimer[0] -= Time.deltaTime;
        orderTimer[1] -= Time.deltaTime;
        orderTimer[2] -= Time.deltaTime;

        plateSelector.transform.position = new Vector3(plateXpos, 0,0);
    }
}
