using UnityEngine;

public class MergeB : MonoBehaviour
{
private float speed = 5.0f;
private float rotate = 120.0f;

    // Update is called once per frame
    void FixedUpdate()
    {
        //Note: The spinning cosmetic is needed for this sprite too!
        transform.Translate (Vector3.right * speed * Time.deltaTime);
        //transform.Translate (Vector3.up * rise * Time.deltaTime);
        transform.Rotate(Vector3.forward * rotate * Time.deltaTime);
        speed += 0.05f;
        // Once it RISES, it needs to switch to FALL so it can collide with an inverted merge

        //A second script with inverse rise/fall functions, as well as a clone of the original merge object will likely be required
    }
    void Start()
    {
       Destroy(gameObject,2.25f);
    }

}
