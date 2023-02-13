using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class RotationEnemy : MonoBehaviour

{

// Variables

 public GameObject Jugador;
 public GameObject Enemigo;


// Metodos 

    private void LookAtPlayer(){Enemigo.transform.LookAt(Jugador.transform.position);}

    void Start()
    {
        
    }


    void Update()
    {
        
        LookAtPlayer();
            
    }
}
