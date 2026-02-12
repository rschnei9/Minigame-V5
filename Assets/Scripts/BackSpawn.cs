using UnityEngine;

public class BackSpawn : MonoBehaviour
{
    private float spawnPosX = 19;
    private float spawnInterval = 15f;
    
    void Start()
    {
        //I need this script to summon a background using "spawnInterval" as a timer
        //Call InvokeRepeating = "SpawnBack"; spawnInterval;
    }

    // Update is called once per frame
    void SpawnBack()
    {
        Vector3 spawnPosX = new Vector3(19, 0, 0);
        Instantiate(gameObject);
    }
}
