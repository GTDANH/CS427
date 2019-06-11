using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public Vector2 Enemy2;
    public float speed = 20f;
    // Start is called before the first frame update
    void Start()
    {
        Enemy2 = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Rigidbody2D>().AddForce(new Vector2(-speed, 0));
    }
}
