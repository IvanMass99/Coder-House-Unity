using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerScript : MonoBehaviour
{

    public GameObject bulletObject;
    public Transform canon;

    void disparo()
        {
            Instantiate(bulletObject, canon.position, transform.rotation);
        }

    void Start()
    {

        disparo();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
