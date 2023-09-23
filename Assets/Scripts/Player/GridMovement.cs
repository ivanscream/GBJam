using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class GridMovement : MonoBehaviour
{
    private PickNDrop pickupScript;
    private bool isMoving;
    private Vector3 origPos, targetPos;
    public float timeToMove = 0.2f, checkRadius = 0.1f;
    public Animator animator;
    public Vector2 movement;
    private Rigidbody2D rb;

    [Header("Tile Check")]
    public Transform checkUp, checkDown, checkLeft, checkRight;

    [SerializeField] private bool tileUp, tileDown, tileLeft, tileRight;

    public LayerMask whatIsBlock;
    private static readonly int Horizontal = Animator.StringToHash("Horizontal");
    private static readonly int Vertical = Animator.StringToHash("Vertical");

    


    void Start()
    {
        
        pickupScript = this.gameObject.GetComponent<PickNDrop>();
        Rigidbody2D rb = this.gameObject.GetComponent<Rigidbody2D>();

    }

    private void FixedUpdate()
    {
        AnimatorBools();
    }

    void Update()
    {
        MoveFaster();
        OverlapTileCheck();
        
        if (pickupScript.itemHolding != null)
        {
            Vector3 hold = new Vector3(pickupScript.itemHolding.transform.position.x,
                pickupScript.itemHolding.transform.position.y, pickupScript.itemHolding.transform.position.z);
            Vector3 tempUp = new Vector3(hold.x, hold.y + 1, hold.z);
            Vector3 tempDown = new Vector3(hold.x, hold.y - 1, hold.z);
            Vector3 tempRight = new Vector3(hold.x + 1, hold.y, hold.z);
            Vector3 tempLeft = new Vector3(hold.x - 1, hold.y, hold.z);

            Collider2D hitCollider = Physics2D.OverlapCircle(tempUp, checkRadius, whatIsBlock);
            
            if (hitCollider)
            {
                if (hitCollider.tag != "red" &&
                    hitCollider.tag != "Key")
                    tileUp = true;
            }
            
            hitCollider = Physics2D.OverlapCircle(tempDown, checkRadius, whatIsBlock);
            if (hitCollider)
            {
                if (hitCollider.tag != "red" &&
                    hitCollider.tag != "Key")
                    tileDown = true;
            }
            hitCollider = Physics2D.OverlapCircle(tempLeft, checkRadius, whatIsBlock);
            if (hitCollider)
            {
                if (hitCollider.tag != "red" &&
                    hitCollider.tag != "Key")
                    tileLeft = true;
            }

            hitCollider = Physics2D.OverlapCircle(tempRight, checkRadius, whatIsBlock);
            if (hitCollider)
            {
                if (hitCollider.tag != "red" &&
                    hitCollider.tag != "Key")
                    tileRight = true;
            }
        }

        MovementInputs();
        SetMovementVector();
        pickupScript.isMoving = isMoving;
    }

    private void MovementInputs()
    {
        if (Input.GetKey(KeyCode.W) && !isMoving && !tileUp)
            StartCoroutine(MovePlayer(Vector3.up));

        if (Input.GetKey(KeyCode.A) && !isMoving && !tileLeft)
            StartCoroutine(MovePlayer(Vector3.left));

        if (Input.GetKey(KeyCode.S) && !isMoving && !tileDown)
            StartCoroutine(MovePlayer(Vector3.down));

        if (Input.GetKey(KeyCode.D) && !isMoving && !tileRight)
            StartCoroutine(MovePlayer(Vector3.right));
        
    }

    private IEnumerator MovePlayer (Vector3 direction) {

        isMoving = true;

        float elapsedTime = 0;

        origPos = transform.position;
        targetPos = origPos + direction;

        while (elapsedTime < timeToMove) {
            transform.position = Vector3.Lerp(origPos, targetPos, (elapsedTime/timeToMove));
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        transform.position = targetPos;

        isMoving = false;
    }

    void AnimatorBools()
    {
        var animHorizontal = animator.GetFloat(Horizontal);
        var animVertical = animator.GetFloat(Vertical);


        if (animHorizontal >= 1f)
        {
            animator.SetBool("facingRight", true);
            animator.SetBool("facingLeft", false);
            animator.SetBool("facingFront", false);
            animator.SetBool("facingBack", false);
        }
        else if (animHorizontal <= -1f)
        {
            animator.SetBool("facingRight", false);
            animator.SetBool("facingLeft", true);
            animator.SetBool("facingFront", false);
            animator.SetBool("facingBack", false);
        }
        else if (animVertical >= 1f)
        {
            animator.SetBool("facingRight", false);
            animator.SetBool("facingLeft", false);
            animator.SetBool("facingFront", false);
            animator.SetBool("facingBack", true);
        }
        else if (animVertical <= -1f)
        {
            animator.SetBool("facingRight", false);
            animator.SetBool("facingLeft", false);
            animator.SetBool("facingFront", true);
            animator.SetBool("facingBack", false);
        }
    }

    void MoveFaster()
    {
        if (Input.GetKey(KeyCode.L))
            timeToMove = 0.15f;
        else timeToMove = 0.2f;
    }

    void OverlapTileCheck()
    {
        tileUp = Physics2D.OverlapCircle(checkUp.position, checkRadius, whatIsBlock);
        tileDown = Physics2D.OverlapCircle(checkDown.position, checkRadius, whatIsBlock);
        tileRight = Physics2D.OverlapCircle(checkRight.position, checkRadius, whatIsBlock);
        tileLeft = Physics2D.OverlapCircle(checkLeft.position, checkRadius, whatIsBlock);
    }

    void SetMovementVector()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        if (movement.x != 0 || movement.y != 0)
        {
            animator.SetFloat("Vertical", movement.y); 
            animator.SetFloat("Horizontal", movement.x);
        }
            
        animator.SetFloat("Speed", movement.sqrMagnitude);
    }
    
}
