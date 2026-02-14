using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float horizontalInput;
    private float speed = 7.0f;
    private float Xmin = 0.0f;
    private float Xmax = -7.5f;
    private float Ymin = -3.5f;
    private float Ymax = 3.5f;

    public SpriteRenderer sr;

    public Sprite [] Players;
    public GameObject [] Shots;

    public int ship;

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
        if (Input.GetKeyDown(KeyCode.L))
        {
            ship += 1;
            if (ship < 0)
            {
                ship = 4;
            }
        }
        if (Input.GetKeyDown(KeyCode.J))
        {
            ship -= 1;
            if (ship > 4)
            {
                ship = 0;
            }
        }
        sr.sprite = Players[ship];

    //THIS SECTION NEEDS TO HAVE IF/ELSE statements for each projectile having DIFFERENT RATES OF FIRE
        if (Input.GetKeyDown(KeyCode.K))
        {
            if (ship == 0)
            //I want the white beam to follow the nose of the ship while it moves before despawning

            //I also want to add a recharge script for the white electric icon that allows this to be fired once every 30 seconds.
            //It acts as an indicator for when the charge beam is ready. Its on by default and only gets disabled after a use.
            Instantiate(Shots[ship],transform.position+Vector3.right, transform.rotation);


            else if (ship == 3)
            //I want the split to shoot in a burst of 3 quick shots
            Instantiate(Shots[ship],transform.position+Vector3.right, transform.rotation);
            //Instantiate(Shots[ship],transform.position+Vector3.right, transform.rotation);
            //Instantiate(Shots[ship],transform.position+Vector3.right, transform.rotation);

            
            else
            {
            Instantiate(Shots[ship],transform.position+Vector3.right, transform.rotation);
            }
        }

        

    }
}
