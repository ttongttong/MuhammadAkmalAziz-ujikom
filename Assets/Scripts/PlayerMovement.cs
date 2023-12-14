using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 350;
    float move;
    Rigidbody myRigidbody;
    Animator animator;
    public GameObject food;
    public Transform foodSpawn;
    public float foodSpeed = 300;
    float foodTimer = 3f;
    
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
    }

    
    void Update()
    {
        move = Input.GetAxis("Horizontal");
        myRigidbody.velocity = new Vector2(move *speed, 0);
        

        if(Input.GetKeyDown(KeyCode.Space) || Input.GetButtonDown("Fire1"))
        {
            Attack();
        }
    }

    public void Attack()
    {
        var bullet = Instantiate(food, foodSpawn.position, foodSpawn.rotation);
        bullet.GetComponent<Rigidbody>().velocity = foodSpawn.forward * foodSpeed;
        
    }
}
