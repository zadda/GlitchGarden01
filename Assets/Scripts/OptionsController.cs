using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class OptionsController : MonoBehaviour
{
    public Slider sliderVolume;
    public Slider sliderDifficulty;
    public Text textDifficulty;
    public LevelManager levelManager;

    private MusicPlayer musicManager;
    // Use this for initialization
    void Start ()
    {
        musicManager = GameObject.FindObjectOfType<MusicPlayer>();

	}
	
	// Update is called once per frame
	void Update ()
    {
	
	}

    public void SaveAndExit()
    {
        PlayerPrefsManager.SetMasterVolume(sliderVolume.value);
        PlayerPrefsManager.SetDifficulty(sliderDifficulty.value);
        levelManager.LoadLevel("00Start Menu");
    }

    public void PrintDifficultyLevel()
    {
        string graad = "easy";

        if (sliderDifficulty.value == 1)
        {
            graad = "easy";
        }
        else if (sliderDifficulty.value == 2)
        {
            graad = "medium";
        }
        else if (sliderDifficulty.value == 3)
        {
            graad = "hard";
        }

        textDifficulty.text = graad;
        
    }
}