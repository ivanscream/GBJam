using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RuneText : MonoBehaviour
{
    private Text runeCount;

    private void Start()
    {
        runeCount = this.gameObject.GetComponent<Text>();
    }
    void Update()
    {
        if(GameManager.gameManager != null)
        {
            runeCount.text = GameManager.gameManager.GetRuneCount().ToString();

        }
    }
}
