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
    public float grabRange = 0.1f;
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
        if (ARAVRInput.GetUp(ARAVRInput.Button.HandTrigger, ARAVRInput.Controller.RTouch))
        {
            isGrabbingR = false;
            //grabbedObjectR.GetComponent<Rigidbody>().isKinematic = false;
            //grabbedObjectR.transform.parent = null;
            grabbedObjectR = null;
        }
    }

    private void TryUngrabL()
    {
        if (ARAVRInput.GetUp(ARAVRInput.Button.HandTrigger, ARAVRInput.Controller.LTouch))
        {
            isGrabbingL = false;
            //grabbedObjectR.GetComponent<Rigidbody>().isKinematic = false;
            //grabbedObjectR.transform.parent = null;
            grabbedObjectL = null;
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
                Vector3 spotPos = new Vector3((float)-2.651, (float)1.991, gameflow.plateZpos - (float)0.07);
                Vector3 spotPosR = new Vector3((float)-2.651, (float)1.991, gameflow.plateZpos + (float)0.07);
                if (hitObjects[closest].gameObject.name == "Ebi_button")
                {
                    grabbedObjectR = Instantiate(Ebi, new Vector3((float)-2.651, (float)1.991, gameflow.plateZpos), Ebi.transform.rotation);
                }
                else if (hitObjects[closest].gameObject.name == "Salmon_button")
                {
                    grabbedObjectR = Instantiate(Salmon, new Vector3((float)-2.651, (float)1.991, gameflow.plateZpos), Salmon.transform.rotation);
                }
                else if (hitObjects[closest].gameObject.name == "Tuna_button")
                {
                    grabbedObjectR = Instantiate(Tuna, new Vector3((float)-2.651, (float)1.991, gameflow.plateZpos), Tuna.transform.rotation);
                }
                else if (hitObjects[closest].gameObject.name == "Squid_button")
                {
                    grabbedObjectR = Instantiate(Squid, new Vector3((float)-2.651, (float)1.991, gameflow.plateZpos), Squid.transform.rotation);
                }
                else if (hitObjects[closest].gameObject.name == "Kohada_button")
                {
                    grabbedObjectR = Instantiate(Kohada, new Vector3((float)-2.651, (float)1.991, gameflow.plateZpos), Kohada.transform.rotation);
                }
                else if (hitObjects[closest].gameObject.name == "Rice_button")
                {
                    grabbedObjectR = Instantiate(Rice, new Vector3((float)-2.7, (float)1.991, gameflow.plateZpos), Rice.transform.rotation);
                }
                //grabbedObject = hitObjects[closest].gameObject;
                //grabbedObjectR.GetComponent<Rigidbody>().isKinematic = true;
                //grabbedObjectR.transform.parent = ARAVRInput.RHand;
            }
        }
    }

    private void TryGrabL()
    {
        if (ARAVRInput.GetDown(ARAVRInput.Button.HandTrigger, ARAVRInput.Controller.LTouch))
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
                Vector3 spotPos = new Vector3((float)-2.651, (float)1.991, gameflow.plateZpos - (float)0.07);
                Vector3 spotPosR = new Vector3((float)-2.651, (float)1.991, gameflow.plateZpos + (float)0.07);
                if (hitObjects[closest].gameObject.name == "Ebi_button")
                {
                    grabbedObjectL = Instantiate(Ebi, new Vector3((float)-2.651, (float)1.991, gameflow.plateZpos), Ebi.transform.rotation);
                }
                else if (hitObjects[closest].gameObject.name == "Salmon_button")
                {
                    grabbedObjectL = Instantiate(Salmon, new Vector3((float)-2.651, (float)1.991, gameflow.plateZpos), Salmon.transform.rotation);
                }
                else if (hitObjects[closest].gameObject.name == "Tuna_button")
                {
                    grabbedObjectL = Instantiate(Tuna, new Vector3((float)-2.651, (float)1.991, gameflow.plateZpos), Tuna.transform.rotation);
                }
                else if (hitObjects[closest].gameObject.name == "Squid_button")
                {
                    grabbedObjectL = Instantiate(Squid, new Vector3((float)-2.651, (float)1.991, gameflow.plateZpos), Squid.transform.rotation);
                }
                else if (hitObjects[closest].gameObject.name == "Kohada_button")
                {
                    grabbedObjectL = Instantiate(Kohada, new Vector3((float)-2.651, (float)1.991, gameflow.plateZpos), Kohada.transform.rotation);
                }
                else if (hitObjects[closest].gameObject.name == "Rice_button")
                {
                    grabbedObjectL = Instantiate(Rice, new Vector3((float)-2.7, (float)1.991, gameflow.plateZpos), Rice.transform.rotation);
                }
                //grabbedObject = hitObjects[closest].gameObject;
                //grabbedObjectR.GetComponent<Rigidbody>().isKinematic = true;
                //grabbedObjectR.transform.parent = ARAVRInput.RHand;
            }
        }
    }


}