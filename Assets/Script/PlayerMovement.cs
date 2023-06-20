using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement: MonoBehaviour, IMoveable
{
    [SerializeField] private float moveSpeed = 100f;
    private Rigidbody2D player_rb;

    // Start is called before the first frame update
    void Start()
    {
        player_rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Move();
    }

    public void Move()
    {
        if(gameObject.name == "Player1")
        {
            player_rb.velocity = new Vector2(0, Input.GetAxisRaw("leftPaddle")) * Time.deltaTime * moveSpeed;
            //player_rb.transform.position += new Vector3(0, Input.GetAxisRaw("leftPaddle"), 0) * Time.deltaTime * moveSpeed;
        }
        else if(gameObject.name == "Player2")
        {
            player_rb.velocity = new Vector2(0, Input.GetAxisRaw("rightPaddle")) * Time.deltaTime * moveSpeed;
            //player_rb.transform.position += new Vector3(0, Input.GetAxisRaw("rightPaddle"), 0) * Time.deltaTime * moveSpeed;
        }
    }
}
