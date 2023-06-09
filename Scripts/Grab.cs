using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grab : MonoBehaviour
{
    // Start is called before the first frame update
    bool isGrabbingR = false;
    bool isGrabbingL = false;
    GameObject grabbedObjectR;
    GameObject grabbedObjectL;
    public LayerMask grabbedLayer;
    public float grabRange = 0.3f;
    public GameObject Squid;
    public GameObject Kohada;
    public GameObject Ebi;
    public GameObject Tuna;
    public GameObject Salmon;
    public GameObject Rice;
    public float throwPower = 10;
    Vector3 prevPosR;
    Quaternion prevRotR;
    Vector3 prevPosL;
    Quaternion prevRotL;
    private void Update()
    {
        if(isGrabbingR == false)
        {
            TryGrabR();
        }
        else
        {
            TryUngrabR();
        }
        if (isGrabbingL == false)
        {
            TryGrabL();
        }
        else
        {
            TryUngrabL();
        }
    }
    private void TryUngrabR()
    {
        Vector3 throwDirection = (ARAVRInput.RHandPosition - prevPosR);
        prevPosR = ARAVRInput.RHandPosition;
        Quaternion deltaRotation = ARAVRInput.RHand.rotation * Quaternion.Inverse(prevRotR);
        prevRotR = ARAVRInput.RHand.rotation;
        if (ARAVRInput.GetUp(ARAVRInput.Button.HandTrigger, ARAVRInput.Controller.RTouch))
        {
            isGrabbingR = false;
            grabbedObjectR.GetComponent<Rigidbody>().isKinematic = false;
            grabbedObjectR.transform.parent = null;
            grabbedObjectR.GetComponent<Rigidbody>().velocity = throwDirection * throwPower;
            float angle;
            Vector3 axis;
            deltaRotation.ToAngleAxis(out angle, out axis);
            Vector3 angularVelocity = (1.0f / Time.deltaTime) * angle * axis;
            grabbedObjectR.GetComponent<Rigidbody>().angularVelocity = angularVelocity;
            grabbedObjectR = null;
        }
    }

    private void TryUngrabL()
    {
        Vector3 throwDirection = (ARAVRInput.LHandPosition - prevPosL);
        prevPosL = ARAVRInput.LHandPosition;
        Quaternion deltaRotation = ARAVRInput.LHand.rotation * Quaternion.Inverse(prevRotL);
        prevRotL = ARAVRInput.LHand.rotation;
        if (ARAVRInput.GetUp(ARAVRInput.Button.HandTrigger, ARAVRInput.Controller.LTouch))
        {
            isGrabbingL = false;
            grabbedObjectL.GetComponent<Rigidbody>().isKinematic = false;
            grabbedObjectL.transform.parent = null;
            grabbedObjectL.GetComponent<Rigidbody>().velocity = throwDirection * throwPower;
            float angle;
            Vector3 axis;
            deltaRotation.ToAngleAxis(out angle, out axis);
            Vector3 angularVelocity = (1.0f / Time.deltaTime) * angle * axis;
            grabbedObjectL.GetComponent<Rigidbody>().angularVelocity = angularVelocity;
            grabbedObjectL = null;
        }
    }

    private void TryGrabR()
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
                    isGrabbingR = true;
                    if(hitObjects[closest].gameObject.name== "Ebi_sashimi(Clone)")
                    {
                        Vector3 spotPos = hitObjects[closest].gameObject.transform.position;
                        Instantiate(Ebi, spotPos, Ebi.transform.rotation);
                        grabbedObjectR = Ebi;
                    }
                    else if (hitObjects[closest].gameObject.name == "Salmon_sashimi(Clone)")
                    {
                        Vector3 spotPos = hitObjects[closest].gameObject.transform.position;
                        Instantiate(Salmon, spotPos, Salmon.transform.rotation);
                        grabbedObjectR = Salmon;
                    }
                    else if (hitObjects[closest].gameObject.name == "Tuna_sashimi(Clone)")
                    {
                        Vector3 spotPos = hitObjects[closest].gameObject.transform.position;
                        Instantiate(Tuna, spotPos, Tuna.transform.rotation);
                        grabbedObjectR = Tuna;
                    }
                    else if (hitObjects[closest].gameObject.name == "Squid_sashimi(Clone)")
                    {
                        Vector3 spotPos = hitObjects[closest].gameObject.transform.position;
                        Instantiate(Squid, spotPos, Squid.transform.rotation);
                        grabbedObjectR = Squid;
                    }
                    else if (hitObjects[closest].gameObject.name == "Kohada_sashimi(Clone)")
                    {
                        Vector3 spotPos = hitObjects[closest].gameObject.transform.position;
                        Instantiate(Kohada, spotPos, Kohada.transform.rotation);
                        grabbedObjectR = Kohada;
                    }
                    else if (hitObjects[closest].gameObject.name == "Sashimi_rice(Clone)")
                    {
                        Vector3 spotPos = hitObjects[closest].gameObject.transform.position;
                        Instantiate(Rice, spotPos, Rice.transform.rotation);
                        grabbedObjectR = Rice;
                    }
                    //grabbedObject = hitObjects[closest].gameObject;
                    grabbedObjectR.transform.parent = ARAVRInput.RHand;
                    grabbedObjectR.GetComponent<Rigidbody>().isKinematic = true;
                    prevPosR = ARAVRInput.RHandPosition;
                    prevRotR = ARAVRInput.RHand.rotation;
                }
            }
        }
    }

    private void TryGrabL()
    {
        if (ARAVRInput.GetDown(ARAVRInput.Button.HandTrigger, ARAVRInput.Controller.LTouch))
        {
            int closest = 0;
            Collider[] hitObjects = Physics.OverlapSphere(ARAVRInput.RHandPosition, grabRange, grabbedLayer);
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
                if (hitObjects.Length > 0)
                {
                    isGrabbingR = true;
                    if (hitObjects[closest].gameObject.name == "Ebi_sashimi(Clone)")
                    {
                        Vector3 spotPos = hitObjects[closest].gameObject.transform.position;
                        Instantiate(Ebi, spotPos, Ebi.transform.rotation);
                        grabbedObjectL = Ebi;
                    }
                    else if (hitObjects[closest].gameObject.name == "Salmon_sashimi(Clone)")
                    {
                        Vector3 spotPos = hitObjects[closest].gameObject.transform.position;
                        Instantiate(Salmon, spotPos, Salmon.transform.rotation);
                        grabbedObjectL = Salmon;
                    }
                    else if (hitObjects[closest].gameObject.name == "Tuna_sashimi(Clone)")
                    {
                        Vector3 spotPos = hitObjects[closest].gameObject.transform.position;
                        Instantiate(Tuna, spotPos, Tuna.transform.rotation);
                        grabbedObjectL = Tuna;
                    }
                    else if (hitObjects[closest].gameObject.name == "Squid_sashimi(Clone)")
                    {
                        Vector3 spotPos = hitObjects[closest].gameObject.transform.position;
                        Instantiate(Squid, spotPos, Squid.transform.rotation);
                        grabbedObjectL = Squid;
                    }
                    else if (hitObjects[closest].gameObject.name == "Kohada_sashimi(Clone)")
                    {
                        Vector3 spotPos = hitObjects[closest].gameObject.transform.position;
                        Instantiate(Kohada, spotPos, Kohada.transform.rotation);
                        grabbedObjectL = Kohada;
                    }
                    else if (hitObjects[closest].gameObject.name == "Sashimi_rice(Clone)")
                    {
                        Vector3 spotPos = hitObjects[closest].gameObject.transform.position;
                        Instantiate(Rice, spotPos, Rice.transform.rotation);
                        grabbedObjectL = Rice;
                    }
                    //grabbedObject = hitObjects[closest].gameObject;
                    grabbedObjectL.transform.parent = ARAVRInput.LHand;
                    grabbedObjectL.GetComponent<Rigidbody>().isKinematic = true;
                    prevPosL = ARAVRInput.LHandPosition;
                    prevRotL = ARAVRInput.LHand.rotation;
                }
            }
        }
    }
}

