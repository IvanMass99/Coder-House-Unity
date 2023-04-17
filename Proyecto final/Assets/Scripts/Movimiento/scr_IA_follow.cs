using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class scr_IA_follow : MonoBehaviour

{

// Variables

 public float speed = 1f;
 public float distance;
 public GameObject Jugador;
 public GameObject Enemigo;


// Metodos 

    // Calcular distancia entre el jugador

    private void DistanceEvalue(){
        distance = Vector3.Distance(Enemigo.transform.position,Jugador.transform.position);
        if (distance <= 0.5 || distance >= 5) {speed = 0f;}
        else {speed = 1f;}
    }

    // Mirar al jugador

    private void LookAtPlayer(){Enemigo.transform.LookAt(Jugador.transform.position);}

    // Seguir al jugador 

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