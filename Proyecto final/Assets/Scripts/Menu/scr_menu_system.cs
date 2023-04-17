using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scr_menu_system : MonoBehaviour
{

    // JUGAR

    public void Jugar() { SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);}
    
    // CONTROLES

    public void Controles() 
    
        {

        }
    
    // SALIR

    public void Salir() { Debug.Log("Salir del juego"); Application.Quit();}
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
 
    }
}
