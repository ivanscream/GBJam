using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButton : ButtonParent
{
    private Animator anim;

    public StartScreen startScreen;

    private void Start()
    {
        anim = this.GetComponent<Animator>();
    }

    void Update()
    {
       anim.SetBool("selected", selected);
    }

    public override void Use()
    {
        startScreen.gameObject.SetActive(true);
        startScreen.enabled = true;
    }
}
