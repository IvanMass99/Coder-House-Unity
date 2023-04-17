using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JugadorMovimiento : MonoBehaviour
{

    // Muerte

    public bool live = true;
    public AudioSource audioDeath; 

    // Falling

    public float dañoPorCaída = 10f;
    public float velocidadMinimaParaDaño = 10f;

   // Varialbes

    public float velocidad = 3f;
    public float velocidadEscalera = 5f;
    public float rotacion = 200f;

    public GameObject ZombieObject;

    public bool moverse = true;

    // public bool moverse = true;

    private Rigidbody rb;

    // Animación

    public Animator animator;

    public bool isRunning;
	public bool isDead = false;


    // Metodos

    public void MovimientoBasico() 

    {

       if (moverse == true) 
       
       {

        if(Input.GetKey(KeyCode.W)) {transform.Translate(Vector3.forward * velocidad * Time.deltaTime);animator.SetBool("isRunning", true);}  
        if(Input.GetKey(KeyCode.S)) {transform.Translate(-Vector3.forward * velocidad * Time.deltaTime);animator.SetBool("isRunning", true);}  
        if(Input.GetKey(KeyCode.A)) {transform.Rotate(Vector3.up, -rotacion * Time.deltaTime);}
        if(Input.GetKey(KeyCode.D)) {transform.Rotate(Vector3.up, rotacion * Time.deltaTime);}

        if (Input.GetKeyUp(KeyCode.W)) {animator.SetBool("isRunning", false);}
        if (Input.GetKeyUp(KeyCode.S)) {animator.SetBool("isRunning", false);}

       }

  
    }

    // Animación de perder

      	
	void OnTriggerEnter(Collider other)

		{
            
            ZombieMovement ZombieMovement = ZombieObject.GetComponent<ZombieMovement>();

			if (other.gameObject.name == "Zombie" && ZombieMovement.isAlive == true)

				{                      
                    GetComponent<Rigidbody>().isKinematic = true;
                    live = false;
                    rb.useGravity = false;					
        
				}

			}


        
    
    // Subir escalera

   void OnTriggerStay(Collider other)

        {

        
        // Colisionar con la esacalera

        if (other.gameObject.name == "Escalera" & Input.GetKey(KeyCode.E))

            {


                rb.useGravity = false;
             
                transform.Translate(Vector3.up * Time.deltaTime * velocidadEscalera);

                // Debug.Log("Colision correcta");  
            }

        }


        // Falling

        private void OnCollisionEnter(Collision other) 
        
        {
            if (other.gameObject.name == "Cube") 
                {
                float velocidadDeCaída = Mathf.Abs(other.relativeVelocity.y);
                if (velocidadDeCaída > velocidadMinimaParaDaño) 
                    {
                        float daño = dañoPorCaída * (velocidadDeCaída - velocidadMinimaParaDaño);
                        // Aplica el daño al objeto
                        audioDeath.Play();
                        live = false;
                    }
                }



        }


 


      void OnTriggerExit(Collider other)

        {
            if (other.gameObject.name == "Escalera")
            {
                 rb.useGravity = true; // reactiva la gravedad
            }
        }


    void Start()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
        audioDeath = GetComponent<AudioSource>();        
    }

    // Update is called once per frame
    void Update()
    { 
          
        MovimientoBasico();

        if (live == false) {

             
                animator.SetBool("isDead", true);
                moverse = false;

        }
        
    }

    
}
