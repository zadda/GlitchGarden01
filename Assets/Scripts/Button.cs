using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Button : MonoBehaviour 
{
    private Button[] buttonArray;
    private Text costText;
    

    public GameObject defenderPrefab;
    public static GameObject selectedDefender; // maar 1 in heel het spel, maar static dus toegangkelijk van uit andere scripts

	// Use this for initialization
	void Start () 
	{
        buttonArray = GameObject.FindObjectsOfType<Button>();
        costText = GetComponentInChildren<Text>(); // text is toegevoegd aan children

        if (!costText)
        {
            Debug.Log(name + "has no assigned cost text element");
        }

        costText.text = defenderPrefab.GetComponent<Defender>().starCost.ToString();
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