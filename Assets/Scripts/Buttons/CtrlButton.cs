using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CtrlButton : ButtonParent
{
    private Animator anim;

    [SerializeField] GameObject ctrlsScreen;

    private void Start()
    {
        anim = this.GetComponent<Animator>();
        ctrlsScreen.SetActive(false);
    }

    void Update()
    {
        anim.SetBool("selected", selected);
    }

    public override void Use()
    {
        if(ctrlsScreen.activeSelf == false)
        {
            ctrlsScreen.SetActive(true);
            MainMenu.lockMain = true;
        }
        else
        {
            ctrlsScreen.SetActive(false);
            MainMenu.lockMain = false;
        }
    }
}
