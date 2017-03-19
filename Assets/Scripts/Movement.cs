using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    public float speed;
    public float speed_P = 30;
    Rigidbody2D body;
    public float maxSpeed = 1;
    


	// Use this for initialization
	void Start () {
        body = GetComponent<Rigidbody2D>();

	}
   
    void Update () {

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            MoveLeft();
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            MoveRight();
        }
        

        /*
        if (Input.GetKey(KeyCode.UpArrow))
        {
            MoveUp();
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            MoveDown();
        }
        */
    }

    void MoveLeft()
    {
        body.AddRelativeForce(body.velocity.normalized + Vector2.left * speed_P);
        body.velocity = Vector2.ClampMagnitude(body.velocity, maxSpeed);
    }
    void MoveRight()
    {
        body.AddRelativeForce(body.velocity.normalized + Vector2.right * speed_P);
        body.velocity = Vector2.ClampMagnitude(body.velocity, maxSpeed);


    }

    /*

    void MoveLeft()
    {
        transform.position += Vector3.left * 5 * Time.deltaTime;
    }
    void MoveRight()
    {
        transform.position += Vector3.right * 5 * Time.deltaTime;
    }
    void MoveUp()
    {
        transform.position += Vector3.up * 5 * Time.deltaTime;
    }
    void MoveDown()
    {
        transform.position += Vector3.down * 5 * Time.deltaTime;
    }
    */
}
