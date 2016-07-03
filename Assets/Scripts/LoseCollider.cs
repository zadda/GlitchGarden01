using UnityEngine;
using System.Collections;

public class LoseCollider : MonoBehaviour 
{
    private int loseCounter = 0;
    private LevelManager levelManager;

    void Start()
    {
        levelManager = GameObject.FindObjectOfType<LevelManager>();
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        loseCounter += 1;
        Destroy(collider.gameObject);
        if (loseCounter >= 6)
        {
            levelManager.LoadLevel("Lose");
        }
    }
}