using UnityEngine;
using System.Collections;

[RequireComponent (typeof(Rigidbody2D))]

public class Attacker : MonoBehaviour 
{
    //[Range (-1f,1.5f)]
    private float currentSpeed;
    private GameObject currentTarget;
    private Animator animator;

	// Use this for initialization
	void Start () 
	{
        animator = GetComponent<Animator>(); // geen GameObject nodig want zit op zelfde object
        //add RigidBody2D
        //Rigidbody2D myRigidBody = gameObject.AddComponent<Rigidbody2D>();
        //myRigidBody.isKinematic = true;
	}
	
	// Update is called once per frame
	void Update () 
	{
        transform.Translate(Vector3.left * currentSpeed * Time.deltaTime); // beweeg sprite <---
        if (!currentTarget)
        {
            animator.SetBool("isAttacking", false);
        }
	}

    void OnTriggerEnter2D()
    {
        //Debug.Log(name + "Trigger enter");
    }

    public void SetSpeed(float speed)
    {
        currentSpeed = speed;
    }

    public void StrikeCurrentTarget (float damage)
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

    public void Attack(GameObject obj)
    {
        currentTarget = obj;
    }
}