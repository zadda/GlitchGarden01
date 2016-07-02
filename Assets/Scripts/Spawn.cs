using UnityEngine;
using System.Collections;

public class Spawn : MonoBehaviour 
{
  
    public GameObject[] attackerPrefabArray;

   
	
	// Update is called once per frame
	void Update () 
	{
      
	    foreach(GameObject thisAttacker in attackerPrefabArray)
        {
            if (IsTimeToSpawn (thisAttacker))
            {
                SpawnEnemy(thisAttacker);
            }
        }
	}

    bool IsTimeToSpawn (GameObject attackerGameObject)
    {
        Attacker attacker = attackerGameObject.GetComponent<Attacker>();

        float meanSpawnDelay = attacker.seenEverySeconds;
        float spawnsPerSecond = 1 / meanSpawnDelay;

        if (Time.deltaTime > meanSpawnDelay)
        {
            Debug.LogWarning("Spwan rate capped by frame rate");
        }
        float treshold = spawnsPerSecond * Time.deltaTime/2;

        //return (Random.value < treshold);

        if (Random.value < treshold)
        {
            return true;
        }
        else
        {
            return false;
        }

    }

    void SpawnEnemy(GameObject myGameObject)
    {
        GameObject myAttacker = Instantiate(myGameObject) as GameObject;
        myAttacker.transform.parent = transform;
        myAttacker.transform.position = transform.position;
    }
}