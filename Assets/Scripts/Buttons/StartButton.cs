using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButton : ButtonParent
{
    private Animator anim;

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
        SceneManager.LoadScene("MainRoom");
    }
}
