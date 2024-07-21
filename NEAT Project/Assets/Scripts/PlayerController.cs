using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [HideInInspector]
    public Rigidbody2D rb;
    Collider2D col;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        col = GetComponent<Collider2D>();
    }
    public void Jump()
    {
        if (Physics2D.Raycast(col.bounds.center, Vector2.down, col.bounds.extents.y+ 0.1f))
        {
            rb.velocity = new Vector2(rb.velocity.x, 5);
        }
    }
    public void MoveRight()
    {
        rb.velocity = new Vector2(3, rb.velocity.y);
        
    }
    public void MoveLeft()
    {
        rb.velocity = new Vector2(-3, rb.velocity.y);
    }
}
