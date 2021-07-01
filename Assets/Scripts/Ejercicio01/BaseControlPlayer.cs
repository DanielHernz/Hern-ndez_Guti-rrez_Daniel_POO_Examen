//Hernández Gutiérrez Daniel
//Programación Orientada a Objetos
//PlayerControls - Ejercicio 1
/*
Este script ejecuta las mecánicas de movimiento del player y reproduce sus animaciones 
pertinentes. Solo requiere de la autorización de otro script complementario.
*/
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseControlPlayer : MonoBehaviour
{
    //Definimos las variables necesarias para el movimiento del player.
    protected Vector3 Direction;
    private float VelocidadMov = 5; 
    private float VelocidadRot = 300;
    Animator AnimPlayer; //Invocamos animator para poder tener control sobre las animaciones.

    private void Awake() 
    {
        AnimPlayer = GetComponent<Animator>();   
    }

    protected void ControlPersonaje()
    {
        float vertical=Input.GetAxis("Vertical"); //GetAxis tiene la ventaja de manejar el valor positivo y negativo en el movimiento sobre el eje
        Direction = new Vector3 (0,0,vertical); //Definimos que el eje X es aquel que direccionará el movimiento.
        Direction *= Time.deltaTime*VelocidadMov; // Hacemos que el movimiento adopte un valor para ejecutarlo progresivamente y no inmediatamente
        this.transform.Translate(Direction); //Hacemos que la mecanica afecte la posición del gameObject conforme al valor.

        bool DireccionAdelante = Direction.z != 0 ? true:false; //Mientras la fuerza del movimiento no sea igual a 0; lo que equivaldria a estar quieto, la animación de correr puede reproducirse.
        AnimPlayer.SetBool("Run",DireccionAdelante); //Cuando el movimiento no sea 0 la variable buleana se activará y la animación "Run" se reproducirá.

        if(Input.GetKeyDown(KeyCode.Space)){AnimPlayer.SetTrigger("JumpF");} //Siendo la animación JumpF una lineal sin un bucle, usamos SetTrigger para iniciar la reproducción y dejar que regrese al estado original cuando termine.
        //Es importante mantener este if dentro del evento de ControlPersonaje ya que esta animación genera un movimiento que solo puede ir despues de habaer corrido.
    } 

    protected void Salto()
    {
        if(Input.GetKeyDown(KeyCode.Space)){AnimPlayer.SetTrigger("Jump");} //Animación de salto estático.
    }
    protected void Golpe()
    {
        if(Input.GetMouseButtonDown(0)){AnimPlayer.SetTrigger("Punch");} //Animación de golpe, bakeado en Unity para evitar su rotación.
    }
    protected void MirarMouse()
    {
        float RotacionX = Input.GetAxisRaw("Mouse X"); //GetAxisRaw ofrece una sensación de movimiento más comoda y maneja el valor positivo y negativo del movimiento.
        Vector3 Rotacion = new Vector3 (0,RotacionX,0); //Definimos que el movimiento rotatorio será en el eje Y.
        RotacionX *= Time.deltaTime * VelocidadRot; //Generamos un valor al movimiento y lo hacemos progresivo.
        this.transform.Rotate(Rotacion); //Hacemos que la mecánica afecte la rotación del gameObject.
    }
}
