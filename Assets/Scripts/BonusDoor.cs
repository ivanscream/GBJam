using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusDoor : MonoBehaviour
{
    public GameObject self;
    
    static bool doOnce;
    private Collider2D coll2D;
    private SpriteRenderer spriteRenderer;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        coll2D = GetComponent<Collider2D>();
        self = this.gameObject;
        doOnce = false;
    }

    private void FixedUpdate()
    {
        if (GameManager.gameManager.OptionalDoor)
        {
            coll2D.enabled = false;
            spriteRenderer.enabled = false;
        }

        if (RuneManager.instance.GetSecondaryCondition())
        {
            GameManager.gameManager.OptionalDoor = true;
            coll2D.enabled = false;
            spriteRenderer.enabled = false;
        }
    }
}
