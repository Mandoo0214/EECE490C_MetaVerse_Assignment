using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class gameflow : MonoBehaviour
{
    public static float MaxTimer = 30;

    public static int[] orderValue = { 0, 0, 0 };
    public static int[] plateValue = { 0, 0, 0 };
    public static float[] orderTimer = { MaxTimer, MaxTimer, MaxTimer };
    private int[] randomOrder = { 0, 0, 0 };
    public static int[] specialOrder = { 1,1,1};
    public static int missnum = 0;

    public static int plateNum = 0;
    public static float plateZpos = (float)0.229;

    public Transform plateSelector;

    public Image[] currentPic;

    public Sprite[] orderPics;

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


        for (int rep = 0; rep < 3; rep += 1)
        {
            if (orderValue[rep] == 110000)
                currentPic[rep].GetComponent<Image>().sprite = orderPics[0];

            if (orderValue[rep] == 101000)
                currentPic[rep].GetComponent<Image>().sprite = orderPics[1];

            if (orderValue[rep] == 100100)
                currentPic[rep].GetComponent<Image>().sprite = orderPics[2];

            if (orderValue[rep] == 100010)
                currentPic[rep].GetComponent<Image>().sprite = orderPics[3];

            if (orderValue[rep] == 100001)
                currentPic[rep].GetComponent<Image>().sprite = orderPics[4];
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("tab") || ARAVRInput.GetDown(ARAVRInput.Button.One))
        {
            plateNum += 1;
            plateZpos -= (float)0.5;

            if (plateNum > 2)
            {
                plateNum = 0;
                plateZpos = (float)0.229;
            }
        }

        if (!NPC_animator.IsMove)
        {
            orderTimer[0] -= Time.deltaTime;
        }

        if (!NPC_animator1.IsMove1)
        {
            orderTimer[1] -= Time.deltaTime;
        }

        if (!NPC_animator2.IsMove2)
        {
            orderTimer[2] -= Time.deltaTime;
        }

        if (orderTimer[0] <= 0)
        {
            if (orderValue[0] != plateValue[0])
            {
                missnum += 1;
            }

            plateValue[0] = 0;//reset plate

            orderTimer[0] = MaxTimer; //reset Timer

            specialOrder[0] = Random.Range(0,10);
            randomOrder[0] = Random.Range(1, 6);

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

            //set the new picture
            if (specialOrder[0] == 0)
            {
                if (orderValue[0] == 110000)
                    currentPic[0].GetComponent<Image>().sprite = orderPics[5];

                if (orderValue[0] == 101000)
                    currentPic[0].GetComponent<Image>().sprite = orderPics[6];

                if (orderValue[0] == 100100)
                    currentPic[0].GetComponent<Image>().sprite = orderPics[7];

                if (orderValue[0] == 100010)
                    currentPic[0].GetComponent<Image>().sprite = orderPics[8];

                if (orderValue[0] == 100001)
                    currentPic[0].GetComponent<Image>().sprite = orderPics[9];
            }
            else
            {
                if (orderValue[0] == 110000)
                    currentPic[0].GetComponent<Image>().sprite = orderPics[0];

                if (orderValue[0] == 101000)
                    currentPic[0].GetComponent<Image>().sprite = orderPics[1];

                if (orderValue[0] == 100100)
                    currentPic[0].GetComponent<Image>().sprite = orderPics[2];

                if (orderValue[0] == 100010)
                    currentPic[0].GetComponent<Image>().sprite = orderPics[3];

                if (orderValue[0] == 100001)
                    currentPic[0].GetComponent<Image>().sprite = orderPics[4];
            }
            
        }

        if (orderTimer[1] <= 0)
        {
            if (orderValue[1] != plateValue[1])
            {
                missnum += 1;
            }

            plateValue[1] = 0;//reset plate
            orderTimer[1] = MaxTimer; //reset Timer

            randomOrder[1] = Random.Range(1, 6);
            specialOrder[1] = Random.Range(0, 10);

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

            //set the new picture
            if(specialOrder[1]==0)
            {
                if (orderValue[1] == 110000)
                    currentPic[1].GetComponent<Image>().sprite = orderPics[5];

                if (orderValue[1] == 101000)
                    currentPic[1].GetComponent<Image>().sprite = orderPics[6];

                if (orderValue[1] == 100100)
                    currentPic[1].GetComponent<Image>().sprite = orderPics[7];

                if (orderValue[1] == 100010)
                    currentPic[1].GetComponent<Image>().sprite = orderPics[8];

                if (orderValue[1] == 100001)
                    currentPic[1].GetComponent<Image>().sprite = orderPics[9];
            }
            else
            {
                if (orderValue[1] == 110000)
                    currentPic[1].GetComponent<Image>().sprite = orderPics[0];

                if (orderValue[1] == 101000)
                    currentPic[1].GetComponent<Image>().sprite = orderPics[1];

                if (orderValue[1] == 100100)
                    currentPic[1].GetComponent<Image>().sprite = orderPics[2];

                if (orderValue[1] == 100010)
                    currentPic[1].GetComponent<Image>().sprite = orderPics[3];

                if (orderValue[1] == 100001)
                    currentPic[1].GetComponent<Image>().sprite = orderPics[4];
            }
            
        }

        if (orderTimer[2] <= 0)
        {
            if (orderValue[2] != plateValue[2])
            {
                missnum += 1;
            }

            plateValue[2] = 0;//reset plate

            orderTimer[2] = MaxTimer; //reset Timer

            randomOrder[2] = Random.Range(1, 6);
            specialOrder[2] = Random.Range(0, 10);

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

            //set the new picture
            if(specialOrder[2]==0)
            {
                if (orderValue[2] == 110000)
                    currentPic[2].GetComponent<Image>().sprite = orderPics[5];

                if (orderValue[2] == 101000)
                    currentPic[2].GetComponent<Image>().sprite = orderPics[6];

                if (orderValue[2] == 100100)
                    currentPic[2].GetComponent<Image>().sprite = orderPics[7];

                if (orderValue[2] == 100010)
                    currentPic[2].GetComponent<Image>().sprite = orderPics[8];

                if (orderValue[2] == 100001)
                    currentPic[2].GetComponent<Image>().sprite = orderPics[9];
            }
            else
            {
                if (orderValue[2] == 110000)
                    currentPic[2].GetComponent<Image>().sprite = orderPics[0];

                if (orderValue[2] == 101000)
                    currentPic[2].GetComponent<Image>().sprite = orderPics[1];

                if (orderValue[2] == 100100)
                    currentPic[2].GetComponent<Image>().sprite = orderPics[2];

                if (orderValue[2] == 100010)
                    currentPic[2].GetComponent<Image>().sprite = orderPics[3];

                if (orderValue[2] == 100001)
                    currentPic[2].GetComponent<Image>().sprite = orderPics[4];
            }
            
        }

        //set the position of plateSelector
        plateSelector.transform.position = new Vector3((float)-2.610, (float)1.787, plateZpos);
    }
}