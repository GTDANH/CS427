using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board : MonoBehaviour
{
    public GameObject myPrefab;
    float width = 20;
    float height = 20;
    // Start is called before the first frame update
    void Start()
    {
        for (int x = 0; x <= width; x++)
        {
            for (int y = 0; y <= height; y++)
            {
               Instantiate(myPrefab, new Vector2(x, y), Quaternion.identity);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
