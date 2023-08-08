using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private int playerScore, computerScore;
    public Text playerScoreText, computerScoreText;
    public Ball ball;
    public PlayerPaddle playerPaddle;
    public ComputerPaddle computerPaddle;
    public void PlayerScores()
    {
        playerScore++;
        playerScoreText.text = playerScore.ToString();
        ResetValues();
    }

    public void ComputerScores()
    {
        computerScore++;
        computerScoreText.text = computerScore.ToString();
        ResetValues();

    }
    // When computer || player scores, this method is going to work. It relocates the paddles and the ball on the scene to the initial position.
    private void ResetValues()
    {
        ball.ResetBallPosition();
        playerPaddle.ResetPosition();
        computerPaddle.ResetPosition();
    }
}
