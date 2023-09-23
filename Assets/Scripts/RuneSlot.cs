using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RuneSlot : MonoBehaviour
{
    public bool slotFilled;
    public string[] runeTagsAccepted;

    private void Start()
    {
        slotFilled = false;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        foreach(string runeTag in runeTagsAccepted)
        {
            if (other.CompareTag(runeTag))
            {
                Debug.Log("Correct Rune Placed");
                slotFilled = true;
                return;
            }
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (!other.CompareTag("Player"))
        {
            Debug.Log("Object Removed From " + this.name);
            slotFilled = false;
        }
    }
}
