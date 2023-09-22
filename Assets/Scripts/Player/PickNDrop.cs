using System;
using UnityEngine;

public class PickNDrop : MonoBehaviour
{
    public Transform holdSpot;
    public Transform checkUp, checkDown, checkLeft, checkRight;
    public LayerMask pickUpLayer;
    
    public GameObject itemHolding;
    private Collider2D heldBlockCollider;
    private bool tileUp, tileDown, tileLeft, tileRight;
    private Animator animator;
    private bool facingFront, facingBack, facingRight, facingLeft;
    public bool isMoving;

    private void Start()
    {
        animator = this.GetComponent<Animator>();
        
        
    }


    private void Update()
    {
        facingLeft = animator.GetBool("facingLeft");
        facingRight = animator.GetBool("facingRight");
        facingBack = animator.GetBool("facingBack");
        facingFront = animator.GetBool("facingFront");
        
        tileUp = Physics2D.OverlapCircle(checkUp.position, 0.2f, pickUpLayer);
        tileDown = Physics2D.OverlapCircle(checkDown.position, 0.2f, pickUpLayer);
        tileLeft = Physics2D.OverlapCircle(checkLeft.position, 0.2f, pickUpLayer);
        tileRight = Physics2D.OverlapCircle(checkRight.position, 0.2f, pickUpLayer);
        
        if (facingRight)
            holdSpot = checkRight;
        else if (facingLeft)
            holdSpot = checkLeft;
        else if (facingBack)
            holdSpot = checkUp;
        else if (facingFront)
            holdSpot = checkDown;
        else return;
        
        if (Input.GetKeyDown(KeyCode.P))
        {
            if (itemHolding != null && !isMoving)
            {
                itemHolding.transform.parent = null;
                itemHolding = null;
                if(heldBlockCollider != null)
                {
                    heldBlockCollider.enabled = true;
                    heldBlockCollider = null;
                }
            }
            else
            {
                Collider2D pickedUp = Physics2D.OverlapCircle(holdSpot.position,
                    0.2f, pickUpLayer);
                if (pickedUp)
                {
                    itemHolding = pickedUp.gameObject;
                    itemHolding.transform.position = holdSpot.position;
                    itemHolding.transform.parent = transform;
                    if(itemHolding.transform.childCount > 0)
                    {
                        if (heldBlockCollider = itemHolding.transform.GetChild(0).GetComponent<Collider2D>())
                        {
                            heldBlockCollider.enabled = false;
                        }
                    }
                }
                    

            }
        }
    }
}
