using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Minigun : MonoBehaviour
{
    public float MinigunFireRate = 0.05f;
    private float NextFire = 0.0f;
    public GameObject Bulletprefab2;
    // Start is called before the first frame update
    void Start()
    {
        NextFire = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0) && Time.time > NextFire)
        {
            if (Guns.Minigun == true)
            {

                NextFire = Time.time + MinigunFireRate;
                Instantiate(Bulletprefab2, transform.position, Bulletprefab2.transform.rotation);
            }
        }
        }
}
