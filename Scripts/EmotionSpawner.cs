using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmotionSpawner : MonoBehaviour
{
    public GameObject A;
    public GameObject C;
    public GameObject S;

    float Timeleft = gameflow.orderTimer[0];

    float tempTimer;

    bool isMove = NPC_animator.IsMove;

    public Transform target;

    private Coroutine startC = null;
    private Coroutine normalC = null;
    
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start");
        tempTimer = 0f;
        startC = StartCoroutine("SpawnerForStart");
    }

    // Update is called once per frame
    void Update()
    {
        tempTimer += Time.deltaTime;

        if((tempTimer >= 10f) && (Timeleft >= 14.98f) && (!isMove))
        {
            Debug.Log("Reset Timer");

            StopCoroutine(startC);
            Debug.Log("Stop startC");

            if(normalC == null)
            {
                Debug.Log("Start new normalC");
                normalC = StartCoroutine("Spawner");
            }
            
            else
            {
                Debug.Log("Start normalC again");
                StopCoroutine(normalC);
                normalC = StartCoroutine("Spawner");
            }
        }
    }

    IEnumerator SpawnerForStart()
    {
        Debug.Log("StartCoroutine");
        yield return new WaitUntil(() => isMove == true);
        yield return new WaitUntil(() => isMove == false);

        Debug.Log("Finish moving");
        
        yield return new WaitForSeconds(0.5f);

        yield return new WaitForSeconds(4f);
        QuestionSpawner();

        yield return new WaitForSeconds(4f);
        SadSpawner();

        yield return new WaitForSeconds(2f);
        AngrySpawner();

        yield return new WaitForSeconds(3f);  
    }

    IEnumerator Spawner()
    {
        Debug.Log("Start Spawner!!");
        
        yield return new WaitForSeconds(6f);
        QuestionSpawner();

        yield return new WaitForSeconds(4f);
        SadSpawner();

        yield return new WaitForSeconds(2f);
        AngrySpawner();

        yield return new WaitForSeconds(3f);
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