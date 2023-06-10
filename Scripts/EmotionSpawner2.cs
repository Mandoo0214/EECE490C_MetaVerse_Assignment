using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmotionSpawner2 : MonoBehaviour
{
    public GameObject A;
    public GameObject C;
    public GameObject S;

    GameObject Angury;
    GameObject Sad;
    GameObject Curious;

    bool alreadyhave = false;


    float tempTimer2;

    bool isMove2 = NPC_animator2.IsMove2;

    public Transform target;

    private Coroutine startC2 = null;
    private Coroutine normalC2 = null;
    
    // Start is called before the first frame update
    void Start()
    { }

    // Update is called once per frame
    void Update()
    {
        if (gameflow.orderTimer[2] <= 1f)
        {
            alreadyhave = false;
            Destroy(Angury);
        }
        else if (gameflow.orderTimer[2] <= 3f)
        {
            if (alreadyhave)
            { }
            else
            {
                Angury = Instantiate(A, target.position, target.rotation);
                alreadyhave = true;
            }

        }
        else if (gameflow.orderTimer[2] <= 4f)
        {
            alreadyhave = false;
            Destroy(Sad);
        }
        else if (gameflow.orderTimer[2] <= 5f)
        {
            if (alreadyhave)
            { }
            else
            {
                Sad = Instantiate(S, target.position, target.rotation);
                alreadyhave = true;
            }

        }
        else if (gameflow.orderTimer[2] <= 6f)
        {
            alreadyhave = false;
            Destroy(Curious);
        }
        else if (gameflow.orderTimer[2] <= 9f)
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