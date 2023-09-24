using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlaterTextActivate : MonoBehaviour
{
    private string[] triggers = new string[]
    {
        "TextTrigger1", "TextTrigger2", "TextTrigger3", "TextTrigger4",
        "TextTrigger5", "TextTrigger6", "TextTrigger7", "TextTrigger8",
        "TextTrigger9", "TextTrigger10", "TextTrigger11", "TextTrigger12",
        "TextTrigger13", "TextTrigger14", "TextTrigger15", "TextTrigger16", "TextTrigger17"
    };
    private void OnTriggerEnter2D(Collider2D other)
    {
        foreach (string tag in triggers)
        {
            if (other.CompareTag(tag))
                GameManager.gameManager.textIsActive = true;
        } 
        
    }
    
}
