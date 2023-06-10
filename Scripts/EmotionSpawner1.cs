using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmotionSpawner1 : MonoBehaviour
{
    public GameObject A;
    public GameObject C;
    public GameObject S;

    GameObject Angury;
    GameObject Sad;
    GameObject Curious;

    bool alreadyhave = false;


    float tempTimer1;

    bool isMove1 = NPC_animator1.IsMove1;

    public Transform target;

    private Coroutine startC1 = null;
    private Coroutine normalC1 = null;
    
    // Start is called before the first frame update
    void Start()
    { }

    // Update is called once per frame
    void Update()
    {
        if (gameflow.orderTimer[1] <= 1f)
        {
            alreadyhave = false;
            Destroy(Angury);
        }
        else if (gameflow.orderTimer[1] <= 7f)
        {
            if (alreadyhave)
            { }
            else
            {
                Angury = Instantiate(A, target.position, target.rotation);
                alreadyhave = true;
            }

        }
        else if (gameflow.orderTimer[1] <= 8f)
        {
            alreadyhave = false;
            Destroy(Sad);
        }
        else if (gameflow.orderTimer[1] <= 14f)
        {
            if (alreadyhave)
            { }
            else
            {
                Sad = Instantiate(S, target.position, target.rotation);
                alreadyhave = true;
            }

        }
        else if (gameflow.orderTimer[1] <= 15f)
        {
            alreadyhave = false;
            Destroy(Curious);
        }
        else if (gameflow.orderTimer[1] <= 20f)
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