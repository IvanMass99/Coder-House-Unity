using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeCoin : GameManager
{  
    public AudioSource CoinSound; 

    void Start()
    {
        CoinSound = GetComponent<AudioSource>();
        CoinSound.enabled = true; // habilitar el AudioSource

    }

    private void OnTriggerEnter(Collider other)
    {
         if (other.gameObject.name == "Jugador")
        {
            CoinSound.Play();
            Destroy(gameObject,0.2f);
            GameManager.coins++;
            Debug.Log(coins); 
          
        }
    }
}
