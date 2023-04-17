using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WinText : MonoBehaviour
{
    public float velocidad = 1f;
    public Color[] colores;

    private TextMeshProUGUI texto;
    private int indexColor = 0;
    private float tiempo = 0f;

    void Start()
    {
        texto = GetComponent<TextMeshProUGUI>();
    }

    void Update()
    {
        tiempo += Time.deltaTime * velocidad;
        if (tiempo >= 1f)
        {
            tiempo = 0f;
            indexColor++;
            if (indexColor >= colores.Length)
            {
                indexColor = 0;
            }
        }

        texto.color = Color.Lerp(texto.color, colores[indexColor], Time.deltaTime * velocidad);
    }
}
