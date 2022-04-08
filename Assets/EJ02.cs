//Crear las variables necesarias para ingresar por Inspector el precio de 3 productos y un monto de dinero disponible.
//Comunicar si la suma de los mismos supera o no el monto de dinero disponible.Luego indicar cuánto dinero sobra o falta.
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EJ02 : MonoBehaviour
{
    public float producto1;
    public float producto2;
    public float producto3;
    public float dinerodisp;
    float total;
    void Start()
    {
        total = producto1 + producto2 + producto3;
        if (total <= dinerodisp)
            Debug.Log("Esta compra es menor el monto y te sobra: " + (dinerodisp - total));
        else
            Debug.Log("Esta compra supera tu monto y te falta: " + (total - dinerodisp));
    }


    void Update()
    {

    }
}
