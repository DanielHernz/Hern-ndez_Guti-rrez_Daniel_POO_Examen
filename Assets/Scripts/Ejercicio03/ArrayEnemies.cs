//Hernández Gutiérrez Daniel
//Programación Orientada a Objetos
//Vidas - Ejercicio 3
/*
Este script tenía por función recopilar los prefabs enemigos en un array
*/
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayEnemies : MonoBehaviour
{   
    public GameObject[] Enemies; //Creamos el array basado en gameObjects

    void start() 
    {
        Enemies = GameObject.FindGameObjectsWithTag("Enemy"); //Hacemos que recopile los gameObjects con el tag Enemy

        for (int i = 0; i < Enemies.Length; i++)
        {

        }
    }
}
