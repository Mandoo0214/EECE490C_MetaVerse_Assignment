using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabL : MonoBehaviour
{
    // Start is called before the first frame update
    bool isGrabbingL = false;
    GameObject grabbedObjectL;
    public LayerMask grabbedLayer;
    public float grabRange = 0.005f;
    public GameObject Squid;
    public GameObject Kohada;
    public GameObject Ebi;
    public GameObject Tuna;
    public GameObject Salmon;
    public GameObject Rice;
    private void Update()
    {
        if (isGrabbingL == false)
        {
            TryGrabL();
        }
        else
        {
            TryUngrabL();
        }
    }
    private void TryUngrabL()
    {
        if (ARAVRInput.GetUp(ARAVRInput.Button.HandTrigger, ARAVRInput.Controller.LTouch))
        {
            isGrabbingL = false;
            grabbedObjectL.GetComponent<Rigidbody>().isKinematic = false;
            grabbedObjectL.transform.parent = null;
            grabbedObjectL = null;
        }
    }

    private void TryGrabL()
    {
        if (ARAVRInput.GetDown(ARAVRInput.Button.HandTrigger, ARAVRInput.Controller.RTouch))
        {
            int closest = 0;
            Collider[] hitObjects = Physics.OverlapSphere(ARAVRInput.LHandPosition, grabRange, grabbedLayer);
            for (int i = 1; i < hitObjects.Length; i++)
            {
                Vector3 closestPos = hitObjects[closest].transform.position;
                float closestDistance = Vector3.Distance(closestPos, ARAVRInput.LHandPosition);
                Vector3 nextPos = hitObjects[i].transform.position;
                float nextDistance = Vector3.Distance(nextPos, ARAVRInput.LHandPosition);
                if (nextDistance < closestDistance)
                {
                    closest = i;
                }

            }
            if (hitObjects.Length > 0)
            {
                isGrabbingL = true;
                Vector3 spotPos = ARAVRInput.LHandPosition;
                if (hitObjects[closest].gameObject.name == "Ebi_button")
                {
                    grabbedObjectL = Instantiate(Ebi, spotPos, Ebi.transform.rotation);
                }
                else if (hitObjects[closest].gameObject.name == "Salmon_button")
                {
                    grabbedObjectL = Instantiate(Salmon, spotPos, Salmon.transform.rotation);
                }
                else if (hitObjects[closest].gameObject.name == "Tuna_button")
                {
                    grabbedObjectL = Instantiate(Tuna, spotPos, Tuna.transform.rotation);
                }
                else if (hitObjects[closest].gameObject.name == "Squid_button")
                {
                    grabbedObjectL = Instantiate(Squid, spotPos, Squid.transform.rotation);
                }
                else if (hitObjects[closest].gameObject.name == "Kohada_button")
                {
                    grabbedObjectL = Instantiate(Kohada, spotPos, Kohada.transform.rotation);
                }
                else if (hitObjects[closest].gameObject.name == "Rice_button")
                {
                    grabbedObjectL = Instantiate(Rice, spotPos, Rice.transform.rotation);
                }

                //grabbedObject = hitObjects[closest].gameObject;
                grabbedObjectL.GetComponent<Rigidbody>().isKinematic = true;
                grabbedObjectL.transform.parent = ARAVRInput.LHand;
            }
        }
    }

}
