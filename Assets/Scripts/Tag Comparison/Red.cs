
using UnityEngine;

public class Red : MonoBehaviour
{
  public bool redOk;

  private void Start()
  {
    redOk = false;
  }

  private void OnTriggerEnter2D(Collider2D other)
  {
    if (other.CompareTag("red"))
    {
      Debug.Log("Red OK");
      redOk = true;
    } 
  }

  private void OnTriggerExit2D(Collider2D other)
  {
    if (other.CompareTag("red"))
    {
      Debug.Log("Red Out");
      redOk = false;
    } 
  }
}
