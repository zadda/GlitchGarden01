using UnityEngine;
using System.Collections;

public class TEST : MonoBehaviour
{

	// Use this for initialization
	void Start ()
    {
        Debug.Log("music volume: " + PlayerPrefsManager.GetMasterVolume());
       // PlayerPrefsManager.SetMasterVolume(0.4f);
        //Debug.Log(PlayerPrefsManager.GetMasterVolume());

       // Debug.Log(PlayerPrefsManager.IsLevelUnlocked(2));
        PlayerPrefsManager.UnlockLevel(2);
        Debug.Log(PlayerPrefsManager.IsLevelUnlocked(2));

        Debug.Log("Difficulty: " + PlayerPrefsManager.GetDifficulty());
        //PlayerPrefsManager.SetDifficulty(0.2f);
        //Debug.Log("Difficulty: " + PlayerPrefsManager.GetDifficulty());
    }
	
	// Update is called once per frame
	void Update ()
    {
	
	}
}