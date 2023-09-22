using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpikesAnalBleed : MonoBehaviour
{
    private Animator animator;

    private float waitForStrike = 3f;

    [SerializeField] Collider2D col;
    private Scene scene;
    
    void Start()
    {
        animator = this.gameObject.GetComponent<Animator>();
        col = this.gameObject.GetComponent<Collider2D>();
        scene = SceneManager.GetActiveScene();
        StartCoroutine(ColDisable());
        StartCoroutine(SpikeAttack());
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
            SceneManager.LoadScene(scene.name);
    }
    IEnumerator SpikeAttack()
    { 
        animator.SetTrigger("isAttacking");
        yield return new WaitForSeconds(3f);
        StartCoroutine(SpikeAttack());
    }

    IEnumerator ColDisable()
    {
        col.enabled = true;
        yield return new WaitForSeconds(1f);
        col.enabled = false;
        yield return new WaitForSeconds(2f);
        StartCoroutine(ColDisable());
    }
}


