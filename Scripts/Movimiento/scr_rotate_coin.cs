using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_rotate_coin : MonoBehaviour
{

    public float speed = 1f;

   
    void Update()
    
    {
        transform.Rotate(+speed,0,0);
    }


}
