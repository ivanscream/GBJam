using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    private Queue<string> sentences;
    public TextMeshProUGUI dialogueText;

    private void Start()
    {
        sentences = new Queue<string>();
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.P))
            DisplayNextSentence();
    }

    public void StartDialogue(Dialogue dialogue)
    {
        sentences.Clear();

        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }

        DisplayNextSentence();
    }
    
    public void DisplayNextSentence()
    {
        if (sentences.Count == 0)
        {
            EndDialogue();
            return;
        }

        string sentence = sentences.Dequeue();
        dialogueText.text = sentence;
    }

    private void EndDialogue()
    {
            Debug.Log("Nothing to say");
            GameManager.gameManager.textIsActive = false;
            GameManager.gameManager.destroyTextTrigger = true;
    }
}
