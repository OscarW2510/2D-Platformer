using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchingGravity : MonoBehaviour
{
    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            rb.gravityScale *= -1;
        }
    }
}
