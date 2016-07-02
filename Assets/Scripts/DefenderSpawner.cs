using UnityEngine;
using System.Collections;

public class DefenderSpawner : MonoBehaviour 
{
    private GameObject defenderParent;
    public Camera myCamera;
    private StarScoreDisplay starDisplay;
	// Use this for initialization
	void Start () 
	{
        defenderParent = GameObject.Find("Defenders");
        starDisplay = GameObject.FindObjectOfType<StarScoreDisplay>();

        if (!defenderParent)
        {
            defenderParent = new GameObject("Defenders");
        }
    }
    void OnMouseDown()
    {
        Vector2 rawPos = CalculateWorldPointOfMouseClick();
        Vector2 roundedPos = SnapToGrid(rawPos);
        GameObject defender = Button.selectedDefender;

        int defenderCost = defender.GetComponent<Defender>().starCost;

        if (starDisplay.UseStars(defenderCost) == StarScoreDisplay.Status.Success)
        {
            SpawnDefender(roundedPos, defender);
        }
        else
        {
            Debug.Log("not enough money!");
        }
    }

    private void SpawnDefender(Vector2 roundedPos, GameObject defender)
    {
        Quaternion zeroRotation = Quaternion.identity;
        GameObject newDef = Instantiate(defender, roundedPos, zeroRotation) as GameObject;
        newDef.transform.parent = defenderParent.transform;
    }

    Vector2 SnapToGrid (Vector2 rawWorldPos)
    {
        float newX = Mathf.RoundToInt(rawWorldPos.x);
        float newY = Mathf.RoundToInt(rawWorldPos.y);

        return new Vector2(newX, newY);
    }

    Vector2 CalculateWorldPointOfMouseClick()
    {
        float mouseX = Input.mousePosition.x;
        float mouseY = Input.mousePosition.y;
        float distanceFromCamera = 10f;

        Vector3 weirdTriplet = new Vector3(mouseX, mouseY, distanceFromCamera); //

        Vector2 worldPos = myCamera.ScreenToWorldPoint(weirdTriplet);
        
        return worldPos;
    }
}