//Hernández Gutiérrez Daniel
//Programación Orientada a Objetos
//Vidas - Ejercicio 2
/*
En este script se mantendrá el contador de vidas para que sea heradado y manipulado por la clase principal;
UIManager.
*/
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vidas : Score
{
    public static int Total_Vidas = 5; //Mantenemos el conteo en esta variable.
}
