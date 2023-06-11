using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Minigun : MonoBehaviour
{
    public float MinigunFireRate = 0.05f;
    private float NextFire = 0.0f;
    public GameObject Bulletprefab2;
    public AudioClip MinigunSound;
    private AudioSource audiosource;
    // Start is called before the first frame update
    void Start()
    {
        audiosource = GetComponent<AudioSource>();
        NextFire = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Z) && Time.time > NextFire)
        {
            if (Guns.Minigun == true)
            {

                NextFire = Time.time + MinigunFireRate;
                Instantiate(Bulletprefab2, transform.position, Bulletprefab2.transform.rotation);
                Fire();
                Guns.bulletcount++;
                if (Guns.bulletcount >= 100)
                {
                    Guns.Minigun = false;
                    Guns.Pistol = true;
                    Guns.bulletcount = 0;
                }
            }
        }
    }
    private void Fire()
    {
        audiosource.PlayOneShot(MinigunSound);

    }
}
