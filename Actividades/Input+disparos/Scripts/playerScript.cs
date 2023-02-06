using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerScript : MonoBehaviour
{

    public GameObject bulletObject;
    public Transform canon;

    private void Disparo()
        
        {
            // Crear bala al presionar una tecla
            
            if (Input.GetKeyDown(KeyCode.Space)) {Instantiate(bulletObject, canon.position, transform.rotation);}
        }

    void Start()
    {


        
    }

    // Update is called once per frame
    void Update()
    {
         Disparo();
      
    }
}
