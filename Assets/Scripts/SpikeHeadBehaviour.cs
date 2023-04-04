using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeHeadBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        if (transform.position.y <= -12F)
        {
            rb.AddForce(Vector2.up);
        }

        else
        {
            rb.AddForce(Vector2.down);
        }

    }
}
