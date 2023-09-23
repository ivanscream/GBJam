using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndButton : ButtonParent
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
        Application.Quit(0);
    }
}
