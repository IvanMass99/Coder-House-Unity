using System;
using System.Collections;
using System.Linq;
using UnityEngine;

public class Falling : MonoBehaviour {

	public float dañoPorCaída = 10f;
    public float velocidadMinimaParaDaño = 10f;

    private void OnCollisionEnter(Collision other) {
        if (other.gameObject.name == "Cube") {
            float velocidadDeCaída = Mathf.Abs(other.relativeVelocity.y);
            if (velocidadDeCaída > velocidadMinimaParaDaño) {
                float daño = dañoPorCaída * (velocidadDeCaída - velocidadMinimaParaDaño);
                // Aplica el daño al objeto

				Debug.Log("Perdiste"); 
            }
        }
    }

}