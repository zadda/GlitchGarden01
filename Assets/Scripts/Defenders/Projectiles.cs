using UnityEngine;
using System.Collections;

public class Projectiles : MonoBehaviour 
{

    public float speed, damage;
    
	
	// Update is called once per frame
	void Update () 
	{
        transform.Translate(Vector3.right * speed * Time.deltaTime);
	}
}