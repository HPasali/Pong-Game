using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed;
    private Vector2 direction;
    private Rigidbody2D rb2d;

    private void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        ResetBallPosition();
    }

    // The ball is thrown with RandomizeSpawnBall function to left or right and up or down.
    private void RandomizeSpawnBall()
    {
        float x = Random.value < 0.5f ? -1.0f : 1.0f;
        float y = Random.value < 0.5f ? Random.Range(-1.0f, -0.5f) : Random.Range(0.5f, 1.0f);
        rb2d.AddForce(new Vector2 (x, y) * speed);
    }

    public void AddBouncyForce(Vector2 force)
    {
        rb2d.AddForce(force);
    }
    // This method is working at the beginning of the game and player/computer scores.
    // It supports to relocate the position of the ball to the center. 
    public void ResetBallPosition()
    {
        transform.position = Vector2.zero;
        rb2d.velocity = Vector2.zero;
        RandomizeSpawnBall();
    }
}
