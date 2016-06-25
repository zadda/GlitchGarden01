using UnityEngine;
using System.Collections;

//zorgt dat er altijd een attacker script aan Fox gelinkt is

[RequireComponent(typeof(Attacker))]

public class Lizard : MonoBehaviour
{

    private Animator animLizard;
    private Attacker attacker;

    // Use this for initialization
    void Start()
    {
        animLizard = GetComponent<Animator>();
        attacker = GetComponent<Attacker>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        GameObject objectCollidedwith = collider.gameObject;

        if (!objectCollidedwith.GetComponent<Defender>())
        {
            return; // leave method
        }
            animLizard.SetBool("isAttacking", true);
            attacker.Attack(objectCollidedwith);
    }
}