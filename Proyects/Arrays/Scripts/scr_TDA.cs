using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_TDA : MonoBehaviour
{

    public Transform pos;
    public int playerSelector = 2;
    public GameObject[] objectsToInstantiate;

    void PlayerSelector()
    
            {
                
                 if (Input.GetKeyDown(KeyCode.DownArrow) && playerSelector > 0) {playerSelector -- ;}
                 
                 if (Input.GetKeyDown(KeyCode.UpArrow) && playerSelector < 2) {playerSelector ++;}

            }

    void PlayerCreator(){

        if (Input.GetKeyDown("space")) 
        
            {
                
                Instantiate(objectsToInstantiate[playerSelector],pos.position,objectsToInstantiate[playerSelector].transform.rotation);
           
            }


    }

    void Start()
    {        
        int n = Random.Range(0,objectsToInstantiate.Length);
    }


    void Update()
    {
  
     
        if (Input.anyKey) {Debug.Log(objectsToInstantiate[playerSelector]);}
         PlayerSelector();
         PlayerCreator();
    }
}
