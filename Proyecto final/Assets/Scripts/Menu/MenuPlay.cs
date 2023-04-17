using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;


public class MenuPlay : MonoBehaviour
{
    public void IrASiguienteEscena()
    {
        StartCoroutine(CargarEscena());
    }

    IEnumerator CargarEscena()
    {
        // Cargar la nueva escena en segundo plano
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex + 1);

        // Mientras la nueva escena se carga, mantener la escena actual activa
        asyncLoad.allowSceneActivation = false;

        // Esperar hasta que la carga de la nueva escena alcance el 90%
        while (!asyncLoad.isDone && asyncLoad.progress < 0.9f)
        {
            yield return null;
        }

        // Permitir que la nueva escena se active
        asyncLoad.allowSceneActivation = true;
    }
}
