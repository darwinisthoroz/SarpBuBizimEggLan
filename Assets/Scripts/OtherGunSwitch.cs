using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OtherGunSwitch : MonoBehaviour
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
        if (OtherGuns.Pistol)
        {
            spriteRenderer.sprite = pistolSprite;
        }
        else if (OtherGuns.Shotgun)
        {
            spriteRenderer.sprite = Shotgunsprite;
        }
        else if (OtherGuns.Sniper)
        {
            spriteRenderer.sprite = sniperSprite;
        }
        else if (OtherGuns.Smg)
        {
            spriteRenderer.sprite = smgSprite;
        }
        else if (OtherGuns.Assault)
        {
            spriteRenderer.sprite = assaultSprite;
        }
        else if (OtherGuns.Minigun)
        {
            spriteRenderer.sprite = null;
        }
    }
}
