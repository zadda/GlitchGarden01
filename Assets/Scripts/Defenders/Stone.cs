using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Defender))]

public class Stone : MonoBehaviour 
{
    private Animator anim;
    //private Defender defender;

    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();
        //defender = GetComponent<Defender>();

    }

    //OnTriggerEnter2D
    void OnTriggerStay2D(Collider2D collider)
    {
        // Attacker attacker = collider.gameObject.GetComponent<Attacker>();
        GameObject objectCollidedwith = collider.gameObject;

        if (!objectCollidedwith.GetComponent<Attacker>())
        {
            return; // leave method
        }
        //botsen met aanvaller -> DEFEND trigger

        anim.SetTrigger("underAttackTrigger");
           // defender.Defend(objectCollidedwith);
    }
}