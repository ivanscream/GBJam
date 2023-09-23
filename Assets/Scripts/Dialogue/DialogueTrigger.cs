using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    public Dialogue dialogue;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
            TriggerDialogue();
    }

    public void TriggerDialogue()
    {
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
    }

    void Update()
    {
        if (this.gameObject != null && GameManager.gameManager.destroyTextTrigger)
        {
            Destroy(this.gameObject);
        }
    }
}
