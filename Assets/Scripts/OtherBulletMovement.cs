using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.ParticleSystem;

public class OtherBulletMovement : MonoBehaviour
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
    public float PistolPush2 = 2.0f;
    public float AssaultPush2;
    public float SniperPush2 = 15.0f;
    public float SmgPush2;
    public float MinigunPush2;
    public float shotgunpush2;
    public float burstpush;
    public float ypush;
    private float lifetime = 1.5f;
    private Vector2 direction;
    private OtherPlayer playerMovement;
    private OtherGuns guns;
    public ParticleSystem Kan;
    // Start is called before the first frame update
    void Start()
    {
        Kan = GetComponent<ParticleSystem>();
        Invoke("DestroyBullet", lifetime);
        if (OtherPlayer.isFacingRight)
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
        if (other.gameObject.CompareTag("Player1"))
        {
            Destroy(this.gameObject);
            other.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, ypush), ForceMode2D.Impulse);
            if (OtherGuns.Pistol)
            {
                Rigidbody2D rb = other.GetComponent<Rigidbody2D>();
                Vector2 awayFromBullet = other.transform.position - transform.position;
                rb.AddForce(awayFromBullet * PistolPush, ForceMode2D.Impulse);
            }

            if (OtherGuns.Sniper)
            {
                Rigidbody2D rb = other.GetComponent<Rigidbody2D>();
                Vector2 awayFromBullet = other.transform.position - transform.position;
                rb.AddForce(awayFromBullet * SniperPush, ForceMode2D.Impulse);
            }
            if (OtherGuns.Assault)
            {
                Rigidbody2D rb = other.GetComponent<Rigidbody2D>();
                Vector2 awayFromBullet = other.transform.position - transform.position;
                rb.AddForce(awayFromBullet * AssaultPush, ForceMode2D.Impulse);
            }
            if (OtherGuns.Smg)
            {
                Rigidbody2D rb = other.GetComponent<Rigidbody2D>();
                Vector2 awayFromBullet = other.transform.position - transform.position;
                rb.AddForce(awayFromBullet * SmgPush, ForceMode2D.Impulse);
            }
            if (OtherGuns.Minigun)
            {
                Rigidbody2D rb = other.GetComponent<Rigidbody2D>();
                Vector2 awayFromBullet = other.transform.position - transform.position;
                rb.AddForce(awayFromBullet * MinigunPush, ForceMode2D.Impulse);
            }

            if (OtherGuns.Shotgun)
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
