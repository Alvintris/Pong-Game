using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement: MonoBehaviour, IMoveable
{
    [SerializeField] private float moveSpeed = 100f;
    private Rigidbody2D player_rb;

    void Start()
    {
        player_rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        Move();
    }

    public void Move()
    {
        if(gameObject.name == "Player1")
        {
            player_rb.velocity = new Vector2(0, Input.GetAxisRaw("leftPaddle")) * Time.deltaTime * moveSpeed;
        }
        else if(gameObject.name == "Player2")
        {
            player_rb.velocity = new Vector2(0, Input.GetAxisRaw("rightPaddle")) * Time.deltaTime * moveSpeed;
        }
    }

    public void ResetPos()
    {
        player_rb.position = new Vector2(player_rb.position.x, 0);
    }
}
