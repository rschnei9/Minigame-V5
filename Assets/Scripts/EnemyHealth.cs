using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int health = 75;

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
		Debug.Log("Zipped");
            Destroy(other.gameObject);
            Damage(7);
        }
if (other.CompareTag("MergeB"))

        {
		Debug.Log("Merged");
            Destroy(other.gameObject);
            Damage(5);
        }
if (other.CompareTag("Split"))

        {
		Debug.Log("Splid");
            Destroy(other.gameObject);
            Damage(8);
        }
if (other.CompareTag("Rocket"))

        {
		Debug.Log("Rocketed");
            Destroy(other.gameObject);
	int sdmg = (int)other.GetComponent<Rocket>().speed;
            Damage(sdmg);
        }
if (other.CompareTag("Boom"))

        {
		Debug.Log("Blam");
            Damage(25);
        }

if (other.CompareTag("Beam"))

        {
            Debug.Log("Beamed");
            Damage(50);
        }

if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
    
}
