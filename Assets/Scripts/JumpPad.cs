using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPad : MonoBehaviour
{
    [SerializeField] float upwardBounce = 10f;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {

            Rigidbody playerRigidbody = other.gameObject.GetComponent<Rigidbody>();

            if (playerRigidbody != null)
            {

                playerRigidbody.velocity = new Vector3(0, upwardBounce, 0);
            }
        }
    }
}
