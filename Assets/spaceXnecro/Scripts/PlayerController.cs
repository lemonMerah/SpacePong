using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb2d;

    public KeyCode moveUp;

    public KeyCode moveDown;

    public float speed;

    public float boundY;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }


    void Movement()
    {
        var vel = rb2d.velocity;
        if (Input.GetKey(moveUp)) vel.y = speed;
        else if (Input.GetKey(moveDown)) vel.y = -speed;
        else vel.y = 0;
        rb2d.velocity = vel;
    }

    void LimitPost()
    {
        var pos = transform.position;
        if (pos.y > boundY)
        {
            pos.y = boundY;
        }
        else if (pos.y < -boundY)
        {
            pos.y = -boundY;
        }
        transform.position = pos;  
    }
        

    void Update()
    {
        Movement();
        LimitPost();
    }
}
