using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.InputSystem;
public class Player1 : MonoBehaviour
{
    public FixedJoystick moveJoystick;
    private Animator anim;
    private Rigidbody rb;
    private float moveH, moveV, speedMove = 5;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        movePlayer();
      
    }
    void movePlayer()
    {
        moveH = moveJoystick.Horizontal;
        moveV = moveJoystick.Vertical;
        Vector3 dir = new Vector3(moveH,0, moveV);
        rb.velocity = new Vector3(moveH * speedMove, rb.velocity.y, moveV * speedMove);
        if(dir != Vector3.zero)
        {
            transform.LookAt(transform.position + dir);
        }
    }
}
