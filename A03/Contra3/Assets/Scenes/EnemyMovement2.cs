using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement2 : MonoBehaviour
{
    public Vector2 Enemy1;
    public float speed = 20.0f;
    // Start is called before the first frame update
    void Start()
    {
        Enemy1 = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Rigidbody2D>().AddForce(new Vector2(speed, 0));
    }
}
