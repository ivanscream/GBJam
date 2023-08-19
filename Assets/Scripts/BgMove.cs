using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BgMove : MonoBehaviour
{
    public float bgMoveSpeed, forestSpeed, roadSpeed;
    

    private void Update() {
        
        if(gameObject.CompareTag("Sky"))
        transform.Translate(Vector2.left * bgMoveSpeed * Time.deltaTime);
        
        if(gameObject.CompareTag("Forest"))
            transform.Translate(Vector2.left * forestSpeed * Time.deltaTime);
        
        if(gameObject.CompareTag("Road"))
            transform.Translate(Vector2.left * roadSpeed * Time.deltaTime);

    }
}
