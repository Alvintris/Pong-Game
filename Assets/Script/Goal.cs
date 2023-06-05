using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(this.gameObject.tag == "leftGoal" && collision.gameObject.tag == "Ball")
        {
            GameObject.Find("Ball").GetComponent<BallMovement>().Reset();
            GameObject.Find("GameManager").GetComponent<GameManager>().player2Scored();
        }
        else if (this.gameObject.tag == "rightGoal" && collision.gameObject.tag == "Ball")
        {
            GameObject.Find("Ball").GetComponent<BallMovement>().Reset();
            GameObject.Find("GameManager").GetComponent<GameManager>().player1Scored();
        }
    }
}
