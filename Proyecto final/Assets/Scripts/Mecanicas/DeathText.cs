using System;
using System.Collections;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathText : MonoBehaviour 
{
    public GameObject jugador;
    public GameObject Camara1;
    public GameObject Camara2;
    public GameObject CoinText;
    public GameObject CoinImage;
    public GameObject MissionText;
    public GameObject LoseText;

    void Update() 
    {
        // Obtener el componente del objeto
        JugadorMovimiento jugadorMovimiento = jugador.GetComponent<JugadorMovimiento>();

        if (jugadorMovimiento.live == false) 
        {	
            // Desactiva la función del objeto "Camara"
            Camara1.SetActive(false);
            Camara2.SetActive(true);

            // Texto
            CoinText.SetActive(false);
            MissionText.SetActive(false);
            LoseText.SetActive(true);

            // Imagenes
            CoinImage.SetActive(false);

            // Carga la escena anterior después de 5 segundos
            StartCoroutine(LoadPreviousScene(5f));

            // Debug.Log("Funcion muerte");
        }
    }

   IEnumerator LoadPreviousScene(float delay)
    {
        yield return new WaitForSeconds(delay);

        // Carga la escena anterior
        Scene currentScene = SceneManager.GetActiveScene();
        int previousSceneIndex = currentScene.buildIndex - 1;
        if (previousSceneIndex < 0)
        {
            previousSceneIndex = SceneManager.sceneCountInBuildSettings - 1;
        }

        SceneManager.LoadScene(previousSceneIndex);
    }
}
