using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunSwitch : MonoBehaviour
{
    public Sprite assaultSprite; 
    public Sprite pistolSprite;
    public Sprite Shotgunsprite;
    public Sprite sniperSprite;
    public Sprite smgSprite;

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
            spriteRenderer.sprite = pistolSprite;
        }
        else if (Guns.Shotgun)
        {
            spriteRenderer.sprite = Shotgunsprite;
        }
        else if (Guns.Sniper)
        {
            spriteRenderer.sprite = sniperSprite;
        }
        else if (Guns.Smg)
        {
            spriteRenderer.sprite = smgSprite;
        }
        else if (Guns.Assault)
        {
            spriteRenderer.sprite = assaultSprite;
        }
        else if (Guns.Minigun)
        {
            spriteRenderer.sprite = null;
        }
    }
}
