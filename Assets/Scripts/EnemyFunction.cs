using UnityEngine;

public class EnemyFunction : MonoBehaviour
{
    public float horizontalInput;
    //private float speed = -4.0f;
    private float speed = -0.0f;
    //private float vspeed = 1.0f;
    private float vspeed = 0.0f;
    private float Xmin = 12.0f;
    private float Xmax = 7.0f;
    private float Ymin = -3.5f;
    private float Ymax = 3.5f;

    public int health = 50;

void Update()
    {
        //Player movement translation
        transform.Translate(Vector3.right * speed * Time.deltaTime);
        transform.Translate(Vector3.up * vspeed * Time.deltaTime);

        //This is for the X border
        if (transform.position.x > Xmin)
        {
            transform.position = new Vector3(Xmin, transform.position.y);
        }

        if (transform.position.x < Xmax)
        {
            transform.position = new Vector3(Xmax, transform.position.y);
        }
        //This is for the Y border
        if (transform.position.y < Ymin)
        {
            transform.position = new Vector3(transform.position.x, Ymin);
        }

        if (transform.position.y > Ymax)
        {
            transform.position = new Vector3(transform.position.x, Ymax);
        }
    }

}