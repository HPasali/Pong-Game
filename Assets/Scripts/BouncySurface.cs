using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouncySurface : MonoBehaviour
{
    public float bounceStrength;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Only ball can be collided so a ball object is created according to collision.
        Ball ball = collision.gameObject.GetComponent<Ball>();

        if (ball != null)
        {
            //The ball speed is increased to make game a little bit harder.
            Vector2 normal = collision.GetContact(0).normal;
            Debug.Log("Bouncy Surface is working!");
            ball.AddBouncyForce(-normal * bounceStrength);
        }
    }
}
