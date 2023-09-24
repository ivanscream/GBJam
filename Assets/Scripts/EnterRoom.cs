using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterRoom : MonoBehaviour
{

    [SerializeField] private Vector3 puzzleLeftEnter, puzzleRightEnter, mazeLeftEnter, mazeRightEnter;
    private string enterDirection;

    void Start()
    {
        enterDirection = GameManager.GetEnterDirection();
        if(enterDirection != null)
        {
            if (enterDirection.ToLower() == "puzzleleft")
            {
                this.transform.position = puzzleLeftEnter;
            }
            else if (enterDirection.ToLower() == "puzzleright")
            {
                this.transform.position = puzzleRightEnter;
            }
            else if (enterDirection.ToLower() == "mazeleft")
            {
                this.transform.position = mazeLeftEnter;
            }
            else if (enterDirection.ToLower() == "mazeright")
            {
                this.transform.position = mazeRightEnter;
            }
        }
    }
}
