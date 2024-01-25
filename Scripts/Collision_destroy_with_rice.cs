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
        Destroy(DestroyRice, 3);

        if (col.gameObject.name == "Tuna_sashimi(Clone)")
        {
            Destroy(DestroyRice,0);
            Destroy(this, 0);
            Destroy(col.gameObject);
            Destroy(this, 0);
            gameflow.plateValue[gameflow.plateNum] = (100000+100);
            Destroy(DestroyRice, 0);
            Destroy(this, 0);
            GameObject TunaSushi = Instantiate(Tuna, new Vector3((float)-2.3, (float)1.991, gameflow.plateZpos), Tuna.transform.rotation);
            Destroy(DestroyRice, 0);
            Destroy(this, 0);
            Destroy(TunaSushi,3);
        }

        if (col.gameObject.name == "Ebi_sashimi(Clone)")
        {
            Destroy(DestroyRice, 0);
            Destroy(this, 0);
            Destroy(col.gameObject);
            Destroy(this, 0);
            gameflow.plateValue[gameflow.plateNum] = (100000 + 10000);
            Destroy(DestroyRice, 0);
            Destroy(this, 0);
            GameObject EbiSushi = Instantiate(Ebi, new Vector3((float)-2.3, (float)1.791, gameflow.plateZpos), Ebi.transform.rotation);
            Destroy(DestroyRice, 0);
            Destroy(this, 0);
            Destroy(EbiSushi, 3);
        }

        if (col.gameObject.name == "Squid_sashimi(Clone)")
        {
            Destroy(DestroyRice, 0);
            Destroy(this, 0);
            Destroy(col.gameObject);
            Destroy(this, 0);
            gameflow.plateValue[gameflow.plateNum] = (100000 + 1);
            Destroy(DestroyRice, 0);
            Destroy(this, 0);
            GameObject SquidSushi =Instantiate(Squid, new Vector3((float)-2.3, (float)1.791, gameflow.plateZpos), Squid.transform.rotation);
            Destroy(DestroyRice, 0);
            Destroy(this, 0);
            Destroy(SquidSushi, 3);
        }

        if (col.gameObject.name == "Kohada_sashimi(Clone)")
        {
            Destroy(DestroyRice, 0);
            Destroy(this, 0);
            Destroy(col.gameObject);
            Destroy(this, 0);
            gameflow.plateValue[gameflow.plateNum] = (100000 + 10);
            Destroy(DestroyRice, 0);
            Destroy(this, 0);
            GameObject KohadaSushi = Instantiate(Kohada, new Vector3((float)-2.3, (float)1.791, gameflow.plateZpos), Kohada.transform.rotation);
            Destroy(DestroyRice, 0);
            Destroy(this, 0);
            Destroy(KohadaSushi, 3);
        }

        if (col.gameObject.name == "Salmon_sashimi(Clone)")
        {
            Destroy(DestroyRice, 0);
            Destroy(this, 0);
            Destroy(col.gameObject);
            Destroy(this, 0);
            gameflow.plateValue[gameflow.plateNum] = (100000 + 1000);
            Destroy(DestroyRice, 0);
            Destroy(this, 0);
            GameObject SalmonSushi = Instantiate(Salmon, new Vector3((float)-2.3, (float)1.791, gameflow.plateZpos), Salmon.transform.rotation);
            Destroy(DestroyRice, 0);
            Destroy(this, 0);
            Destroy(SalmonSushi, 3);
        }
    }
}