using UnityEngine;

public class Background : MonoBehaviour
{
private float speed = -3.0f;
    void Update()
    {
        transform.Translate(Vector3.right * speed * Time.deltaTime);
    }
    void Start()
    {
        Destroy(gameObject, 12.2f);
    }
}
