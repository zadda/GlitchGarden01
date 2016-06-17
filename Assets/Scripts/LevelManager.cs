using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public float autoLoadNextLevelAfter;

    void Start()
    {
        Invoke("LoadNextLevel", autoLoadNextLevelAfter);
    }

	public void LoadLevel(string nameLevel)
    {
        SceneManager.LoadScene(nameLevel);
    }

    public void LoadNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

	public void QuitRequest()
    {
		//Debug.Log ("Quit requested");
		Application.Quit ();
	}
}