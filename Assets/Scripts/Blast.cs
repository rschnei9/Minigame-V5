using UnityEngine;

public class Blast : MonoBehaviour
{
    private float speed = -15.0f;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * speed * Time.deltaTime);
    }
    void Start()
    {
        Destroy(gameObject, 3f);
    }

}