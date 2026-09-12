using UnityEngine;
using TMPro;
using System.Collections.Generic;
using System.Collections;
using UnityEngine.SceneManagement;
public class gamemanager : MonoBehaviour
{
    public float timeleft = 20f;
    public bool gameover = false;
    public bool win = false;
    public GameObject levelcleared;
    public GameObject gameove;
    public GameObject sphere;
    public playermoving player;
    public TextMeshProUGUI timertext;
    public GameObject buttontext;
    void Start()
    {
        levelcleared.SetActive(false);   // when the game starts the text will not appeared 
        gameove.SetActive(false);
        buttontext.SetActive(false);
    }

    
    void Update()                     
    {
        if (timeleft >= 0 && !gameover)
        {
           timeleft -= Time.deltaTime;    // decrement the time 
           timertext.text = timeleft.ToString("F1");  // shows the countdown timer 
        }

        if (timeleft <= 0 && !win)
        {
            GameOver();           //calls the game over when the timeleft is zero 
        }
    }

    public void GameWin()
    {
        win = true;
        levelcleared.SetActive(true);
        player.enabled = false;
        sphere.SetActive(false);
    }

    public void GameOver()
    {
        gameove.SetActive(true);
        sphere.SetActive(false); 
        buttontext.SetActive(true);
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);     // restart the scene 
    }
    
}
