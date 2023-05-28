using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmotionSpawner : MonoBehaviour
{
    public GameObject A;
    public GameObject C;
    public GameObject S;

    public Transform target;
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("Spawner");
    }

    // Update is called once per frame
    void Update()
    {
    }

    IEnumerator Spawner()
    {
        yield return new WaitForSeconds(30f);
        QuestionSpawner();
        yield return new WaitForSeconds(10f);
        SadSpawner();
        yield return new WaitForSeconds(10f);
        AngrySpawner();

        yield return new WaitForSeconds(10f);
        StartCoroutine("Spawner");
    }

    void QuestionSpawner()
    {
        Debug.Log("Question");
        GameObject Curious = Instantiate(C, target.position, target.rotation);
        Destroy(Curious, 5f);
        Debug.Log("Question End");
    }

    void SadSpawner()
    {
        Debug.Log("Sad");
        GameObject Sad = Instantiate(S, target.position, target.rotation);
        Destroy(Sad, 5f);
        Debug.Log("Sad End");
    }

    void AngrySpawner()
    {
        Debug.Log("Angry");
        GameObject Angry = Instantiate(A, target.position, target.rotation);
        Destroy(Angry, 5f);
        Debug.Log("Angry End");
    }
}
