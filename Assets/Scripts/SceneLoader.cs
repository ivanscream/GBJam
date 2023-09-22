using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && this.gameObject.CompareTag("ToMain"))
        {
            SceneManager.LoadScene("MainRoom");
        }
        if (other.CompareTag("Player") && this.gameObject.CompareTag("PuzzleLeft"))
        {
            GameManager.SetEnterDirection("PuzzleLeft");
            SceneManager.LoadScene("PuzzleLeft");
        }
        if (other.CompareTag("Player") && this.gameObject.CompareTag("PuzzleRight"))
        {
            GameManager.SetEnterDirection("PuzzleRight");
            SceneManager.LoadScene("PuzzleRight");
        }
        if (other.CompareTag("Player") && this.gameObject.CompareTag("MazeLeft"))
        {
            GameManager.SetEnterDirection("MazeLeft");
            SceneManager.LoadScene("MazeLeft");
        }
        if (other.CompareTag("Player") && this.gameObject.CompareTag("MazeRight"))
        {
            GameManager.SetEnterDirection("MazeRight");
            SceneManager.LoadScene("MazeRight");
        }
    }
}
