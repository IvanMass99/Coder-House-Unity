using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_movimiento_ASWD : MonoBehaviour
{
   public float speed = 10f;

    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontalInput, 0f, verticalInput) * speed * Time.deltaTime;

        Vector3 newPosition = transform.position + movement;
        newPosition.x = Mathf.Clamp(newPosition.x, -5f, 5f);
        newPosition.z = Mathf.Clamp(newPosition.z, -5f, 5f);

        transform.position = newPosition;
    }
}
