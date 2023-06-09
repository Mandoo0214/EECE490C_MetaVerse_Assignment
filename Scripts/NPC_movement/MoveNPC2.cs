using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveNPC2 : MonoBehaviour
{
    //public Vector3 initailPos;
    public Vector3 chairPos;
    public Vector3 sitPos;
    bool arrived = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        MoveToTarget();
    }

    void MoveToTarget()
    {
        if (chairPos != Vector3.MoveTowards(transform.position, chairPos, 0.02f) && arrived==false)
        {
            transform.position = Vector3.MoveTowards(transform.position, chairPos, 0.02f); // 현위치, 도착점, 속도

            transform.LookAt(chairPos);
            //Debug.Log(Vector3.MoveTowards(transform.position, target.transform.position, 1f));

            NPC_animator2.IsMove2 = true;
        }
        else { 
            NPC_animator2.IsMove2 = false;
            arrived = true;
            transform.position = sitPos;
            transform.rotation= Quaternion.Euler(0, -90, 0);
        }
    }


}