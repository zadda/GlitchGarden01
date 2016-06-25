using UnityEngine;
using System.Collections;

public class Defender : MonoBehaviour 
{
    [Range (-1f,1.5f)]
    private float walkSpeed;
    private GameObject currentTarget;
    private Animator animator;

    // Use this for initialization
    void Start () 
	{
        animator = GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update () 
	{
        if (!currentTarget)
        {
            //animator.SetBool("isDefending", false);
        }
    }

    void OnTriggerEnter2D()
    {
       
    }

    public void StrikeCurrentAttacker(float damage)
    {
        if (currentTarget) // er is alleen een currentTarget bij attack mode
        {
            Health health = currentTarget.GetComponent<Health>();
            if (health) // heeft het currenttarget wel een Health waarde
            {
                health.DealDamage(damage);
            }
        }
    }

    public void Defend(GameObject obj)
    {
        currentTarget = obj;
    }
}