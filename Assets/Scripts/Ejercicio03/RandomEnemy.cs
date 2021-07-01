//Hernández Gutiérrez Daniel
//Programación Orientada a Objetos
//Vidas - Ejercicio 3
/*
Este script tenía por función instanciar enemigos aleatorios en un espacio aleatorio.
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomEnemy : ArrayEnemies
{
    // Start is called before the first frame update
    void Start()
    {
        NumeroRandom(); //Llamamos al método
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void NumeroRandom()
    {
        int NumeroEnemy = Random.Range(1,3); //Generar numero random para seleccionar array
        Instantiate(Enemies[0],new Vector3(0,0,0),Quaternion.identity); //Instanciar el elemento array que genere random
        print(NumeroEnemy); //Prueba de que el método fue ejecutado
    }
    
}
