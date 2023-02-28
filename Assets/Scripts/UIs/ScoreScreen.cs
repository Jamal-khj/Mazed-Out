using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreScreen : MonoBehaviour
{
    //public void LoadGame()
    //{
    //    SceneManager.LoadScene("03.Score Screen");
    //}

    private void OnTriggerEnter(Collider collision)
    {
        if(collision.tag.Equals("Exit"))
        {
            SceneManager.LoadScene("03.Score Screen");
        }
    }
}
