using UnityEngine;
using System.Collections;

public class Button : MonoBehaviour 
{
    private Button[] buttonArray;
    public GameObject defenderPrefab;
    public static GameObject selectedDefender; // maar 1 in heel het spel, maar static dus toegangkelijk van uit andere scripts

	// Use this for initialization
	void Start () 
	{

        buttonArray = GameObject.FindObjectsOfType<Button>();
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}

    void OnMouseDown()
    {
        //Debug.Log(name + "pressed");

        foreach (Button thisButton in buttonArray)
        { 
            thisButton.GetComponent<SpriteRenderer>().color = Color.black;
        }
        GetComponent<SpriteRenderer>().color = Color.white;
        selectedDefender = defenderPrefab;
    }
}