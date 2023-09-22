using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
    public Sprite closedSprite, openSprite;
    private Collider2D blockingCollider;
    [SerializeField] private int roomLockNumber;
    void Start()
    {
        blockingCollider = this.gameObject.GetComponent<Collider2D>();
    }
    void Update()
    {
        if (GameManager.gameManager.GetKeyCount() >= roomLockNumber)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = openSprite;
            blockingCollider.enabled = false;
        }
        else
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = closedSprite;
            blockingCollider.enabled = true;
        }
    }
}
