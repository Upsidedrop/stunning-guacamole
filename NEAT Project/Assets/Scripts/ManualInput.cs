using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManualInput : MonoBehaviour
{
    PlayerController controller;
    private void Awake()
    {
        controller = GetComponent<PlayerController>();
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Jump") > 0)
        {
            controller.Jump();
        }
        if (Input.GetAxis("Horizontal")> 0)
        {
            controller.MoveRight();
        }
        else if(Input.GetAxis("Horizontal") < 0)
        {
            controller.MoveLeft();
        }
        else
        {
            controller.rb.velocity = new Vector2(0, controller.rb.velocity.y);
        }
    }
}
