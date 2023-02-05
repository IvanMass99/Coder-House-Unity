using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{

    public Vector3 escala;
    public Vector3 dir;
    public float vel = 0.1f;

    // public Vector3 rotar;

  
    void Start()
    {
            
         transform.localScale = escala;
    }

   
    void Update()
    {

       
        transform.Translate(dir*vel);
        // transform.Rotate(rotar);

    }
}
