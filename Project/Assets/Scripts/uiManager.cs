using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class uiManager : MonoBehaviour
{
    public Button[] buttons;
    public Text scoreText;
    bool gameOver;
    int score;

    // Start is called before the first frame update
    void Start()
    {
        gameOver = false;
        score = 0;
        InvokeRepeating("scoreUpdate", 1.0f, 1.5f);
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score: " + score;
    }

    void scoreUpdate()
    {
        if (!gameOver)
        {
            score += 1;
        }
    }

    public void gameOverActivated()
    {
        gameOver = true;
        foreach(Button button in buttons)
        {
            button.gameObject.SetActive(true);
        }
    }

    public void Stage1()
    {
        SceneManager.LoadScene("Stage1");
    }

    public void Stage2()
    {
        SceneManager.LoadScene("Stage2");
    }

    public void Stage3()
    {
        SceneManager.LoadScene("Stage3");
    }

    public void Stage4()
    {
        SceneManager.LoadScene("Stage4");
    }

    public void Pause()
    {
        if (Time.timeScale == 1)
        {
            Time.timeScale = 0;
        }
        else if (Time.timeScale == 0)
        {
            Time.timeScale = 1;
        }
    }

    public void Menu()
    {
        SceneManager.LoadScene("MenuScene");
    }

    public void Exit()
    {
        Application.Quit();
    }
}
