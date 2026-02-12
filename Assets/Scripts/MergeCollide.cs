using System.Data;
using UnityEngine;

public class MergeCollide : MonoBehaviour
{
    public GameObject Boomifier;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "MergeB")
        {
            Debug.Log("Explosion");
            Instantiate(Boomifier, transform.position, transform.rotation);
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
    }
}
