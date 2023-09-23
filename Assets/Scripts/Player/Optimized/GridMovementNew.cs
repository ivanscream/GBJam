using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class GridMovementNew : MonoBehaviour
{
    private PickNDrop pickupScript;
    private bool isMoving;
    private Vector3 origPos, targetPos;
    public float timeToMove = 0.2f, checkRadius = 0.1f;
    public Animator animator;
    private Rigidbody2D rb;

    [Header("Tile Check")]
    public Transform[] tileChecks;
    private bool[] tileCheckResults;

    public LayerMask whatIsBlock;

    private static readonly int Horizontal = Animator.StringToHash("Horizontal");
    private static readonly int Vertical = Animator.StringToHash("Vertical");

    private void Start()
    {
        pickupScript = GetComponent<PickNDrop>();
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        AnimatorBools();
    }

    private void Update()
    {
        MoveFaster();
        OverlapTileCheck();

        if (pickupScript.itemHolding != null)
        {
            CheckTile(Vector2.up, 0);
            CheckTile(Vector2.down, 1);
            CheckTile(Vector2.left, 2);
            CheckTile(Vector2.right, 3);
        }

        MovementInputs();
        SetMovementVector();
        pickupScript.isMoving = isMoving;
    }

    private void CheckTile(Vector2 direction, int index)
    {
        Vector3 hold = pickupScript.itemHolding.transform.position;
        Vector3 tempPos = hold + new Vector3(direction.x, direction.y, 0);

        Collider2D hitCollider = Physics2D.OverlapCircle(tempPos, checkRadius, whatIsBlock);
        tileCheckResults[index] = hitCollider == null || hitCollider.tag == "Key";
    }

    private void MovementInputs()
    {
        tileCheckResults = new bool[4];

        if (Input.GetKey(KeyCode.W) && !isMoving && tileCheckResults[0])
            StartCoroutine(MovePlayer(Vector3.up));
        else if (Input.GetKey(KeyCode.A) && !isMoving && tileCheckResults[2])
            StartCoroutine(MovePlayer(Vector3.left));
        else if (Input.GetKey(KeyCode.S) && !isMoving && tileCheckResults[1])
            StartCoroutine(MovePlayer(Vector3.down));
        else if (Input.GetKey(KeyCode.D) && !isMoving && tileCheckResults[3])
            StartCoroutine(MovePlayer(Vector3.right));
    }

    private IEnumerator MovePlayer(Vector3 direction)
    {
        isMoving = true;

        float elapsedTime = 0;

        origPos = transform.position;
        targetPos = origPos + direction;

        while (elapsedTime < timeToMove)
        {
            transform.position = Vector3.Lerp(origPos, targetPos, (elapsedTime / timeToMove));
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        transform.position = targetPos;

        isMoving = false;
    }

    private void AnimatorBools()
    {
        var animHorizontal = animator.GetFloat(Horizontal);
        var animVertical = animator.GetFloat(Vertical);

        animator.SetBool("facingRight", animHorizontal >= 1f);
        animator.SetBool("facingLeft", animHorizontal <= -1f);
        animator.SetBool("facingFront", animVertical <= -1f);
        animator.SetBool("facingBack", animVertical >= 1f);
    }

    private void MoveFaster()
    {
        timeToMove = Input.GetKey(KeyCode.L) ? 0.15f : 0.2f;
    }

    private void OverlapTileCheck()
    {
        for (int i = 0; i < tileChecks.Length; i++)
        {
            tileCheckResults[i] = Physics2D.OverlapCircle(tileChecks[i].position, checkRadius, whatIsBlock);
        }
    }

    private void SetMovementVector()
    {
        Vector2 movementInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));

        animator.SetFloat("Vertical", movementInput.y);
        animator.SetFloat("Horizontal", movementInput.x);
        animator.SetFloat("Speed", movementInput.sqrMagnitude);
    }
}
