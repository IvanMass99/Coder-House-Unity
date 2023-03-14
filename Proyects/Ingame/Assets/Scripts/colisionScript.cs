using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colisionScript : MonoBehaviour
{


    // Variables

    public bool resetColision = true;
    public float timeStay = 0.0f;
    public GameObject Pared;


    // Metodos

    private void OnCollisionEnter(Collision collision) {

        if (collision.gameObject.name == "Umbral") 
        
        {
            
            if (resetColision == false) {transform.localScale = new Vector3(0.2f, 0.2f, 0.2f);}
            if (resetColision == true) {transform.localScale = new Vector3(1, 1, 1);}
            
            Debug.Log("Colisión correcta"); 
            
        }
        
    }


    /*
    private void OnCollisionStay(Collision collision) {

           if (collision.gameObject.name == "Pared")  {timeStay += Time.deltaTime;}
           if (timeStay >= 2.0f) 
           {
                Pared.transform.position = new Vector3(Random.Range(-5,5),3,Random.Range(-5,5));
                Pared.transform.rotation = Quaternion.Euler(new Vector3(0,Random.Range(-50,50),0));
                timeStay = 1.0f;   
            };
        
    }
    */
    private void OnTriggerStay(Collider collision) {

           if (collision.gameObject.name == "Pared")  {timeStay += Time.deltaTime;}
           if (timeStay >= 2.0f) 
           {
                Pared.transform.position = new Vector3(Random.Range(-5,5),3,Random.Range(-5,5));
                Pared.transform.rotation = Quaternion.Euler(new Vector3(0,Random.Range(-50,50),0));
                timeStay = 0.0f;   
            };
        
        
    }

    private void OnCollisionExit(Collision collision) {
       if (transform.localScale == new Vector3(0.2f, 0.2f, 0.2f)) {resetColision = true;}
       if (transform.localScale == new Vector3(1,1,1)) {resetColision = false;}
    }

    private void update() {

    

    }


}
