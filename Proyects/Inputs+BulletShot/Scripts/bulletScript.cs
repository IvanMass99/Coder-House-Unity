using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletScript : MonoBehaviour
{

    public Vector3 bulletDirection;
    public float bulletSpeed = 3;
    public int bulletDamage = 5;

    void Start()
    {


        
    }

   
    void Update()
    {
        // Movimiento y direccion de la bala al crearse
        transform.Translate(bulletDirection * bulletSpeed * Time.deltaTime);
        Destroy(gameObject, 2f);
    }
}
