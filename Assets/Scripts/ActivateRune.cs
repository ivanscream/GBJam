using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateRune : MonoBehaviour
{
    void Update()
    {
        if (this.gameObject.CompareTag("rune5") && GameManager.gameManager.rune5Active == true)
        {
            gameObject.SetActive(true);
        }
    }
}
