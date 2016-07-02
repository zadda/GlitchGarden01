using UnityEngine;
using System.Collections;
using UnityEngine.UI;

[RequireComponent (typeof (Text))]
public class StarScoreDisplay : MonoBehaviour 
{
    private Text myScoreText;
    private int stars = 100;
    public enum Status { Success, Failure};

    void Start()
    {
        myScoreText = GetComponent<Text>(); // geen gameobject prefix nodig, want object zit op hetzelfde parent object
        UpdateDisplay();
    }


	public void AddStars(int amount)
    {
        stars += amount;
        UpdateDisplay();
    }


    public Status UseStars(int amount)
    {
        if (stars >= amount)
        {
            stars -= amount;
            UpdateDisplay();
            return Status.Success;
        }
        else
        {
            return Status.Failure;
        }
    }



    private void UpdateDisplay()
    {
        myScoreText.text = stars.ToString();
    }
}