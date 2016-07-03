using UnityEngine;
using System.Collections;

public class StopGame : MonoBehaviour 
{
    private LevelManager levelManager;

    void Start()
    {
        levelManager = GameObject.FindObjectOfType<LevelManager>();
    }

    void OnMouseDown()
    {
        levelManager.LoadLevel("00Start Menu");
    }
    //Optional method to pause game when PopUp is active.
    public void TogglePauseGame()
    {
        bool isPopUpActive = false;
        if (isPopUpActive)
        {
            Time.timeScale = 0.0f;
        }
        else
        {
            Time.timeScale = 1.0f;
        }
    }
}