using System.Collections;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float horizontalInput;
    private float speed = 7.5f;
    private float Xmin = 0.0f;
    private float Xmax = -7.5f;
    private float Ymin = -3.5f;
    private float Ymax = 3.5f;

    public SpriteRenderer sr;
    public SpriteRenderer charge;

    public Sprite on;
    public Sprite off;

    public Sprite [] Players;
    public GameObject [] Shots;
    public float[] Cooldowns;
    public bool[] Activator;
    public bool[] Weaponlock;

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
            if (ship > 4)
            {
                ship = 0;
            }
        }
        if (Input.GetKeyDown(KeyCode.J))
        {
            ship -= 1;
            if (ship < 0)
            {
                ship = 4;
            }
        }
        sr.sprite = Players[ship];

        //This section has IF tatements for each projectile 
        if (Input.GetKeyDown(KeyCode.K))
        {
            if (ship == 0 && Activator[0])
                //Checking if Activator is 0 or true
            {
                Instantiate(Shots[ship], transform.position + (Vector3.right * 19), transform.rotation, transform);
                StartCoroutine("CooldownBeam");

            }
            if (ship == 1 && Activator[1])
            {
                Instantiate(Shots[ship], transform.position + Vector3.right, transform.rotation);
                StartCoroutine("CooldownZip");
            }
            if (ship == 2 && Activator[2])
            {
                Instantiate(Shots[ship], transform.position + Vector3.right, transform.rotation);
                StartCoroutine("CooldownRocket");
            }
            if (ship == 3 && Activator[3])
            {
                StartCoroutine("ThreeSplit");
                StartCoroutine("CooldownSplit");
            }
            if (ship == 4 && Activator[4])
            {
                Instantiate(Shots[ship], transform.position + Vector3.right, transform.rotation);
                StartCoroutine("CooldownMerge");
            }

        }
        // Below this is the COOLDOWN Code, for each individual projectile
    }
    IEnumerator CooldownBeam()
    {
        Activator[0] = false;
        //Changes the sprite for the beam, disabling it for the time being
        charge.sprite = off;
        yield return new WaitForSeconds(Cooldowns[0]);
        charge.sprite = on;
        Activator[0] = true;
    }
    IEnumerator CooldownZip()
    {
        Activator[1] = false;
        yield return new WaitForSeconds(Cooldowns[1]);
        Activator[1] = true;
    }
    IEnumerator CooldownRocket()
    {
        Activator[2] = false;
        yield return new WaitForSeconds(Cooldowns[2]);
        Activator[2] = true;
    }
    IEnumerator CooldownSplit()
    {
        Activator[3] = false;
        yield return new WaitForSeconds(Cooldowns[3]);
        Activator[3] = true;
    }
    IEnumerator CooldownMerge()
    {
        Activator[4] = false;
        yield return new WaitForSeconds(Cooldowns[4]);
        Activator[4] = true;
    }



    IEnumerator ThreeSplit()
    {
        Instantiate(Shots[3], transform.position + Vector3.right, transform.rotation);
        yield return new WaitForSeconds(0.1f);
        Instantiate(Shots[3], transform.position + Vector3.right, transform.rotation);
        yield return new WaitForSeconds(0.1f);
        Instantiate(Shots[3], transform.position + Vector3.right, transform.rotation);
    }
}
