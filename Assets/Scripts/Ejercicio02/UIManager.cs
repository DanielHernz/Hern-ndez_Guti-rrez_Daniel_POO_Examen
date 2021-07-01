//Hernández Gutiérrez Daniel
//Programación Orientada a Objetos
//UIManager - Ejercicio 2
/*
Recopilamos la información obtenida en los scripts Score, Items y Vidas para luego transformarlos en objetos UI
para finalmente asignarlos y presentarlos en el canvas.
*/
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : Items //Este script y las 3 clases complementarias; cada una hereda a otra, haciendo facil la multi herencia y poder manipular todos sus datos en una sola clase.
{
    public Text ItemText;
    public Text VidaText;
    public Text ScoreText;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        ItemText.text = ITEM_destroy.ToString(); //Convertimos el valor numerico en texto string y lo asignamos a un texto UI
        VidaText.text = Total_Vidas.ToString(); 
        ScoreText.text = Puntuacion.ToString(); 
    }
}
