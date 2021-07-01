using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomEnemy : ArrayEnemies
{
    // Start is called before the first frame update
    void Start()
    {
        NumeroRandom();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void NumeroRandom()
    {
        int NumeroEnemy = Random.Range(1,3);
        Instantiate(Enemies[0],new Vector3(0,0,0),Quaternion.identity); 
        print(NumeroEnemy);
    }
    
}
