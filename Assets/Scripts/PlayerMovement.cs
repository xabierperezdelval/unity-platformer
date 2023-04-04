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

    }

    // Update is called once per frame
    void Update()
    {
        dirX = Input.GetAxis("Horizontal");
        dirY = Input.GetAxis("Vertical");
        playerRigidBody.velocity = new Vector2(dirX * 7f, playerRigidBody.velocity.y);

        if (Input.GetButtonDown("Jump"))
        {
            playerRigidBody.velocity = new Vector2(playerRigidBody.velocity.x, 7F);
        }
    }
}
