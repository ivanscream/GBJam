using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainRoomRunes : MonoBehaviour
{
   
    private void FixedUpdate()
    {
        //this.gameObject.SetActive(false); - Old Way, had to change to track rune positions.
        if(this.gameObject.CompareTag("rune1") && GameManager.gameManager.rune1Picked == false)
        {
            var colliders = this.GetComponentsInChildren<Collider2D>();
            var sprites = this.GetComponentsInChildren<SpriteRenderer>();
            foreach(Collider2D collider in colliders)
            {
                collider.enabled = false;
            }
            foreach (SpriteRenderer sprite in sprites)
            {
                sprite.enabled = false;
            }
        }
        if(this.gameObject.CompareTag("rune2") && GameManager.gameManager.rune2Picked == false)
        {
            var colliders = this.GetComponentsInChildren<Collider2D>();
            var sprites = this.GetComponentsInChildren<SpriteRenderer>();
            foreach (Collider2D collider in colliders)
            {
                collider.enabled = false;
            }
            foreach (SpriteRenderer sprite in sprites)
            {
                sprite.enabled = false;
            }
        }
        if (this.gameObject.CompareTag("rune3") && GameManager.gameManager.rune3Picked == false)
        {
            var colliders = this.GetComponentsInChildren<Collider2D>();
            var sprites = this.GetComponentsInChildren<SpriteRenderer>();
            foreach (Collider2D collider in colliders)
            {
                collider.enabled = false;
            }
            foreach (SpriteRenderer sprite in sprites)
            {
                sprite.enabled = false;
            }
        }
        if (this.gameObject.CompareTag("rune4") && GameManager.gameManager.rune4Picked == false)
        {
            var colliders = this.GetComponentsInChildren<Collider2D>();
            var sprites = this.GetComponentsInChildren<SpriteRenderer>();
            foreach (Collider2D collider in colliders)
            {
                collider.enabled = false;
            }
            foreach (SpriteRenderer sprite in sprites)
            {
                sprite.enabled = false;
            }
        }
        if (this.gameObject.CompareTag("rune5") && GameManager.gameManager.rune5Picked == false)
        {
            var colliders = this.GetComponentsInChildren<Collider2D>();
            var sprites = this.GetComponentsInChildren<SpriteRenderer>();
            foreach (Collider2D collider in colliders)
            {
                collider.enabled = false;
            }
            foreach (SpriteRenderer sprite in sprites)
            {
                sprite.enabled = false;
            }
        }
        if (this.gameObject.CompareTag("rune6") && GameManager.gameManager.rune6Picked == false)
        {
            var colliders = this.GetComponentsInChildren<Collider2D>();
            var sprites = this.GetComponentsInChildren<SpriteRenderer>();
            foreach (Collider2D collider in colliders)
            {
                collider.enabled = false;
            }
            foreach (SpriteRenderer sprite in sprites)
            {
                sprite.enabled = false;
            }
        }
        if (this.gameObject.CompareTag("rune7") && GameManager.gameManager.rune7Picked == false)
        {
            var colliders = this.GetComponentsInChildren<Collider2D>();
            var sprites = this.GetComponentsInChildren<SpriteRenderer>();
            foreach (Collider2D collider in colliders)
            {
                collider.enabled = false;
            }
            foreach (SpriteRenderer sprite in sprites)
            {
                sprite.enabled = false;
            }
        }
        if (this.gameObject.CompareTag("rune8") && GameManager.gameManager.rune8Picked == false)
        {
            var colliders = this.GetComponentsInChildren<Collider2D>();
            var sprites = this.GetComponentsInChildren<SpriteRenderer>();
            foreach (Collider2D collider in colliders)
            {
                collider.enabled = false;
            }
            foreach (SpriteRenderer sprite in sprites)
            {
                sprite.enabled = false;
            }
        }
        if (this.gameObject.CompareTag("rune9") && GameManager.gameManager.rune9Picked == false)
        {
            var colliders = this.GetComponentsInChildren<Collider2D>();
            var sprites = this.GetComponentsInChildren<SpriteRenderer>();
            foreach (Collider2D collider in colliders)
            {
                collider.enabled = false;
            }
            foreach (SpriteRenderer sprite in sprites)
            {
                sprite.enabled = false;
            }
        }
    }
}
