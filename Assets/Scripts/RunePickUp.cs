using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunePickUp : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && this.gameObject.CompareTag("rune1"))
        {
            GameManager.gameManager.UpdateRuneCount(+1);
            GameManager.gameManager.rune1Active = true;
            Destroy(this.gameObject);
        }
        
        if (other.CompareTag("Player") && this.gameObject.CompareTag("rune2"))
        {
            GameManager.gameManager.UpdateRuneCount(+1);
            GameManager.gameManager.rune2Active = true;
            Destroy(this.gameObject);
        }
        
        if (other.CompareTag("Player") && this.gameObject.CompareTag("rune3"))
        {
            GameManager.gameManager.UpdateRuneCount(+1);
            GameManager.gameManager.rune3Active = true;
            Destroy(this.gameObject);
        }
        
        if (other.CompareTag("Player") && this.gameObject.CompareTag("rune4"))
        {
            GameManager.gameManager.UpdateRuneCount(+1);
            GameManager.gameManager.rune4Active = true;
            Destroy(this.gameObject);
        }
        
        if (other.CompareTag("Player") && this.gameObject.CompareTag("rune5"))
        {
            GameManager.gameManager.UpdateRuneCount(+1);
            GameManager.gameManager.rune5Active = true;
            Destroy(this.gameObject);
        }
        
        if (other.CompareTag("Player") && this.gameObject.CompareTag("rune6"))
        {
            GameManager.gameManager.UpdateRuneCount(+1);
            GameManager.gameManager.rune6Active = true;
            Destroy(this.gameObject);
        }
        
        if (other.CompareTag("Player") && this.gameObject.CompareTag("rune7"))
        {
            GameManager.gameManager.UpdateRuneCount(+1);
            GameManager.gameManager.rune7Active = true;
            Destroy(this.gameObject);
        }
        
        if (other.CompareTag("Player") && this.gameObject.CompareTag("rune8"))
        {
            GameManager.gameManager.UpdateRuneCount(+1);
            GameManager.gameManager.rune8Active = true;
            Destroy(this.gameObject);
        }
        
        if (other.CompareTag("Player") && this.gameObject.CompareTag("rune9"))
        {
            GameManager.gameManager.UpdateRuneCount(+1);
            GameManager.gameManager.rune9Active = true;
            Destroy(this.gameObject);
        }
    }
}
