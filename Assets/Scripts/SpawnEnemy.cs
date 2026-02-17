using System.Collections;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    private bool spawn;
    public GameObject Enemyfab;
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
        Instantiate(Enemyfab, transform.position + Vector3.right, transform.rotation);
        yield return new WaitForSeconds(Random.Range(1,5));
        spawn = false;
    }
}
