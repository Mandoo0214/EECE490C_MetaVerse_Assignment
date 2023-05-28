using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision_destroy_with_rice : MonoBehaviour
{

    GameObject DestroyRice;

    public GameObject Squid;
    public GameObject Kohada;
    public GameObject Ebi;
    public GameObject Tuna;
    public GameObject Salmon;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision col)
    {
        DestroyRice = GameObject.Find("Sashimi_rice(Clone)");

        if (col.gameObject.name=="Tuna_sashimi(Clone)")
        {
            Destroy(col.gameObject);
            Destroy(DestroyRice);

            Instantiate(Tuna, new Vector3((float)-2.651, (float)1.991, gameflow.plateZpos), Tuna.transform.rotation);
        }

        if (col.gameObject.name == "Ebi_sashimi(Clone)")
        {
            Destroy(col.gameObject);
            Destroy(DestroyRice);

            Instantiate(Ebi, new Vector3((float)-2.651, (float)1.791, gameflow.plateZpos), Ebi.transform.rotation);
        }

        if (col.gameObject.name == "Squid_sashimi(Clone)")
        {
            Destroy(col.gameObject);
            Destroy(DestroyRice);

            Instantiate(Squid, new Vector3((float)-2.651, (float)1.791, gameflow.plateZpos), Squid.transform.rotation);
        }

        if (col.gameObject.name == "Kohada_sashimi(Clone)")
        {
            Destroy(col.gameObject);
            Destroy(DestroyRice);

            Instantiate(Kohada, new Vector3((float)-2.651, (float)1.791, gameflow.plateZpos), Kohada.transform.rotation);
        }

        if (col.gameObject.name == "Salmon_sashimi(Clone)")
        {
            Destroy(col.gameObject);
            Destroy(DestroyRice);

            Instantiate(Salmon, new Vector3((float)-2.651, (float)1.791, gameflow.plateZpos), Salmon.transform.rotation);
        }
    }
}
