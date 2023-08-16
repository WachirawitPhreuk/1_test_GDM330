using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5.0f;
    public GameManager gameManager;
    public GameObject Character;

    private void Update()
    {
        // Get keyboard input
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // Calculate movement direction
        Vector3 moveDirection = new Vector3(horizontalInput, 0.0f, verticalInput).normalized;

        // Move the player character
        transform.Translate(moveDirection * moveSpeed * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Dodgeball"))
        {
            gameManager.PlayerHit();
            Destroy(collision.gameObject);
        }
    }
}