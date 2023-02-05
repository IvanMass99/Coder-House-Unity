using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{

    public GameObject oMainCamera;
    public GameObject oThirdCamera;
    public bool vToggle = false;


    void ToggleCamera() { // if ((oMainCamera.activeInHierarchy) && (Input.GetKeyDown(KeyCode.Space))) 

        if (Input.GetKeyDown(KeyCode.Space)) {vToggle = !vToggle;};

    }

    void Start()
    {

        oMainCamera.SetActive(true);
        oThirdCamera.SetActive(false);
        
    }

    
    void Update()
    {

        ToggleCamera();
        oMainCamera.SetActive(vToggle);
        oThirdCamera.SetActive(!vToggle);
        Debug.Log(vToggle);


    }
}
