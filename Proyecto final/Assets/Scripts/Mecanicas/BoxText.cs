using System;
using System.Collections;
using System.Linq;
using UnityEngine;
using TMPro;

public class BoxText : MonoBehaviour {

   public AudioSource TutorialSound; 
   public GameObject PickUpText; 

    void Start()
    {
        TutorialSound = GetComponent<AudioSource>();
        TutorialSound.enabled = true; // habilitar el AudioSource

    }

       private void OnCollisionEnter(Collision collision)
    {
        // Si el objeto colisiona con el jugador, activar el objeto TextMeshPro
        if (collision.gameObject.CompareTag("Player"))
        {
            PickUpText.SetActive(true);
             TutorialSound.Play();
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        // Si el objeto deja de colisionar con el jugador, desactivar el objeto TextMeshPro
        if (collision.gameObject.CompareTag("Player"))
        {
            PickUpText.SetActive(false);
        }
    }


}