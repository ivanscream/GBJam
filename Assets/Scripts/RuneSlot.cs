using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RuneSlot : MonoBehaviour
{
    public bool slotFilled;
    public string slotName;
    public string[] runeTagsAccepted;
    bool hasMoved;

    private void Start()
    {
        if (GameManager.gameManager != null)
            slotFilled = GameManager.gameManager.GetSlotStatus(slotName);
        else
            slotFilled = FindObjectOfType<GameManager>().GetSlotStatus(slotName);
    }

    private void FixedUpdate()
    {
        if(!hasMoved)
            slotFilled = GameManager.gameManager.GetSlotStatus(slotName);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        foreach(string runeTag in runeTagsAccepted)
        {
            if (other.CompareTag(runeTag))
            {
                Debug.Log("Correct Rune Placed");
                slotFilled = true;
                hasMoved = true;
                GameManager.gameManager.SetSlotStatus(slotName, true);
                return;
            }
        }
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (!slotFilled)
        {
        foreach (string runeTag in runeTagsAccepted)
        {
            if (other.CompareTag(runeTag))
            {
                Debug.Log("Correct Rune Placed");
                slotFilled = true;
                    hasMoved = true;
                    GameManager.gameManager.SetSlotStatus(slotName, true);
                    return;
            }
        }
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (!other.CompareTag("Player"))
        {
            Debug.Log("Object Removed From " + this.name);
            slotFilled = false;
            hasMoved = true;
            GameManager.gameManager.SetSlotStatus(slotName, false);
        }
    }
}
