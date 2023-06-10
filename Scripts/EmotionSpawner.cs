using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmotionSpawner : MonoBehaviour
{
    public GameObject A;
    public GameObject C;
    public GameObject S;

    GameObject Angury;
    GameObject Sad;
    GameObject Curious;

    bool alreadyhave = false;


    float Timeleft = gameflow.orderTimer[0];

    float tempTimer;

    bool isMove = NPC_animator.IsMove;

    public Transform target;

    private Coroutine startC = null;
    private Coroutine normalC = null;
    
    // Start is called before the first frame update
    void Start()
    { }

    // Update is called once per frame
    void Update()
    {
        if (gameflow.orderTimer[0] <= 1f)
        {
            alreadyhave = false;
            Destroy(Angury);
        }
        else if (gameflow.orderTimer[0] <= 7f)
        {
            if(alreadyhave)
            { }
            else
            {
                Angury = Instantiate(A, target.position, target.rotation);
                alreadyhave = true;
            }
            
        }
        else if (gameflow.orderTimer[0] <= 8f)
        {
            alreadyhave = false;
            Destroy(Sad);
        }
        else if (gameflow.orderTimer[0] <= 14f)
        {
            if (alreadyhave)
            { }
            else
            {
                Sad = Instantiate(S, target.position, target.rotation);
                alreadyhave = true;
            }
            
        }
        else if (gameflow.orderTimer[0] <= 15f)
        {
            alreadyhave = false;
            Destroy(Curious);
        }
        else if (gameflow.orderTimer[0] <= 20f)
        {
            if (alreadyhave)
            { }
            else
            {
                Curious = Instantiate(C, target.position, target.rotation);
                alreadyhave = true;
            }
            
        }
        else
        {
            Destroy(Curious);
            Destroy(Angury);
            Destroy(Sad);
            alreadyhave = false;
        }

    }

}