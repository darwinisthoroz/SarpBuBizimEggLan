using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.ParticleSystem;

public class BulletMovement : MonoBehaviour
{
    public float geritepme = 10.0f;
    public float bulletspeed = 30.0f;
    public bool isFacingRight;
    public float PistolPush = 2.0f;
    public float AssaultPush;
    public float SniperPush = 15.0f;
    public float SmgPush;
    public float MinigunPush;
    public float shotgunpush;
    public float burstpush;
    private float lifetime = 1.5f;
    private Vector2 direction;
    private PlayerMovement playerMovement;
    private Guns guns;
    public ParticleSystem Kan;
    // Start is called before the first frame update
    void Start()
    {
        Kan = GetComponent<ParticleSystem>();
        Invoke("DestroyBullet", lifetime);
        if(PlayerMovement.isFacingRight)
        {
            direction = Vector2.right;
        }
        else
        {
            direction = Vector2.left;
        }
    }

    // Update is called once per frame
    private void Update()
    {

        transform.Translate(direction * bulletspeed * Time.deltaTime);

    }
     private void OnTriggerEnter2D(Collider2D other)
     {
       if(other.gameObject.CompareTag("Player"))
         {
            Destroy(this.gameObject);
            if (Guns.Pistol)
            {
                Rigidbody2D rb = other.GetComponent<Rigidbody2D>();
                Vector2 awayFromBullet = other.transform.position - transform.position;
                rb.AddForce(awayFromBullet * PistolPush, ForceMode2D.Impulse);
            }
           
            if (Guns.Sniper)
            {
                Rigidbody2D rb = other.GetComponent<Rigidbody2D>();
                Vector2 awayFromBullet = other.transform.position - transform.position;
                rb.AddForce(awayFromBullet * SniperPush, ForceMode2D.Impulse);
            }
            if (Guns.Assault)
            {
                Rigidbody2D rb = other.GetComponent<Rigidbody2D>();
                Vector2 awayFromBullet = other.transform.position - transform.position;
                rb.AddForce(awayFromBullet * AssaultPush, ForceMode2D.Impulse);
            }
            if (Guns.Smg)
            {
                Rigidbody2D rb = other.GetComponent<Rigidbody2D>();
                Vector2 awayFromBullet = other.transform.position - transform.position;
                rb.AddForce(awayFromBullet * SmgPush, ForceMode2D.Impulse);
            }
            if (Guns.Minigun)
            {
                Rigidbody2D rb = other.GetComponent<Rigidbody2D>();
                Vector2 awayFromBullet = other.transform.position - transform.position;
                rb.AddForce(awayFromBullet * MinigunPush, ForceMode2D.Impulse);
            }
            
            if (Guns.Shotgun)
            {
                Rigidbody2D rb = other.GetComponent<Rigidbody2D>();
                Vector2 awayFromBullet = other.transform.position - transform.position;
                rb.AddForce(awayFromBullet * shotgunpush, ForceMode2D.Impulse);
            }
            
        }
     }
    void DestroyBullet()
    {
       
        Destroy(gameObject);
    }
}
