using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int health = 50;

    public void Damage(int edamage)
    {
Debug.Log("CheckEDAMAGE");
	health -= edamage;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
Debug.Log("Zip");
        if (other.CompareTag("Zip"))

        {
		Debug.Log("Enemyharm");
            Destroy(other.gameObject);
            Damage(10);
        }
if (other.CompareTag("MergeB"))

        {
		Debug.Log("Enemyharm");
            Destroy(other.gameObject);
            Damage(5);
        }
if (other.CompareTag("Split"))

        {
		Debug.Log("Enemyharm");
            Destroy(other.gameObject);
            Damage(7);
        }
if (other.CompareTag("Rocket"))

        {
		Debug.Log("Enemyharm");
            Destroy(other.gameObject);
	int sdmg = (int)other.GetComponent<"Rocket">().speed;
            Damage(sdmg);
        }
if (other.CompareTag("Boom"))

        {
		Debug.Log("Enemyharm");
            Destroy(other.gameObject);
            Damage(10);
        }

        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
    
}
