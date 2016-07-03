using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Defender : MonoBehaviour 
{
    [Range (-1f,1.5f)]
    private float walkSpeed;
   // private GameObject currentTarget;

    private StarScoreDisplay starDisplay;
    public int starCost = 100;

    //private Animator animator;

    // Use this for initialization
    void Start () 
	{
        starDisplay = GameObject.FindObjectOfType<StarScoreDisplay>();
       
        // animator = GetComponent<Animator>();
    }
	

    //public void StrikeCurrentAttacker(float damage)
    //{
    //    if (currentTarget) // er is alleen een currentTarget bij attack mode
    //    {
    //        Health health = currentTarget.GetComponent<Health>();
    //        if (health) // heeft het currenttarget wel een Health waarde
    //        {
    //            health.DealDamage(damage);
    //        }
    //    }
    //}

    public void AddStars(int amount)
    {
        starDisplay.AddStars(amount);
        //myText.text = score.ToString();
    }

    //public void Defend(GameObject obj)
    //{
    //    currentTarget = obj;
    //}
}