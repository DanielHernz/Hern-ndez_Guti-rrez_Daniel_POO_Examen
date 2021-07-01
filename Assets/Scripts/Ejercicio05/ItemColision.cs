//Hernández Gutiérrez Daniel
//Programación Orientada a Objetos
//PlayerControls - Ejercicio 2
/*

*/
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemColision : MonoBehaviour
{
    protected void OnTriggerEnter(Collider other) 
    {
        if (other.tag == "Player")
        {
            Items.ITEM_destroy++;
            Destroy(gameObject);
        }
    }
}
