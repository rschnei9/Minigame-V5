using UnityEngine;

public class ZipMove : MonoBehaviour
{
private float speed = 25.0f;

    // Update is called once per frame
    void Update()
    {
        transform.Translate (Vector3.right * speed * Time.deltaTime);
    }
    void Start()
    {
       Destroy(gameObject,1.5f);
    }

}
