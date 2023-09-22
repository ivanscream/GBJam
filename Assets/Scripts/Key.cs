using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{

    public int roomNumber;

    private void Start()
    {
        if (GameManager.gameManager.GetKeyCount() >= roomNumber)
        {
            this.gameObject.SetActive(false);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            GameManager.gameManager.UpdateKeyCount(+1);
            this.gameObject.SetActive(false);
        }
    }
}
