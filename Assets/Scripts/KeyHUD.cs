using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeyHUD : MonoBehaviour
{
    [SerializeField] private int roomNumber;
    private RawImage spriteImage;

    private void Start()
    {
        spriteImage = this.gameObject.GetComponent<RawImage>();
    }

    void FixedUpdate()
    {
        if (GameManager.gameManager.GetKeyCount() >= roomNumber)
            spriteImage.enabled = true;
        else
            spriteImage.enabled = false;
    }
}
