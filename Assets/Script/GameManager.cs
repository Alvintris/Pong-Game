using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField] private TMP_Text player1Score;
    [SerializeField] private TMP_Text player2Score;
    [SerializeField] private Canvas gameOverScreen;
    [SerializeField] private Canvas startScreen;

    [SerializeField] private AudioClip[] audioClip;
    private AudioSource audioSource;

    private int scorePlayer1 = 0;
    private int scorePlayer2 = 0;

    void Awake()
    {
        player1Score.SetText(scorePlayer1.ToString());
        player2Score.SetText(scorePlayer2.ToString());
    }

    public void PlaySound()
    {
        audioSource.PlayOneShot(audioClip[0]);
    }

    public void GoalSoundPlay()
    {
        audioSource.PlayOneShot(audioClip[1]);
    }
    private void Start()
    {
        audioSource = GetComponent<AudioSource>();

        Time.timeScale = 0;
        gameOverScreen.enabled = false;
        startScreen.enabled = true;
    }

    private void Update()
    {
        GameOver();
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

    public void GameOver()
    {
        if(scorePlayer1 == 10 || scorePlayer2 == 10)
        {
            Time.timeScale = 0;
            gameOverScreen.enabled = true;
        }
    }

    public void ConfirmBtn()
    {
        scorePlayer1 = 0;
        scorePlayer2 = 0;
        gameOverScreen.enabled = false;
        startScreen.enabled = true;
    }

    public void StartBtn()
    {
        player1Score.SetText(scorePlayer1.ToString());
        player2Score.SetText(scorePlayer2.ToString());
        startScreen.enabled = false;
        Time.timeScale = 1;
    }
}
