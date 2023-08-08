using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPaddle : Paddle
{
    private Vector2 direction;

    // User can control the paddle only on y-axis with w and s buttons.
    private void Update()
    {
        if (Input.GetKey(KeyCode.W)) 
        {
            direction = Vector2.up;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            direction = Vector2.down;
        }
        else 
        { 
            direction = Vector2.zero;
        }
        
    }

    private void FixedUpdate()
    {
        //According to keycode inputs the paddle's the force is added to the rigidbody component of the player paddle object.
        if(direction.sqrMagnitude != 0)
        {
            rigidbody.AddForce(direction * speed);
        }
    }




}
