using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickplace : MonoBehaviour
{
    public Transform cloneObj;
    public int foodValue;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        if (gameObject.name == "Rice_button")
            Instantiate(cloneObj, new Vector3(gameflow.plateXpos, 5, 0), cloneObj.rotation);

        if (gameObject.name == "Ebi_button")
            Instantiate(cloneObj, new Vector3(gameflow.plateXpos, 5, 0), cloneObj.rotation);

        if (gameObject.name == "Salmon_button")
            Instantiate(cloneObj, new Vector3(gameflow.plateXpos, 5, 0), cloneObj.rotation);

        if (gameObject.name == "Tuna_button")
            Instantiate(cloneObj, new Vector3(gameflow.plateXpos, 5, 0), cloneObj.rotation);

        if (gameObject.name == "Kohada_button")
            Instantiate(cloneObj, new Vector3(gameflow.plateXpos, 5, 0), cloneObj.rotation);

        if (gameObject.name == "Squid_button")
            Instantiate(cloneObj, new Vector3(gameflow.plateXpos, 5, 0), cloneObj.rotation);

        gameflow.plateValue[gameflow.plateNum] += foodValue;
        Debug.Log(gameflow.plateNum+ " "+gameflow.plateValue[gameflow.plateNum] + " " + gameflow.orderValue[gameflow.plateNum]);
    }
}
