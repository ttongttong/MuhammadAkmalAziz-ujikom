using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour
{
    public float hungerValue = 25;

    int foodTimer = 300;
    void Update()
    {
        foodTimer--;
        
        if(foodTimer == 0)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter(Collision other) {
        Destroy(gameObject);
        Destroy(other.gameObject);
    }
}
