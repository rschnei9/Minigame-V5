using System.Collections;
using UnityEngine;

public class HealSpawner : MonoBehaviour
{
    private bool spawn;
    public GameObject Healfab;
    void Update()
    {
        if (spawn == false)
        {
            StartCoroutine("Spawn");
        }
    }
    IEnumerator Spawn()
    {
        spawn = true;
        Instantiate(Healfab, transform.position + (Vector3.up * Random.Range(-4, 4)), transform.rotation);
        yield return new WaitForSeconds(Random.Range(5,15));
        spawn = false;
    }
}