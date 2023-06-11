using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.ParticleSystem;

public class PlayerMovement : MonoBehaviour
{

    public float moveSpeed = 5f;
    public float jumpForce = 5f;
    public int maxJumpCount = 2;
    public static bool isFacingRight = true;
    private int jumpCount = 0;
    private Rigidbody2D rb;
    public float minY = -10f;
    public Transform respawnPoint;
    private void Start()
    {
        isFacingRight = true;
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        if (moveX > 0 && !isFacingRight)
        {
            Flip();
        }
        else if (moveX < 0 && isFacingRight)
        {
            Flip();
        }

        Vector2 movement = new Vector2(moveX * moveSpeed, rb.velocity.y);
        rb.velocity = movement;

        if (Input.GetButtonDown("Jump"))
        {
            if (jumpCount < maxJumpCount)
            {
                rb.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
                jumpCount++;
            }
        }
        if (transform.position.y < minY)
        {
            RespawnPlayer();
            PlayerMovement.isFacingRight = true;
            Guns.Pistol = true;
            Guns.Shotgun = false;
            Guns.Sniper = false;
            Guns.Assault = false;
            Guns.Smg = false;
            Guns.Minigun = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            jumpCount = 0;
        }
    }

    private void Flip()
    {
        isFacingRight = !isFacingRight;
        transform.Rotate(0f, 180f, 0f);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Shoutgun"))
        {
            Debug.Log("SHOTGUN");
            Destroy(other.gameObject);
            Guns.Pistol = false;
            Guns.Shotgun = true;
            Guns.Sniper = false;
            Guns.Assault = false;
            Guns.Smg = false;
            Guns.Minigun = false;
        }
        else if (other.CompareTag("Sniper"))
        {
            Debug.Log("SNÝPER");
            Destroy(other.gameObject);
            Guns.Pistol = false;
            Guns.Shotgun = false;
            Guns.Sniper = true;
            Guns.Assault = false;
            Guns.Smg = false;
            Guns.Minigun = false;
        }
        else if (other.CompareTag("Assault"))
        {
            Debug.Log("ASSAULT");
            Destroy(other.gameObject);
            Guns.Pistol = false;
            Guns.Shotgun = false;
            Guns.Sniper = false;
            Guns.Assault = true;
            Guns.Smg = false;
            Guns.Minigun = false;
        }
        else if (other.CompareTag("Smg"))
        {
            Debug.Log("SUBMACHINE");
            Destroy(other.gameObject);
            Guns.Pistol = false;
            Guns.Shotgun = false;
            Guns.Sniper = false;
            Guns.Assault = false;
            Guns.Smg = true;
            Guns.Minigun = false;
        }
        else if (other.CompareTag("Minigun"))
        {
            Debug.Log("MINIGUN");
            Destroy(other.gameObject);
            Guns.Pistol = false;
            Guns.Shotgun = false;
            Guns.Sniper = false;
            Guns.Assault = false;
            Guns.Smg = false;
            Guns.Minigun = true;
        }
    }
    private void RespawnPlayer()
    {

        transform.position = respawnPoint.position;
        transform.rotation = respawnPoint.rotation;
    }
}
