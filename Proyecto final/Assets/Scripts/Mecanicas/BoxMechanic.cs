using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BoxMechanic : MonoBehaviour
{


    public float stayBox = 1.7f;
    public float pickupDistance = 1.5f;
    private GameObject heldObject = null;
    public GameObject DropText;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && heldObject == null)
        {
            // Check for nearby boxes
            Collider[] colliders = Physics.OverlapSphere(transform.position, pickupDistance);
            foreach (Collider collider in colliders)
            {
                if (collider.tag == "Box")
                {
                    // Pick up the box
                    DropText.SetActive(true);
                    heldObject = collider.gameObject;
                    heldObject.GetComponent<Rigidbody>().isKinematic = true;
                    heldObject.transform.position = transform.position + new Vector3(0,stayBox,0);
                    heldObject.transform.parent = transform;
                    break;
                }
            }
        }

        if (Input.GetKeyDown(KeyCode.Space) && heldObject != null)
        {
    
            DropText.SetActive(false);
            heldObject.transform.parent = null;
            heldObject.GetComponent<Rigidbody>().isKinematic = false;
            heldObject.GetComponent<Rigidbody>().AddForce(transform.forward * 500f);
            heldObject = null;
        }
    }


}
