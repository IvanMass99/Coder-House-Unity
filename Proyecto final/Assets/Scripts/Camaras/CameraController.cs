using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    // Mouse control

    public Transform jugador; //referencia al transform del jugador
    public float mouse_sensivity = 2.0f;

    // Zoom control
    
    public float velocidadZoom = 1f; //velocidad a la que se hace el zoom

    public float distanciaInicial = 14f; //distancia inicial de la cámara al jugador
    public float distanciaActual; //distancia actual de la cámara al jugador

    public float zoomMinimo = 10f; //zoom mínimo permitido
    public float zoomMaximo = 18; //zoom máximo permitido

    public float zoom_sensivity = 12f; //sensibilidad del scroll del mouse


    private void MouseControl() 
    
            {

                if (Input.GetMouseButton(0))
                {
                    float mouseX = Input.GetAxis("Mouse X") * mouse_sensivity;
                    float mouseY = Input.GetAxis("Mouse Y") * mouse_sensivity;

                    transform.RotateAround(jugador.position, Vector3.up, mouseX);
                    transform.RotateAround(jugador.position, transform.right, -mouseY);
                }

            }

    private void ZoomControl() 
    
            {

                float scroll = Input.GetAxis("Mouse ScrollWheel") * zoom_sensivity;
                distanciaActual -= scroll;
                distanciaActual = Mathf.Clamp(distanciaActual, zoomMinimo, zoomMaximo);
                transform.position = jugador.position - transform.forward * distanciaActual;

            }

    void Start()

        {
            distanciaActual = distanciaInicial;
            transform.position = jugador.position + transform.forward * distanciaActual;
        }



    void Update()

        {
            MouseControl();
            ZoomControl();
        }
}





