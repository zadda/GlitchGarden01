using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MusicPlayer : MonoBehaviour
{

    public AudioClip[] levelMusicChangeArray;
    private AudioSource audioSource;

    void Awake()
    {        
        DontDestroyOnLoad(gameObject);
    }

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.volume = PlayerPrefsManager.GetMasterVolume();
    }

	void OnLevelWasLoaded (int level)
    {
        AudioClip thisLevelsMusic = levelMusicChangeArray[level];
        //level = SceneManager.GetActiveScene().buildIndex +1;

        if (thisLevelsMusic)
        {
            audioSource.clip = thisLevelsMusic;
            audioSource.loop = true;
            audioSource.Play();
        }
	}

    public void ChangeVolume(float volumeLevel)
    {
        audioSource.volume = volumeLevel;
    }
}