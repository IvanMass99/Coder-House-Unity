using UnityEngine;
public class ZombieMovement : MonoBehaviour

{
    
    public AudioSource audioSource;

    public AudioClip ZombieSound;
    public AudioClip BoxSound;

    //Seguir al jugador 

    private Rigidbody rb;

    public Transform target; // El objetivo que el enemigo seguirá, en este caso, el jugador.
    public float speed = 5f; // La velocidad a la que se moverá el enemigo.
    public float visionRange = 10f; // El rango de visión del enemigo.
    public float viewAngle = 60f; // El ángulo de visión del enemigo.

    // Morir al colision con objeto

    public int damageTaken = 100;
    public bool isAlive = true;

    // Animación 

    public Animator animator;
    public bool caminar = false;
    public bool morir = false;
    public bool atacar = false;


      void Start()
    {
        animator = GetComponent<Animator>();
        Rigidbody rb = GetComponent<Rigidbody>();

        audioSource = GetComponent<AudioSource>();

    }


    // Perseguir al player

    void Update()
    {
        // Calcula la dirección hacia el objetivo.
        Vector3 direction = target.position - transform.position;
        direction.y = 0f;

        // Si el enemigo puede ver al objetivo, mueve al enemigo hacia él y apunta hacia el jugador.
        RaycastHit hit;

       

        if (Physics.Raycast(transform.position, direction, out hit, visionRange) && hit.collider.tag == "Player")
        {   
            
            // Comprueba si el jugador está dentro del ángulo de visión del enemigo.
            float angle = Vector3.Angle(direction, transform.forward);


            if (angle < viewAngle * 0.5f && isAlive == true)
            {
             
    
                animator.SetBool("caminar", true);
                transform.position += direction.normalized * speed * Time.deltaTime;
                transform.LookAt(target);
            
            }
        } else 

          animator.SetBool("caminar", false);      
    }

    // Dibuja el rango de visión del enemigo en el editor.
    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, visionRange);
        Gizmos.color = Color.red;
        Gizmos.DrawLine(transform.position, transform.position + Quaternion.Euler(0f, viewAngle * 0.5f, 0f) * transform.forward * visionRange);
        Gizmos.DrawLine(transform.position, transform.position + Quaternion.Euler(0f, -viewAngle * 0.5f, 0f) * transform.forward * visionRange);
    }


    // Colision

       void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.CompareTag("Box") && isAlive == true)
            {

                audioSource.clip = BoxSound;
                audioSource.Play();

                animator.SetBool("caminar", false);   
                animator.SetBool("morir", true);
              
                isAlive = false;
                Rigidbody rb = GetComponent<Rigidbody>();
                rb.isKinematic = false; // Desactiva el Rigidbody para que el objeto caiga al suelo
                Destroy(gameObject, 1.5f); // Destruye el objeto del enemigo después de 2 segundos
                Destroy(collision.gameObject); // Destruye el objeto de la caja después de 2 segundos


            }
        }

    void OnTriggerEnter(Collider other)

        {

        if (other.gameObject.CompareTag("Player"))

            {
                    audioSource.clip = ZombieSound;
                    audioSource.Play();
                    animator.SetBool("atacar", true);    
         
            }

        }
}
