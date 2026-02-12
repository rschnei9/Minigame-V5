using UnityEngine;

public class Spinner : MonoBehaviour
{
private float speed = 25.0f;

    // Update is called once per frame
    void Update()
    {
        transform.Translate (Vector3.right * speed * Time.deltaTime);
        speed += -0.05f;
    }
    void Start()
    {
        Destroy(gameObject,1.0f);
    }
}
