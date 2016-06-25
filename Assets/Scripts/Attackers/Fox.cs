using UnityEngine;
using System.Collections;

//zorgt dat er altijd een attacker script aan Fox gelinkt is

[RequireComponent (typeof(Attacker))]

public class Fox : MonoBehaviour 
{

    private Animator animFox;
    private Attacker attacker;

	// Use this for initialization
	void Start () 
	{
        animFox = GetComponent<Animator>();
        attacker = GetComponent<Attacker>();
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}

    void OnTriggerEnter2D (Collider2D collider)
    {
        GameObject objectCollidedwith = collider.gameObject;

        if (!objectCollidedwith.GetComponent<Defender>())
        {
            return; // leave method
        }
        //als we botsen met grafsteen -> spring
        if (objectCollidedwith.GetComponent<Stone>())
        {
            animFox.SetTrigger("jump trigger");
        }
        //botsen met andere defender -> attack
        else
        {
            animFox.SetBool("isAttacking", true);
            attacker.Attack(objectCollidedwith);
        }

    }
}