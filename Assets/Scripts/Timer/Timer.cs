using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public Image timeFiller;
    public float gameTime;
    public Text Over;
    public Button restartLevel;
    // Start is called before the first frame update
    void Start()
    {
        Over.enabled = false;
        timeFiller.fillAmount = gameTime;
        restartLevel.gameObject.SetActive(false);
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
              Over.enabled = true;
              Time.timeScale = 0f;
              restartLevel.gameObject.SetActive(true);
            }
            
    }

    public void LevelAgain()
    {
       SceneManager.LoadScene("Test Prieance");
    } 

    public void BackToMainMenu()
    {
        SceneManager.LoadScene("01.Main Menu");
    }
}
