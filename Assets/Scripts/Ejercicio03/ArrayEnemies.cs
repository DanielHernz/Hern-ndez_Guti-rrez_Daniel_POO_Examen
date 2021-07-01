using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayEnemies : MonoBehaviour
{   
    public GameObject[] Enemies;

    void start() 
    {
        Enemies = GameObject.FindGameObjectsWithTag("Enemy");

        for (int i = 0; i < Enemies.Length; i++)
        {

        }
    }
}
