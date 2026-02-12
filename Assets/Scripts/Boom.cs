using UnityEngine;
using UnityEngine.UIElements;

public class Boom : MonoBehaviour
{
    private float rotate = -400.0f;
    void Update()
    {
        transform.Rotate(Vector3.forward * rotate * Time.deltaTime);
    }
    void Start()
    {
        Destroy(gameObject, 1.5f);
    }
}
