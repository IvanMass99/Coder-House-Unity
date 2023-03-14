using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_rotate_coin : MonoBehaviour
{

    public float velocidad = 1f;

   
    void Update()
    
    {
        transform.Rotate(+velocidad,0,0);
    }


}
