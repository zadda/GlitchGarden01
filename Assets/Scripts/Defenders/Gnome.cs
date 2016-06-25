using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Defender))]

public class Gnome : MonoBehaviour 
{
    private Animator anim;
    private Defender defender;

    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();
        defender = GetComponent<Defender>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        GameObject objectCollidedwith = collider.gameObject;

        if (!objectCollidedwith.GetComponent<Attacker>())
        {
            return; // leave method
        }
        //botsen met andere aanvaller -> DEFEND
       
            anim.SetBool("isDefending", true);
            defender.Defend(objectCollidedwith);
    }
}