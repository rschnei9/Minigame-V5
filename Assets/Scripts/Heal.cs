using UnityEngine;

public class Heal : MonoBehaviour
{
    private float speed = -7.0f;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * speed * Time.deltaTime);
    }
    void Start()
    {
        Destroy(gameObject, 6f);
    }

}