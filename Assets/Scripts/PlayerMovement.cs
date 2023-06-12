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
    public static Rigidbody2D rb;
    public float minY = -10f;
    public Transform respawnPoint;
    public float JumpTime = 0.5f;
    private float NextJump = 0.0f;
    //--------------------------
    public float PistolTepme = 5.0f;
    public float AssaultTepme;
    public float SniperTepme;
    public float SmgTepme;
    public float MinigunTepme;
    public float shotgunTepme;
    //-------------------------
    private float NextFire = 0.0f;
    private float pistoltep = 0.3f;
    private float shotguntep = 1.0f;
    private float snipertep = 1.5f;
    private void Start()
    {
        NextFire = Time.time;
        NextJump = Time.time;
        isFacingRight = true;
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
    float moveX = 0f;

    if (Input.GetKey(KeyCode.RightArrow))
    {
        moveX = moveSpeed;
    }
    else if (Input.GetKey(KeyCode.LeftArrow))
    {
        moveX = -moveSpeed;
    }

    rb.velocity = new Vector2(moveX, rb.velocity.y);

    if (!Input.GetKey(KeyCode.RightArrow) && !Input.GetKey(KeyCode.LeftArrow))
    {
        rb.velocity = new Vector2(0f, rb.velocity.y);
    }

        if (moveX > 0 && !isFacingRight)
        {
            Flip();
        }
        else if (moveX < 0 && isFacingRight)
        {
            Flip();
        }
        

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            if (jumpCount < maxJumpCount)
            {
                NextJump = Time.time + JumpTime;
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
            Guns.bulletcount = 0;
        }
        else if (other.CompareTag("Sniper"))
        {
            Debug.Log("SN�PER");
            Destroy(other.gameObject);
            Guns.Pistol = false;
            Guns.Shotgun = false;
            Guns.Sniper = true;
            Guns.Assault = false;
            Guns.Smg = false;
            Guns.Minigun = false;
            Guns.bulletcount = 0;
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
            Guns.bulletcount = 0;
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
            Guns.bulletcount = 0;
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
            Guns.bulletcount = 0;
        }
    }
    private void RespawnPlayer()
    {

        transform.position = respawnPoint.position;
        transform.rotation = respawnPoint.rotation;
    }
}
