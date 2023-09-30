using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScreen : MonoBehaviour
{
    public Dialogue dialogue;
    int dialogueTracker = 0;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            if(dialogueTracker <= dialogue.sentences.Length - 2)
            {
            FindObjectOfType<DialogueManager>().DisplayNextSentence();
                dialogueTracker++;
            }
            else
                SceneManager.LoadScene("MainRoom");
        }
    }

    private void OnEnable()
    {
        TriggerDialogue();
    }

    public void TriggerDialogue()
    {
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
    }
}
