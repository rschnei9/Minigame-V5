using UnityEngine;

public class Rocket : MonoBehaviour
{
public float speed = 0.005f;

    // Update is called once per frame
    void Update()
    {
        transform.Translate (Vector3.right * speed * Time.deltaTime);
            speed += 0.15f;
    }
    void Start()
    {
        Destroy(gameObject,3.0f);
    }
}
