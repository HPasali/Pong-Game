using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Some datas are same between ComputerPaddle and PlayerPaddle so common functions and parameters are created in that class.
public class Paddle : MonoBehaviour
{
    protected Rigidbody2D rigidbody;
    public float speed;

    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }
    // On GameManager class this method is used to reset paddles position.
    public void ResetPosition()
    {
        rigidbody.velocity = Vector2.zero;
        rigidbody.gameObject.transform.position = new Vector2(rigidbody.gameObject.transform.position.x, 0.0f);
    }


}
