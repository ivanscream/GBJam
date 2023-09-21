using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainRoomRunes : MonoBehaviour
{
    private void FixedUpdate()
    {
        if(this.gameObject.CompareTag("rune1") && GameManager.gameManager.rune1Picked == false)
            this.gameObject.SetActive(false);
        if(this.gameObject.CompareTag("rune2") && GameManager.gameManager.rune2Picked == false)
            this.gameObject.SetActive(false);
        if(this.gameObject.CompareTag("rune3") && GameManager.gameManager.rune3Picked == false)
            this.gameObject.SetActive(false);
        if(this.gameObject.CompareTag("rune4") && GameManager.gameManager.rune4Picked == false)
            this.gameObject.SetActive(false);
        if(this.gameObject.CompareTag("rune5") && GameManager.gameManager.rune5Picked == false)
            this.gameObject.SetActive(false);
        if(this.gameObject.CompareTag("rune6") && GameManager.gameManager.rune6Picked == false)
            this.gameObject.SetActive(false);
        if(this.gameObject.CompareTag("rune7") && GameManager.gameManager.rune7Picked == false)
            this.gameObject.SetActive(false);
        if(this.gameObject.CompareTag("rune8") && GameManager.gameManager.rune8Picked == false)
            this.gameObject.SetActive(false);
        if(this.gameObject.CompareTag("rune9") && GameManager.gameManager.rune9Picked == false)
            this.gameObject.SetActive(false);
    }
}
