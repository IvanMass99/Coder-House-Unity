using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{

    // variables

    public int hp = 10; // variable para la vida
    public float speed = 0.1f; // variable para la velocidad
    public Vector3 dir; // variable para la dirección

    // metodos

    void healthPlayer() { hp += 2; }

    void damagePlayer() { hp -= 1; }

    void movePlayer()   { transform.Translate((speed*dir) * Time.deltaTime);}

  
    void Start()
    {
        healthPlayer();
        // damagePlayer();
    }

   
    void Update()
    {
        Debug.Log("vida: " + hp);
        Debug.Log("velocidad: " + speed);
        Debug.Log("dirección: " + dir);

        movePlayer();
         
    }
}
