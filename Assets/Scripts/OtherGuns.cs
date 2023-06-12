using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class OtherGuns : MonoBehaviour
{
    public static bool Pistol = true;
    public static bool Shotgun = false;
    public static bool Sniper = false;
    public static bool Assault = false;
    public static bool Smg = false;
    public static bool Minigun = false;
    public static bool Burst = false;
    public static bool Pistol2 = true;
    public static bool Shotgun2 = false;
    public static bool Sniper2 = false;
    public static bool Assault2 = false;
    public static bool Smg2 = false;
    public static bool Minigun2 = false;
    public static bool Burst2 = false;
    //--------------------------------
    private AudioSource audioSource;
    public AudioClip pistolFireSound;
    public AudioClip shotgunFireSound;
    public AudioClip sniperFireSound;
    public AudioClip assaultFireSound;
    public AudioClip smgFireSound;
    public AudioClip minigunFireSound;
    //--------------------------------
    public GameObject Bulletprefab;
    public GameObject[] Bulletprefab_Shotgun = new GameObject[3];
    //--------------------------------
    public float PistolFireRate = 0.1f;
    public float SniperFireRate = 1.5f;
    public float ShotgunFireRate = 1.0f;
    public float AssaultFireRate = 0.8f;
    public float SmgFireRate = 0.5f;
    public float MinigunFireRate = 5f;
    private float NextFire = 0.0f;
    //*********----------------------*****
    public static int bulletcount;



    // Start is called before the first frame update
    void Start()
    {

        Pistol = true;
        Shotgun = false;
        Sniper = false;
        Assault = false;
        Smg = false;
        Minigun = false;
        Burst = false;
        audioSource = GetComponent<AudioSource>();
        NextFire = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T) && Time.time > NextFire)
        {

            if (Pistol)
            {

                NextFire = Time.time + PistolFireRate;
                Instantiate(Bulletprefab, transform.position, Bulletprefab.transform.rotation);
                Fire();

            }
            else if (Shotgun)
            {

                NextFire = Time.time + ShotgunFireRate;
                Instantiate(Bulletprefab_Shotgun[0], transform.position, Bulletprefab_Shotgun[0].transform.rotation);
                Instantiate(Bulletprefab_Shotgun[1], transform.position, Bulletprefab_Shotgun[1].transform.rotation);
                Instantiate(Bulletprefab_Shotgun[2], transform.position, Bulletprefab_Shotgun[2].transform.rotation);
                bulletcount++;
                Fire();
                if (bulletcount >= 16)
                {
                    Shotgun = false;
                    Pistol = true;
                    bulletcount = 0;
                }
            }
            else if (Sniper == true)
            {

                NextFire = Time.time + SniperFireRate;
                Instantiate(Bulletprefab, transform.position, Bulletprefab.transform.rotation);
                bulletcount++;
                Fire();
                if (bulletcount >= 10)
                {
                    Sniper = false;
                    Pistol = true;
                    bulletcount = 0;
                }
            }
        }
        if (Input.GetKey(KeyCode.T) && Time.time > NextFire)
        {
            if (Assault == true)
            {

                Instantiate(Bulletprefab, transform.position, Bulletprefab.transform.rotation);
                bulletcount++;
                NextFire = Time.time + AssaultFireRate;
                Fire();
                if (bulletcount >= 60)
                {
                    Assault = false;
                    Pistol = true;
                    bulletcount = 0;
                }
            }
            else if (Smg == true)
            {

                NextFire = Time.time + SmgFireRate;
                Instantiate(Bulletprefab, transform.position, Bulletprefab.transform.rotation);
                bulletcount++;
                Fire();
                if (bulletcount >= 80)
                {
                    Smg = false;
                    Pistol = true;
                    bulletcount = 0;
                }
            }

            //------------------------------------------------------------------------------
            if (Input.GetKeyDown(KeyCode.P) && Time.time > NextFire)
            {

                if (Pistol2)
                {

                    NextFire = Time.time + PistolFireRate;
                    Instantiate(Bulletprefab, transform.position, Bulletprefab.transform.rotation);
                    Fire();

                }
                else if (Shotgun2)
                {

                    NextFire = Time.time + ShotgunFireRate;
                    Instantiate(Bulletprefab_Shotgun[0], transform.position, Bulletprefab_Shotgun[0].transform.rotation);
                    Instantiate(Bulletprefab_Shotgun[1], transform.position, Bulletprefab_Shotgun[1].transform.rotation);
                    Instantiate(Bulletprefab_Shotgun[2], transform.position, Bulletprefab_Shotgun[2].transform.rotation);
                    bulletcount++;
                    Fire();
                    if (bulletcount >= 16)
                    {
                        Shotgun = false;
                        Pistol = true;
                        bulletcount = 0;
                    }
                }
                else if (Sniper2 == true)
                {

                    NextFire = Time.time + SniperFireRate;
                    Instantiate(Bulletprefab, transform.position, Bulletprefab.transform.rotation);
                    bulletcount++;
                    Fire();
                    if (bulletcount >= 10)
                    {
                        Sniper = false;
                        Pistol = true;
                        bulletcount = 0;
                    }
                }
            }
            if (Input.GetKey(KeyCode.P) && Time.time > NextFire)
            {
                if (Assault2 == true)
                {

                    Instantiate(Bulletprefab, transform.position, Bulletprefab.transform.rotation);
                    bulletcount++;
                    NextFire = Time.time + AssaultFireRate;
                    Fire();
                    if (bulletcount >= 60)
                    {
                        Assault = false;
                        Pistol = true;
                        bulletcount = 0;
                    }
                }
                else if (Smg2 == true)
                {

                    NextFire = Time.time + SmgFireRate;
                    Instantiate(Bulletprefab, transform.position, Bulletprefab.transform.rotation);
                    bulletcount++;
                    Fire();
                    if (bulletcount >= 80)
                    {
                        Smg = false;
                        Pistol = true;
                        bulletcount = 0;
                    }
                }

                /* else if (Minigun == true)
                 {

                     NextFire = Time.time + MinigunFireRate;
                     Instantiate(Bulletprefab, transform.position, Bulletprefab.transform.rotation);
                 }
                */
            }
            // BURASI DENEME AMAÇLI , ONLÝNE GEÇERKEN SÝL //
            //----------------------------------------------
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                Pistol = true;

                Shotgun = false;
                Sniper = false;
                Assault = false;
                Smg = false;
                Minigun = false;
                Burst = false;
            }
            if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                Shotgun = true;
                Pistol = false;

                Sniper = false;
                Assault = false;
                Smg = false;
                Minigun = false;
                Burst = false;
            }
            if (Input.GetKeyDown(KeyCode.Alpha3))
            {
                Sniper = true;
                Pistol = false;
                Shotgun = false;

                Assault = false;
                Smg = false;
                Minigun = false;
                Burst = false;
            }
            if (Input.GetKeyDown(KeyCode.Alpha4))
            {
                Assault = true;
                Pistol = false;
                Shotgun = false;
                Sniper = false;

                Smg = false;
                Minigun = false;
                Burst = false;
            }
            if (Input.GetKeyDown(KeyCode.Alpha5))
            {
                Smg = true;
                Pistol = false;
                Shotgun = false;
                Sniper = false;
                Assault = false;

                Minigun = false;
                Burst = false;
            }
            if (Input.GetKeyDown(KeyCode.Alpha6))
            {
                Minigun = true;
                Pistol = false;
                Shotgun = false;
                Sniper = false;
                Assault = false;
                Smg = false;

                Burst = false;
            }
            if (Input.GetKeyDown(KeyCode.Alpha7))
            {
                Burst = true;
                Pistol = false;
                Shotgun = false;
                Sniper = false;
                Assault = false;
                Smg = false;
                Minigun = false;

            }
            //----------------------------------------------  
        }

        void Fire()
        {
            if (Pistol)
            {
                audioSource.PlayOneShot(pistolFireSound);
            }
            else if (Shotgun)
            {
                audioSource.PlayOneShot(shotgunFireSound);
            }
            else if (Sniper)
            {
                audioSource.PlayOneShot(sniperFireSound);
            }
            else if (Assault)
            {
                audioSource.PlayOneShot(assaultFireSound);
            }
            else if (Smg)
            {
                audioSource.PlayOneShot(smgFireSound);
            }
            else if (Minigun)
            {
                audioSource.PlayOneShot(minigunFireSound);
            }
        }
    }
}

