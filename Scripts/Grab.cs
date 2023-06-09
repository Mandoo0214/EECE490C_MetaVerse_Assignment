using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grab : MonoBehaviour
{
    // Start is called before the first frame update
    bool isGrabbing = false;
    GameObject grabbedObject;
    public LayerMask grabbedLayer;
    public float grabRange = 0.2f;
    public GameObject Squid;
    public GameObject Kohada;
    public GameObject Ebi;
    public GameObject Tuna;
    public GameObject Salmon;
    public GameObject Rice;

    private void Update()
    {
        if(isGrabbing == false)
        {
            TryGrab();
        }
        else
        {
            TryUngrab();
        }
    }
    private void TryUngrab()
    {
        if (ARAVRInput.GetUp(ARAVRInput.Button.HandTrigger, ARAVRInput.Controller.RTouch))
        {
            isGrabbing = false;
            grabbedObject.GetComponent<Rigidbody>().isKinematic = false;
            grabbedObject.transform.parent = null;
            grabbedObject = null;
        }
    }

    private void TryGrab()
    {
        if (ARAVRInput.GetDown(ARAVRInput.Button.HandTrigger, ARAVRInput.Controller.RTouch))
        {
            int closest = 0;
            Collider[] hitObjects = Physics.OverlapSphere(ARAVRInput.RHandPosition, grabRange, grabbedLayer);
            for(int i = 1; i < hitObjects.Length; i++)
            {
                Vector3 closestPos = hitObjects[closest].transform.position;
                float closestDistance = Vector3.Distance(closestPos, ARAVRInput.RHandPosition);
                Vector3 nextPos = hitObjects[i].transform.position;
                float nextDistance = Vector3.Distance(nextPos, ARAVRInput.RHandPosition);
                if (nextDistance < closestDistance)
                {
                    closest = i;
                }
                if (hitObjects.Length > 0)
                {
                    isGrabbing = true;
                    if(hitObjects[closest].gameObject.name== "Ebi_sashimi(Clone)")
                    {
                        Vector3 spotPos = hitObjects[closest].gameObject.transform.position;
                        Instantiate(Ebi, spotPos, Ebi.transform.rotation);
                        grabbedObject = Ebi;
                    }
                    else if (hitObjects[closest].gameObject.name == "Salmon_sashimi(Clone)")
                    {
                        Vector3 spotPos = hitObjects[closest].gameObject.transform.position;
                        Instantiate(Salmon, spotPos, Salmon.transform.rotation);
                        grabbedObject = Salmon;
                    }
                    else if (hitObjects[closest].gameObject.name == "Tuna_sashimi(Clone)")
                    {
                        Vector3 spotPos = hitObjects[closest].gameObject.transform.position;
                        Instantiate(Tuna, spotPos, Tuna.transform.rotation);
                        grabbedObject = Tuna;
                    }
                    else if (hitObjects[closest].gameObject.name == "Squid_sashimi(Clone)")
                    {
                        Vector3 spotPos = hitObjects[closest].gameObject.transform.position;
                        Instantiate(Squid, spotPos, Squid.transform.rotation);
                        grabbedObject = Squid;
                    }
                    else if (hitObjects[closest].gameObject.name == "Kohada_sashimi(Clone)")
                    {
                        Vector3 spotPos = hitObjects[closest].gameObject.transform.position;
                        Instantiate(Kohada, spotPos, Kohada.transform.rotation);
                        grabbedObject = Kohada;
                    }
                    else if (hitObjects[closest].gameObject.name == "Sashimi_rice(Clone)")
                    {
                        Vector3 spotPos = hitObjects[closest].gameObject.transform.position;
                        Instantiate(Rice, spotPos, Rice.transform.rotation);
                        grabbedObject = Rice;
                    }
                    //grabbedObject = hitObjects[closest].gameObject;
                    grabbedObject.transform.parent = ARAVRInput.RHand;
                    grabbedObject.GetComponent<Rigidbody>().isKinematic = true;
                }
            }
        }
    }
}

