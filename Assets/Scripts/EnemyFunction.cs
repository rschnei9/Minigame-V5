using System.Collections;
using UnityEngine;

public class EnemyFunction : MonoBehaviour
{
    public float horizontalInput;
    //private float speed = -4.0f;
    private float speed = -4.0f;
    //private float vspeed = 1.0f;
    private float uspeed = 1.0f;
    private float Xmin = 12.0f;
    private float Xmax = 7.0f;
    private float Ymin = -3.5f;
    private float Ymax = 3.5f;
    private bool Ismoving;
    private bool Isfiring;
    public GameObject EnemyBlast;

    void Update()
    {
        //Enemy movement translation
        if (Isfiring == false)
        {
            StartCoroutine("Shoot");
        }
        if (Ismoving == false)
        {
            StartCoroutine("Movement", Random.Range(-1,2));
        }
        transform.Translate(Vector3.right * speed * Time.deltaTime);
        transform.Translate(Vector3.up * uspeed * Time.deltaTime);
        

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


    IEnumerator Shoot()
    {
        Isfiring = true;
        Instantiate(EnemyBlast, transform.position + Vector3.right, transform.rotation);
        yield return new WaitForSeconds(Random.Range(2, 6));
        Isfiring = false;
    }
    IEnumerator Movement(int Direction)
    {
        Ismoving = true;
        yield return new WaitForSeconds(Random.Range(3,8));
        uspeed = Direction;
        Ismoving = false;
    }
}