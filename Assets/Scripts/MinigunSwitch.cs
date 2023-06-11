using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinigunSwitch : MonoBehaviour
{
    public Sprite Minigunsprite;
    private SpriteRenderer spriteRenderer;
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Guns.Pistol)
        {
            spriteRenderer.sprite = null;
        }                           
        else if (Guns.Shotgun)      
        {                           
            spriteRenderer.sprite = null;
        }                           
        else if (Guns.Sniper)       
        {                           
            spriteRenderer.sprite = null;
        }                           
        else if (Guns.Smg)          
        {                           
            spriteRenderer.sprite = null;
        }                          
        else if (Guns.Assault)     
        {                          
            spriteRenderer.sprite = null;
        }
        else if (Guns.Minigun)
        {
            spriteRenderer.sprite = Minigunsprite;
        }
    }
}
