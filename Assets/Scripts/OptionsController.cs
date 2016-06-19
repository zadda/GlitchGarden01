using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class OptionsController : MonoBehaviour
{
    public Slider sliderVolume;
    public Slider sliderDifficulty;
    public Text textDifficulty;
    public Text textMusicLevel;
    public LevelManager levelManager;

    private MusicPlayer musicManager;
    // Use this for initialization
    void Start ()
    {
        musicManager = GameObject.FindObjectOfType<MusicPlayer>();
        PrintDifficultyLevel();
        sliderVolume.value = PlayerPrefsManager.GetMasterVolume();
        sliderDifficulty.value = PlayerPrefsManager.GetDifficulty();
	}
	
	// Update is called once per frame
	void Update ()
    {
        musicManager.ChangeVolume(sliderVolume.value);
	}

    public void SaveAndExit()
    {
        PlayerPrefsManager.SetMasterVolume(sliderVolume.value);
        PlayerPrefsManager.SetDifficulty(sliderDifficulty.value);
        levelManager.LoadLevel("00Start Menu");
    }

    public void PrintDifficultyLevel()
    {
        string graad = "";

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

        textDifficulty.text = graad; // easy, medium of hard
    }

    public void PrintMusicLevel()
    {
        float musicLevel = 0;

        musicLevel = sliderVolume.value * 100;

        textMusicLevel.text = musicLevel.ToString("00.0") + "%";

    }

}