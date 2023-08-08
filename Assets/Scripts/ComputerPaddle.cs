using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Some features are inherited from Paddle class so this class is a child of Paddle class instead of MonoBehavior.
public class ComputerPaddle : Paddle
{
    public Rigidbody2D ballRigidbody;
    private void FixedUpdate()
    {
        // The computer moves according to ball's position and velocity which is on the scene.
        // If ball goes to right(computer side) the ball is act like first code block
        if(ballRigidbody.velocity.x > 0)
        {
            if (ballRigidbody.transform.position.y > transform.position.y)
            {
                rigidbody.AddForce(Vector2.up * speed);
            }
            else if (ballRigidbody.transform.position.y < transform.position.y)
            {
                rigidbody.AddForce(Vector2.down * speed);
            }
        }
        // Else computer paddle goes to the center of the y axis that belongs
        else
        {
            if(transform.position.y > 0.0f) 
            {
                rigidbody.AddForce(Vector2.down * speed);
            }
            else if (transform.position.y < 0.0f)
            {
                rigidbody.AddForce(Vector2.up * speed);
            }
        }
    }
}
