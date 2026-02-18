using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int health = 7;
    public SpriteRenderer[] hearts;
    public Sprite red;
    public Sprite black;
    public void Damage(int damage)
    {
        health -= damage;
        for (int i = 0; i < hearts.Length; i++)
        {
            hearts[i].sprite = black;
        }
        for (int i = 0; i < health; i++)
        {
            hearts[i].sprite = red;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Blast"))
        {
            Destroy(collision.gameObject);
            Debug.Log("Youch");
            Damage(1);
        }

        if (collision.CompareTag("Heal") && health <= 6)
        {
            Destroy(collision.gameObject);
            Debug.Log("TYay");
            Damage(-1);
        }

        if (health <= 0)
        {
            Debug.Log("Game Over");
        }
    }
}
