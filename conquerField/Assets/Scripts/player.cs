using Mirror;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : NetworkBehaviour
{
    void HandleMovement()
    {
        if (isLocalPlayer)
        {
            float moveHorizontal = Input.GetAxis("Horizontal");
            float moveVertical = Input.GetAxis("Vertical");
            Vector3 movment = new Vector3(moveHorizontal, moveVertical, 0);
            transform.position = transform.position + movment;
        }
    }

    void Update()
    {
        HandleMovement();
    }
}
