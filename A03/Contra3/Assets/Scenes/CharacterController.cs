using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{

    public float speed = 1.0f;
    public float jumpspeed = 300f;
    public GameObject player;
    public bool check = true;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(-speed, 0));
            GetComponent<SpriteRenderer>().flipX = true;
            GetComponent<Animator>().SetTrigger("Run");
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(speed, 0));
            GetComponent<SpriteRenderer>().flipX = false;
            GetComponent<Animator>().SetTrigger("Run");
        }
        if (Input.GetKeyDown(KeyCode.UpArrow) && (check == true))
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jumpspeed));
            GetComponent<SpriteRenderer>().flipX = true;
            GetComponent<Animator>().SetTrigger("Jump");
            check = false;
        }
    }

  
    void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "Enemy")
        {
            player.SetActive(false);
        }
        if (collision.gameObject.tag == "Ground")
        {
            GetComponent<Animator>().SetTrigger("Idle");
            check = true;
        }
        Debug.Log(collision.gameObject.name);
    }   


}
