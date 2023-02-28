using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public Image timeFiller;
    public float gameTime;
    // Start is called before the first frame update
    void Start()
    {
        timeFiller.fillAmount = gameTime;
    }

    // Update is called once per frame
    void Update()
    {
        levelTime();
    }

    void levelTime()
    {
        
        timeFiller.fillAmount -= Time.deltaTime / gameTime;
        if (timeFiller.fillAmount <= 0)
            {
                Time.timeScale = 0f;
                GameOver();
            }    
    }

    public void GameOver()
    {
        SceneManager.LoadScene("04.GameOver");
    }
}