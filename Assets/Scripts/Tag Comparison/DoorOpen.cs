using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour
{
    private Red red;
    public GameObject objectWithScript;

    private void Start()
    {
        
        red = objectWithScript.GetComponent<Red>();
    }

    private void Update()
    {
        if (red.redOk == true)
            Destroy(gameObject);
            
    }
}
