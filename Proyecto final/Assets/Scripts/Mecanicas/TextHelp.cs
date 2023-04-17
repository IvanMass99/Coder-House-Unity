using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextHelp : MonoBehaviour
{
    public GameObject objetoDeTexto; // Objeto vacío con el componente "Text Mesh Pro"
    public float distanciaMostrarTexto = 2f; // Distancia a la que se muestra el texto

    void Update()
    {
        if (Vector3.Distance(transform.position, Camera.main.transform.position) <= distanciaMostrarTexto)
        {
            objetoDeTexto.SetActive(true);
        }
        else
        {
            objetoDeTexto.SetActive(false);
        }
    }
}
