using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    public Dialogue dialogue;

    private void Update()
    {
        CheckForMatches();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {

        if(other.CompareTag("Player") && this.gameObject.CompareTag("TextTrigger1"))
        {
            TriggerDialogue();
            GameManager.gameManager.text1Fin = true;
            this.gameObject.SetActive(false);
        }

        if (other.CompareTag("Player") && this.gameObject.CompareTag("TextTrigger2"))
        {
            TriggerDialogue();
            GameManager.gameManager.text2Fin = true;
            this.gameObject.SetActive(false);
        }
        if (other.CompareTag("Player") && this.gameObject.CompareTag("TextTrigger3"))
        {
            TriggerDialogue();
            GameManager.gameManager.text3Fin = true;
            this.gameObject.SetActive(false);
        }

        if (other.CompareTag("Player") && this.gameObject.CompareTag("TextTrigger4"))
        {
            TriggerDialogue();
            GameManager.gameManager.text4Fin = true;
            this.gameObject.SetActive(false);
        }
        if (other.CompareTag("Player") && this.gameObject.CompareTag("TextTrigger5"))
        {
            TriggerDialogue();
            GameManager.gameManager.text5Fin = true;
            this.gameObject.SetActive(false);
        }
        if (other.CompareTag("Player") && this.gameObject.CompareTag("TextTrigger6"))
        {
            TriggerDialogue();
            GameManager.gameManager.text6Fin = true;
            this.gameObject.SetActive(false);
        }
        if (other.CompareTag("Player") && this.gameObject.CompareTag("TextTrigger7"))
        {
            TriggerDialogue();
            GameManager.gameManager.text7Fin = true;
            this.gameObject.SetActive(false);
        }
        if (other.CompareTag("Player") && this.gameObject.CompareTag("TextTrigger8"))
        {
            TriggerDialogue();
            GameManager.gameManager.text8Fin = true;
            this.gameObject.SetActive(false);
        }
        if (other.CompareTag("Player") && this.gameObject.CompareTag("TextTrigger9"))
        {
            TriggerDialogue();
            GameManager.gameManager.text9Fin = true;
            this.gameObject.SetActive(false);
        }
        if (other.CompareTag("Player") && this.gameObject.CompareTag("TextTrigger10"))
        {
            TriggerDialogue();
            GameManager.gameManager.text10Fin = true;
            this.gameObject.SetActive(false);
        }
        if (other.CompareTag("Player") && this.gameObject.CompareTag("TextTrigger11"))
        {
            TriggerDialogue();
            GameManager.gameManager.text11Fin = true;
            this.gameObject.SetActive(false);
        }
        if (other.CompareTag("Player") && this.gameObject.CompareTag("TextTrigger12"))
        {
            TriggerDialogue();
            GameManager.gameManager.text12Fin = true;
            this.gameObject.SetActive(false);
        }
        if (other.CompareTag("Player") && this.gameObject.CompareTag("TextTrigger13"))
        {
            TriggerDialogue();
            GameManager.gameManager.text13Fin = true;
            this.gameObject.SetActive(false);
        }
        if (other.CompareTag("Player") && this.gameObject.CompareTag("TextTrigger14"))
        {
            TriggerDialogue();
            GameManager.gameManager.text14Fin = true;
            this.gameObject.SetActive(false);
        }
        if (other.CompareTag("Player") && this.gameObject.CompareTag("TextTrigger15"))
        {
            TriggerDialogue();
            GameManager.gameManager.text15Fin = true;
            this.gameObject.SetActive(false);
        }
        if (other.CompareTag("Player") && this.gameObject.CompareTag("TextTrigger16"))
        {
            TriggerDialogue();
            GameManager.gameManager.text16Fin = true;
            this.gameObject.SetActive(false);
        }
        
        if (other.CompareTag("Player") && this.gameObject.CompareTag("TextTrigger17"))
        {
            TriggerDialogue();
            GameManager.gameManager.text17Fin = true;
            this.gameObject.SetActive(false);
        }
            
    }

    public void TriggerDialogue()
    {
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
    }

    void CheckForMatches()
    {
        if((GameManager.gameManager.text1Fin && this.gameObject.CompareTag("TextTrigger1")) ||
           (GameManager.gameManager.text2Fin && this.gameObject.CompareTag("TextTrigger2")) ||
           (GameManager.gameManager.text3Fin && this.gameObject.CompareTag("TextTrigger3")) ||
           (GameManager.gameManager.text4Fin && this.gameObject.CompareTag("TextTrigger4")) ||
           (GameManager.gameManager.text5Fin && this.gameObject.CompareTag("TextTrigger5")) ||
           (GameManager.gameManager.text6Fin && this.gameObject.CompareTag("TextTrigger6")) ||
           (GameManager.gameManager.text7Fin && this.gameObject.CompareTag("TextTrigger7")) ||
           (GameManager.gameManager.text8Fin && this.gameObject.CompareTag("TextTrigger8")) ||
           (GameManager.gameManager.text9Fin && this.gameObject.CompareTag("TextTrigger9")) ||
           (GameManager.gameManager.text10Fin && this.gameObject.CompareTag("TextTrigger10")) ||
           (GameManager.gameManager.text11Fin && this.gameObject.CompareTag("TextTrigger11")) ||
           (GameManager.gameManager.text12Fin && this.gameObject.CompareTag("TextTrigger12")) ||
           (GameManager.gameManager.text13Fin && this.gameObject.CompareTag("TextTrigger13")) ||
           (GameManager.gameManager.text14Fin && this.gameObject.CompareTag("TextTrigger14")) ||
           (GameManager.gameManager.text15Fin && this.gameObject.CompareTag("TextTrigger15")) ||
           (GameManager.gameManager.text16Fin && this.gameObject.CompareTag("TextTrigger16"))||
           (GameManager.gameManager.text17Fin && this.gameObject.CompareTag("TextTrigger17")))
        {
            this.gameObject.SetActive(false);
        }
    }
    
    
}
