using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grab : MonoBehaviour
{
    // Start is called before the first frame update
    bool isGrabbingR = false;
    GameObject grabbedObjectR;
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
        if (isGrabbingR == false)
        {
            TryGrabR();
        }
        else
        {
            TryUngrabR();
        }
    }
    private void TryUngrabR()
    {
        if (ARAVRInput.GetUp(ARAVRInput.Button.HandTrigger, ARAVRInput.Controller.RTouch))
        {
            isGrabbingR = false;
            grabbedObjectR.GetComponent<Rigidbody>().isKinematic = false;
            grabbedObjectR.transform.parent = null;
            grabbedObjectR = null;
        }
    }

    private void TryGrabR()
    {
        if (ARAVRInput.GetDown(ARAVRInput.Button.HandTrigger, ARAVRInput.Controller.RTouch))
        {
            int closest = 0;
            Collider[] hitObjects = Physics.OverlapSphere(ARAVRInput.RHandPosition, grabRange, grabbedLayer);
            for (int i = 1; i < hitObjects.Length; i++)
            {
                Vector3 closestPos = hitObjects[closest].transform.position;
                float closestDistance = Vector3.Distance(closestPos, ARAVRInput.RHandPosition);
                Vector3 nextPos = hitObjects[i].transform.position;
                float nextDistance = Vector3.Distance(nextPos, ARAVRInput.RHandPosition);
                if (nextDistance < closestDistance)
                {
                    closest = i;
                }

            }
            if (hitObjects.Length > 0)
            {
                isGrabbingR = true;
                Vector3 spotPos = ARAVRInput.RHandPosition;
                if (hitObjects[closest].gameObject.name == "Ebi_button")
                {
                    grabbedObjectR = Instantiate(Ebi, spotPos, Ebi.transform.rotation);
                }
                else if (hitObjects[closest].gameObject.name == "Salmon_button")
                {
                    grabbedObjectR = Instantiate(Salmon, spotPos, Salmon.transform.rotation);
                }
                else if (hitObjects[closest].gameObject.name == "Tuna_button")
                {
                    grabbedObjectR = Instantiate(Tuna, spotPos, Tuna.transform.rotation);
                }
                else if (hitObjects[closest].gameObject.name == "Squid_button")
                {
                    grabbedObjectR = Instantiate(Squid, spotPos, Squid.transform.rotation);
                }
                else if (hitObjects[closest].gameObject.name == "Kohada_button")
                {
                    grabbedObjectR = Instantiate(Kohada, spotPos, Kohada.transform.rotation);
                }
                else if (hitObjects[closest].gameObject.name == "Rice_button")
                {
                    grabbedObjectR = Instantiate(Rice, spotPos, Rice.transform.rotation);
                }
                //grabbedObject = hitObjects[closest].gameObject;
                grabbedObjectR.GetComponent<Rigidbody>().isKinematic = true;
                grabbedObjectR.transform.parent = ARAVRInput.RHand;
            }
        }
    }

}
