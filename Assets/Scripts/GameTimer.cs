using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class GameTimer : MonoBehaviour 
{
    [Tooltip ("Inspector value overrides code!")]
    public float levelTime = 120f;
    private LevelManager levelManager;
    private Slider timeLeftSlider;
   
    
    // Use this for initialization
    void Start () 
	{
        levelManager = GameObject.FindObjectOfType<LevelManager>();
        timeLeftSlider = GetComponent<Slider>();
        timeLeftSlider.maxValue = levelTime;       
    }
	
	// Update is called once per frame
	void Update () 
	{
        timeLeftSlider.value += 0.05f;
       
        /// alternatief 
        // slider.value = Time.timeSinceLevelLoad / levelSeconds;
        if (timeLeftSlider.value >= levelTime)
        {
            DestroyAllTaggedObjects();
            levelManager.LoadNextLevel();
        }
    }

    void DestroyAllTaggedObjects()
    {
        GameObject[] taggedObjectArray = GameObject.FindGameObjectsWithTag("destroyOnWin");

        foreach (GameObject taggedObject in taggedObjectArray)
        {
            Destroy(taggedObject);
        }
    }
}