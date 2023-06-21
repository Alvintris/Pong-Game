using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    GameManager gM;


    private void Start()
    {
        gM = GameObject.Find("GameManager").GetComponent<GameManager>();    
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(this.gameObject.tag == "leftGoal" && collision.gameObject.tag == "Ball")
        {
            GameObject.Find("Ball").GetComponent<BallMovement>().Reset();
            GameObject.Find("Player1").GetComponent<PlayerMovement>().ResetPos();
            GameObject.Find("Player2").GetComponent<PlayerMovement>().ResetPos();
            GameObject.Find("GameManager").GetComponent<GameManager>().player2Scored();
            gM.GoalSoundPlay();
        }
        else if (this.gameObject.tag == "rightGoal" && collision.gameObject.tag == "Ball")
        {
            GameObject.Find("Ball").GetComponent<BallMovement>().Reset();
            GameObject.Find("Player1").GetComponent<PlayerMovement>().ResetPos();
            GameObject.Find("Player2").GetComponent<PlayerMovement>().ResetPos();
            GameObject.Find("GameManager").GetComponent<GameManager>().player1Scored();
            gM.GoalSoundPlay();
        }
    }
}
