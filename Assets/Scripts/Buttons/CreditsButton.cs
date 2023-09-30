using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreditsButton : ButtonParent
{
    private Animator anim;

    public GameObject creditsScreen;

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
        MainMenu.lockMain = !MainMenu.lockMain;
        creditsScreen.SetActive(!creditsScreen.activeSelf);
    }
}
