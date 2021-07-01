//Hernández Gutiérrez Daniel
//Programación Orientada a Objetos
//ItemColision - Ejercicio 5
/*
Este script registra las colisiones de los prefabs, dueños de este script, con el Player. 
Dando la instrucción de sumar 1 a la variable publica en Items, para después destruir al gameObject portador.
Debido a que "Destroy" no puede ser usado cuando el script hereda otra clase y que guardar la variable aquí sería 
inutil por tener el script ser destruido; no hubo mejor solución que está.
*/
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemColision : MonoBehaviour
{
    protected void OnTriggerEnter(Collider other) 
    {
        if (other.tag == "Player") //Presentamos la condicionante de colisionar con el gameObject con el tag "Player"
        {
            Items.ITEM_destroy++; //Sumamos 1 a la variable
            Destroy(gameObject); //Destruimos el gameObject portador
        }
    }
}
