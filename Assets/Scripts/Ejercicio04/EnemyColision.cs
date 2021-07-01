//Hernández Gutiérrez Daniel
//Programación Orientada a Objetos
//EnemyColision - Ejercicio 
/*
En este script se registrará la colisión entre el player y el enemigo, sumando posteriormente a la
variable score y restando a la variable vidas. Para finalmente destruir al gameObject.
*/
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyColision : MonoBehaviour
{
    protected void OnTriggerEnter(Collider other) 
    {
        if (other.tag == "Player") //Presentamos la condicionante de colisionar con el gameObject con el tag "Player"
        {
            Score.Puntuacion=+10; //Sumamos 10 a la variable
            Vidas.Total_Vidas--; //Restamos 1 a la variable
            Destroy(gameObject); //Destruimos el gameObject portador
        }
    }
}
