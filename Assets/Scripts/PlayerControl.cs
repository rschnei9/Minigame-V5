using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float horizontalInput;
    private float speed = 7.0f;
    private float Xmin = 0.0f;
    private float Xmax = -7.5f;
    private float Ymin = -3.5f;
    private float Ymax = 3.5f;

    public Sprite [] Players;
    public GameObject [] Shots;

    public int Ship;

    // Update is called once per frame
    void Update()
    {
//Player movement translation
	horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

	horizontalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.up * horizontalInput * Time.deltaTime * speed);

//This is for the X border
        if (transform.position.x > Xmin) {
            transform.position = new Vector3(Xmin, transform.position.y);
        }
        
        if (transform.position.x < Xmax) {
            transform.position = new Vector3(Xmax, transform.position.y);
        }
//This is for the Y border
        if (transform.position.y < Ymin) {
            transform.position = new Vector3(transform.position.x, Ymin);
        }
        
        if (transform.position.y > Ymax) {
            transform.position = new Vector3(transform.position.x, Ymax);
        }
    
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Shoots something, yet to determine how it switches projectiles other -
            // - than it needing to switch sprites with a press of a key, allowing it to shoot different projectiles
            //Instantiate(projectilePrefab, transform.position,  projectilePrefab.transform.rotation);
        }

        

    }
}
