using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartMenu : MonoBehaviour
{

    public GameObject ScoreBoardUI;
    public GameObject MainMenuUI;
    [SerializeField] private Text scoreBoardText;
    public void StartGame()
    {
        PlayerPrefs.SetInt("CurrentScore", 0);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void HighScore()
    {
        MainMenuUI.SetActive (false);
        ScoreBoardUI.SetActive (true);
        scoreBoardText.text = "Your Scores: " + PlayerPrefs.GetInt("CurrentScore");

    }
    public void Back()
    {
        MainMenuUI.SetActive(true);
        ScoreBoardUI.SetActive(false);
    }
  
}
