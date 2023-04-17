using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ganarNivel : MonoBehaviour 
{
    public GameObject Jugador;
	public GameObject Camara1;
	public GameObject Camara2;

    public GameObject CoinText;
	public GameObject WinText;
    public GameObject MissionText;

    public GameObject CoinImage;

    Animator animator;

    public string sceneName;

    void Start()
    {
        // Inicializa el componente Animator
        animator = Jugador.GetComponent<Animator>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "winObject")
        {  
		
            Jugador.GetComponent<JugadorMovimiento>().moverse = false;
           
            animator.SetBool("isRunning", false);
            Destroy(other.gameObject);
            // Debug.Log("ganaste"); 

            // Desactiva la función del objeto "Camara"
            Camara1.SetActive(false);
			Camara2.SetActive(true);

			// Texto

            CoinText.SetActive(false);
			MissionText.SetActive(false);
            WinText.SetActive(true);
            

            // Imagenes

            CoinImage.SetActive(false);

            // Cambiar de escena

            Invoke("LoadScene", 7f);
        }
        
    }

    private void LoadScene()
    {
        SceneManager.LoadScene(sceneName);
    }
}