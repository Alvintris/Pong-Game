using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField] private TMP_Text player1Score;
    [SerializeField] private TMP_Text player2Score;

    private int scorePlayer1 = 0;
    private int scorePlayer2 = 0;

    // Start is called before the first frame update
    void Awake()
    {
        player1Score.SetText(scorePlayer1.ToString());
        player2Score.SetText(scorePlayer2.ToString());
    }

    public void player1Scored()
    {
        scorePlayer1 += 1;
        player1Score.SetText(scorePlayer1.ToString());
    }

    public void player2Scored()
    {
        scorePlayer2 += 1;
        player2Score.SetText(scorePlayer2.ToString());
    }
}
