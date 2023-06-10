using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmotionSpawner1 : MonoBehaviour
{
    public GameObject A;
    public GameObject C;
    public GameObject S;

    float Timeleft1 = gameflow.orderTimer[1];

    float tempTimer1;

    bool isMove1 = NPC_animator1.IsMove1;

    public Transform target;

    private Coroutine startC1 = null;
    private Coroutine normalC1 = null;
    
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("111Start");
        tempTimer1 = 0f;
        startC1 = StartCoroutine("SpawnerForStart");
    }

    // Update is called once per frame
    void Update()
    {
        tempTimer1 += Time.deltaTime;
        
        if((tempTimer1 >= 1.5f) && (Timeleft1 == 15f) && (!isMove1))
        {
            Debug.Log("111Reset Timer");

            StopCoroutine(startC1);
            Debug.Log("111Stop startC");

            if(normalC1 == null)
            {
                Debug.Log("111Start new normalC");
                normalC1 = StartCoroutine("Spawner");
            }
            
            else
            {
                Debug.Log("111Start normalC again");
                StopCoroutine(normalC1);
                normalC1 = StartCoroutine("Spawner");
            }
        }
    }

    IEnumerator SpawnerForStart()
    {
        Debug.Log("111StartCoroutine");
        yield return new WaitForSeconds(0.5f);
        yield return new WaitUntil(() => isMove1 == false);

        Debug.Log("111Finish moving");
        
        yield return new WaitForSeconds(0.5f);

        yield return new WaitForSeconds(5f);
        QuestionSpawner();

        yield return new WaitForSeconds(4f);
        SadSpawner();

        yield return new WaitForSeconds(2f);
        AngrySpawner();

        yield return new WaitForSeconds(3f);  
    }

    IEnumerator Spawner(bool isRunning)
    {
        Debug.Log("111Start Spawner!!");
        
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