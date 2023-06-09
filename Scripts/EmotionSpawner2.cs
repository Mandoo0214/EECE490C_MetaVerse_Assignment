using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmotionSpawner2 : MonoBehaviour
{
    public GameObject A;
    public GameObject C;
    public GameObject S;

    bool isMove2 = NPC_animator2.IsMove2;

    float Timeleft = gameflow.orderTimer[0];

    public Transform target;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("Spawner", true);
    }

    // Update is called once per frame
    void Update()
    {
    }

    IEnumerator Spawner(bool isRunning)
    {
        yield return new WaitUntil(() => isMove2 == false);

        while (isRunning)
        {
            if (Timeleft == 9f)
                QuestionSpawner();

            if (Timeleft == 5f)
                SadSpawner();

            if (Timeleft == 3f)
                AngrySpawner();
        }
    }

    void QuestionSpawner()
    {
        GameObject Curious = Instantiate(C, target.position, target.rotation);
        Destroy(Curious, 1.5f);
    }

    void SadSpawner()
    {
        GameObject Sad = Instantiate(S, target.position, target.rotation);
        Destroy(Sad, 1.5f);
    }

    void AngrySpawner()
    {
        GameObject Angry = Instantiate(A, target.position, target.rotation);
        Destroy(Angry, 1.5f);
    }
}