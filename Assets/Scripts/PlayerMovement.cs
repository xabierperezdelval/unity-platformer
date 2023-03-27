using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D playerRigidBody;
    private float dirX, dirY;
    // Start is called before the first frame update
    void Start()
    {
        playerRigidBody = GetComponent<Rigidbody2D>();
        dirX = Input.GetAxis("Horizontal");
        dirY = Input.GetAxis("Vertical");
    }

    // Update is called once per frame
    void Update()
    {



        if (Input.GetButtonDown("Jump"))
        {
            playerRigidBody.velocity = new Vector3(0, 9F, 0);
        }
    }
}
