using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmotionSpawner2 : MonoBehaviour
{
    public GameObject A;
    public GameObject C;
    public GameObject S;

    float Timeleft2 = gameflow.orderTimer[2];

    float tempTimer2;

    bool isMove2 = NPC_animator2.IsMove2;

    public Transform target;

    private Coroutine startC2 = null;
    private Coroutine normalC2 = null;
    
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("222Start");
        tempTimer2 = 0f;
        startC2 = StartCoroutine("SpawnerForStart");
    }

    // Update is called once per frame
    void Update()
    {
        tempTimer2 += Time.deltaTime;
        
        if((tempTimer2 >= 1.5f) && (Timeleft2 == 15f) && (!isMove2))
        {
            Debug.Log("222Reset Timer");

            StopCoroutine(startC2);
            Debug.Log("222Stop startC");

            if(normalC2 == null)
            {
                Debug.Log("222Start new normalC");
                normalC2 = StartCoroutine("Spawner");
            }
            
            else
            {
                Debug.Log("222Start normalC again");
                StopCoroutine(normalC2);
                normalC2 = StartCoroutine("Spawner");
            }
        }
    }

    IEnumerator SpawnerForStart()
    {
        Debug.Log("222StartCoroutine");
        yield return new WaitForSeconds(0.5f);
        yield return new WaitUntil(() => isMove2 == false);

        Debug.Log("222Finish moving");
        
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
        Debug.Log("222Start Spawner!!");
        
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