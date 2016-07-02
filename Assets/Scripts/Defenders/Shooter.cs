using UnityEngine;
using System.Collections;

public class Shooter : MonoBehaviour 
{
    public GameObject projectile, gun;

    private GameObject projectileParent;
    private Animator anim;
    private Spawn myLaneSpawner;
    

    void Start()
    {
        anim = GameObject.FindObjectOfType<Animator>();
        //myLaneSpawner = GameObject.FindObjectOfType<Spawn>();

        // create a parent gameobject in Hierarchy
        projectileParent = GameObject.Find("Projectiles");

        if (!projectileParent)
        {
            projectileParent = new GameObject("Projectiles");
        }

        SetMyLaneSpawner(); // initialize to false
        //Debug.Log(myLaneSpawner + "defender en enemy in lane");
    }

    void Update()
    {
        if (IsAttackerAhead())
        {
            anim.SetBool("isDefending", true);
        }
        else
        {
            anim.SetBool("isDefending", false);
        }
    }

    void SetMyLaneSpawner()
    {
        Spawn[] spawnerArray = GameObject.FindObjectsOfType<Spawn>();
        foreach (Spawn spawner in spawnerArray)
        {
            if (spawner.transform.position.y == transform.position.y)
            {
                myLaneSpawner = spawner;
                return;
            }
        }
        //Debug.LogError(name + "no spawner in lane");
    }

    bool IsAttackerAhead()
    {
        // Exti if no attackers in lane

        if (myLaneSpawner.transform.childCount <= 0)
        {
            return false;
        }
        // we find an attacker in our lane, are they in front of us
        foreach (Transform childAttacker in myLaneSpawner.transform)
        {
            if (childAttacker.transform.position.x > transform.position.x)
            {
                return true;
            }
        }
        // attackers in lane, but not in front of us
        return false;
        
    }

    private void Fire()
    {
        GameObject newProjectile = Instantiate(projectile) as GameObject;
        newProjectile.transform.parent = projectileParent.transform;
        newProjectile.transform.position = gun.transform.position;
    }

}