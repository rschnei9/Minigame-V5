using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject[] Space;
    private float startDelay = 0;
    private float spawnInterval = 6f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created

    // Update is called once per frame
    void Update()
     {

     }
void Start () {
    InvokeRepeating("Spacer", startDelay, spawnInterval);
}

 void Spacer()
     {
        int Ranged = Random.Range(0, Space.Length);
           Vector3 spawnPos = new Vector3(19.5f, 0, 0);

           Instantiate(Space[Ranged], spawnPos, Space[Ranged].transform.rotation);
}
}