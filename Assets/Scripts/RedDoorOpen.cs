using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedDoorOpen : MonoBehaviour
{
   public GameObject red, blue, cyan, green, purple, white, door;
   public bool redOk, blueOk, cyanOk, greenOk, purpleOk, whiteOk;

   private void Update()
   {
      if (redOk && blueOk && cyanOk && greenOk && purpleOk && whiteOk) 
      {
         door.transform.rotation = new Quaternion(0, 0, -90f,0);
         door.transform.position = new(0, 12.73f, 0);
      }
   }

   private void OnTriggerEnter2D(Collider2D other)
   {
      Debug.Log("WOrks");
      if (other.gameObject.CompareTag(red.gameObject.tag))
      {
         redOk = true;
         Debug.Log("Same Tags");
      }
      else if (blue.tag == other.tag)
         blueOk = true;
      else if (cyan.tag == other.tag)
         cyanOk = true;
      else if (green.tag == other.tag)
         greenOk = true;
      else if (purple.tag == other.tag)
         purpleOk = true;
      else if (white.tag == other.tag)
         whiteOk = true;
   }
}
