using System.Collections;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    private bool spawn;
    public float easy = 7f;
    public float hard = 3f;
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
        Instantiate(Enemyfab, transform.position + (Vector3.up * Random.Range(-4, 4)), transform.rotation);
        yield return new WaitForSeconds(Random.Range(hard,easy));
        if (easy >= 0.25f && hard >= 0.30f)
        {
            easy += -0.20f;
            hard += -0.10f;
        }
        spawn = false;
    }
}
