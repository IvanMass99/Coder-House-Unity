using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletScript : MonoBehaviour
{

    public Vector3 bulletDirection;
    public float bulletSpeed = 1;
    public int bulletDamage = 5;

    void Start()
    {


        
    }

   
    void Update()
    {

        transform.Translate(bulletDirection * bulletSpeed * Time.deltaTime);
        
    }
}
