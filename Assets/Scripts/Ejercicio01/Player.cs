using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : BaseControlPlayer
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ControlPersonaje();
        MirarMouse();
        Golpe();
        Salto();
    }
}
