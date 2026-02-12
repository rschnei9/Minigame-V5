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

        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
    
}
