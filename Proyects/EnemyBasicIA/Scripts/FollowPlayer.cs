using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class FollowPlayer : MonoBehaviour

{

// Variables

 public float speed = 1f;
 public float distance;
 public GameObject Jugador;
 public GameObject Enemigo;


// Metodos 

    private void DistanceEvalue(){
        distance = Vector3.Distance(Enemigo.transform.position,Jugador.transform.position);
        if (distance <= 2) {speed = 0f;}
        else {speed = 1f;}
    }
    private void LookAtPlayer(){Enemigo.transform.LookAt(Jugador.transform.position);}
    private void FollowAtPlayer(){Enemigo.transform.position = Vector3.MoveTowards(Enemigo.transform.position, Jugador.transform.position,speed * Time.deltaTime);}


    void Start()
    {
        
    }


    void Update()
    {
        
        LookAtPlayer();
        DistanceEvalue();
        FollowAtPlayer();
            
    }
}
