using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using UnityEngine.SceneManagement;
public class ScoreManager : MonoBehaviour
{

    public int scoreToReach;

    private int player1Score = 0;
	private int player2Score = 0;
	
	public Text player1ScoreText;
	public Text player2ScoreText;
	
	public void Player1Goal()
	{
		player1Score++;
		player1ScoreText.text = player1Score.ToString();
        CheckScore();
	}
	
	public void Player2Goal()
	{
		player2Score++;
		player2ScoreText.text = player2Score.ToString();
        CheckScore();
	}
	private void CheckScore()
    {
        if(player1Score==scoreToReach || player2Score==scoreToReach )
        {
            SceneManager.LoadScene(2);
        }
    }
}
