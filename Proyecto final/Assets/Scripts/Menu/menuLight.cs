using System;
using System.Collections;
using System.Linq;
using UnityEngine;

public class menuLight : MonoBehaviour 

{

    public float tiempoMinimo = 0.1f;
    public float tiempoMaximo = 1.0f;

    private Light luz;

    void Start()
    {
        luz = GetComponent<Light>();
        StartCoroutine("Parpadear");
    }

    IEnumerator Parpadear()
    {
        while (true)
        {
            yield return new WaitForSeconds(UnityEngine.Random.Range(tiempoMinimo, tiempoMaximo));
            luz.enabled = !luz.enabled;
        }
    }
}