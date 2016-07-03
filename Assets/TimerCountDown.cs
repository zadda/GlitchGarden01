using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TimerCountDown : MonoBehaviour 
{
    private Text timeLeftText;
    private float timeLeft;
    private GameTimer gameTimer;
    private float levelTime;
    private Slider timeLeftCountdownSlider;

    // Use this for initialization
    void Start () 
	{
        gameTimer = GameObject.FindObjectOfType<GameTimer>();
        timeLeftCountdownSlider = GameObject.FindObjectOfType<Slider>();
        timeLeftText = GetComponent<Text>();
        timeLeft = timeLeftCountdownSlider.value;
        timeLeftText.text = timeLeft.ToString();

        levelTime = gameTimer.levelTime;
    }

    //Update is called once per frame

    void Update()
    {
        timeLeft = levelTime - timeLeftCountdownSlider.value;

        timeLeftText.text = timeLeft.ToString("#0");
    }

}