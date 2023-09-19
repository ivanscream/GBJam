using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadPlatfScript : MonoBehaviour
{
    public bool omgItsAPlatformer;
    void OnTriggerEnter2D()
    {
        SceneManager.LoadScene("SuddenlyPlatformer");
        omgItsAPlatformer = true;
    }
}
