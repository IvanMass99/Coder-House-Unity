using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_rotate_item : MonoBehaviour

{

    
    public Vector3 miVector = new Vector3(200f, 0f, 0f);

    void Update()
    {
        transform.Rotate(miVector * Time.deltaTime);
    }
}
