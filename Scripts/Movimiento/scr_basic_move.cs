using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_basic_move : MonoBehaviour
{

    // Variables

    public float velocidad = 0.3f;

    void Start()
    {
        
    }

    void Update()
    {

        if(Input.GetKey(KeyCode.W))
            transform.Translate(0,0,+velocidad * Time.deltaTime);
        
        if(Input.GetKey(KeyCode.S))
           transform.Translate(0,0,-velocidad * Time.deltaTime);
        
        if(Input.GetKey(KeyCode.A))
            transform.Translate(-velocidad * Time.deltaTime,0,0);
        
        if(Input.GetKey(KeyCode.D))
            transform.Translate(+velocidad * Time.deltaTime ,0,0);
        
    }
    
}
