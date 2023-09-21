using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunePickUp : MonoBehaviour
{
    private void FixedUpdate()
    {
        if(this.gameObject.CompareTag("rune1") && GameManager.gameManager.rune1Picked == true)
            this.gameObject.SetActive(false);
        if(this.gameObject.CompareTag("rune2") && GameManager.gameManager.rune2Picked == true)
            this.gameObject.SetActive(false);
        if(this.gameObject.CompareTag("rune3") && GameManager.gameManager.rune3Picked == true)
            this.gameObject.SetActive(false);
        if(this.gameObject.CompareTag("rune4") && GameManager.gameManager.rune4Picked == true)
            this.gameObject.SetActive(false);
        if(this.gameObject.CompareTag("rune5") && GameManager.gameManager.rune5Picked == true)
            this.gameObject.SetActive(false);
        if(this.gameObject.CompareTag("rune6") && GameManager.gameManager.rune6Picked == true)
            this.gameObject.SetActive(false);
        if(this.gameObject.CompareTag("rune7") && GameManager.gameManager.rune7Picked == true)
            this.gameObject.SetActive(false);
        if(this.gameObject.CompareTag("rune8") && GameManager.gameManager.rune8Picked == true)
            this.gameObject.SetActive(false);
        if(this.gameObject.CompareTag("rune9") && GameManager.gameManager.rune9Picked == true)
            this.gameObject.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && this.gameObject.CompareTag("rune1"))
        {
            GameManager.gameManager.UpdateRuneCount(+1);
            GameManager.gameManager.rune1Picked = true;
            this.gameObject.SetActive(false);
        }
        
        if (other.CompareTag("Player") && this.gameObject.CompareTag("rune2"))
        {
            GameManager.gameManager.UpdateRuneCount(+1);
            GameManager.gameManager.rune2Picked = true;
            this.gameObject.SetActive(false);
        }
        
        if (other.CompareTag("Player") && this.gameObject.CompareTag("rune3"))
        {
            GameManager.gameManager.UpdateRuneCount(+1);
            GameManager.gameManager.rune3Picked = true;
            this.gameObject.SetActive(false);
        }
        
        if (other.CompareTag("Player") && this.gameObject.CompareTag("rune4"))
        {
            GameManager.gameManager.UpdateRuneCount(+1);
            GameManager.gameManager.rune4Picked = true;
            this.gameObject.SetActive(false);
        }
        
        if (other.CompareTag("Player") && this.gameObject.CompareTag("rune5"))
        {
            GameManager.gameManager.UpdateRuneCount(+1);
            GameManager.gameManager.rune5Picked = true;
            this.gameObject.SetActive(false);
        }
        
        if (other.CompareTag("Player") && this.gameObject.CompareTag("rune6"))
        {
            GameManager.gameManager.UpdateRuneCount(+1);
            GameManager.gameManager.rune6Picked = true;
            this.gameObject.SetActive(false);
        }
        
        if (other.CompareTag("Player") && this.gameObject.CompareTag("rune7"))
        {
            GameManager.gameManager.UpdateRuneCount(+1);
            GameManager.gameManager.rune7Picked = true;
            this.gameObject.SetActive(false);
        }
        
        if (other.CompareTag("Player") && this.gameObject.CompareTag("rune8"))
        {
            GameManager.gameManager.UpdateRuneCount(+1);
            GameManager.gameManager.rune8Picked = true;
            this.gameObject.SetActive(false);
        }
        
        if (other.CompareTag("Player") && this.gameObject.CompareTag("rune9"))
        {
            GameManager.gameManager.UpdateRuneCount(+1);
            GameManager.gameManager.rune9Picked = true;
            this.gameObject.SetActive(false);
        }
    }
}
