using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjT6 : MonoBehaviour
{
    // Start is called before the first frame update
    public int entcampo;
    public int entplatea;

    void Start()
    {
        int preciocampo;
        preciocampo = entcampo * 1200;
        int precioplatea;
        precioplatea = entplatea * 2000;
        int enttotal;
        enttotal = preciocampo + precioplatea;
        int captotal;
        captotal = entcampo + entplatea;
        int entradaslibres;
        entradaslibres = 36300 - captotal;



        Debug.Log("Ingrese la cantidad de entradas vendidas en sector campo");

        if (entcampo <= 20400 && entcampo > 0)

        {
            Debug.Log("Se recaudaron $" + preciocampo + " solo con las entradas de sector campo");
        }
        else
        {
            Debug.Log("No es posible que se hayan vendido tantas entradas");
        }

        Debug.Log("Ingrese la cantidad de entradas vendidas en sector platea");

        if (entplatea <= 16200 && entplatea > 0)
        {
            Debug.Log("Se recaudaron $" + precioplatea + " solo con las entradas de sector platea. El total de plata recaudada sumando secotr campo y platea fue $" + enttotal);

        }

        else
        {
            Debug.Log("No es posible que se hayan vendido tantas entradas");
        }

        if (captotal < 36300)
        {
            Debug.Log("Quedaron " + entradaslibres + " sin vender");

        }

        else if (captotal == 36600)
        {
            Debug.Log("Sold out!");

        }
        else
        {
            Debug.Log("No se pudieron vender tantas entradas");
        }

        if (captotal >= 18300)
        {
            Debug.Log("El festival fue un éxito!");
        }

        else
        {
            Debug.Log("Debemos mejorar la convocatoria");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
