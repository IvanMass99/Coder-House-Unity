using System;
using System.Collections;
using System.Linq;
using UnityEngine;

public class LadderText : MonoBehaviour {

 public GameObject ladderText; 

       private void OnCollisionEnter(Collision collision)
    {
        // Si el objeto colisiona con el jugador, activar el objeto TextMeshPro
        if (collision.gameObject.CompareTag("Player"))
        {
            ladderText.SetActive(true);
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        // Si el objeto deja de colisionar con el jugador, desactivar el objeto TextMeshPro
        if (collision.gameObject.CompareTag("Player"))
        {
            ladderText.SetActive(false);
        }
    }
}