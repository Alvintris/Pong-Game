using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    private Rigidbody2D ball_rb;
    Vector2 direction;
    [SerializeField] private float speed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        ball_rb = GetComponent<Rigidbody2D>();
        direction.x = Random.Range(0, 2) == 0 ? -1 : 1;
        direction.y = Random.Range(0, 2) == 0 ? -1 : 1;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        ball_rb.velocity = direction * speed;
    }

    public void Reset()
    {
        speed = 5f;
        ball_rb.transform.position = Vector3.zero;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Boundry")
        {
            direction.y = -direction.y;
        }
        else if(collision.gameObject.tag == "Paddle")
        {
            speed += Random.Range(0.5f, 1.5f);
            direction.x = -direction.x;
        }
    }
}
