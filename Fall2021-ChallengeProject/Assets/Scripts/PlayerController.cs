using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Transform moveTo;
    public float moveSpeed = 5f;
    public bool canMove = true;

    public LayerMask whatStopsMovement;
    // Start is called before the first frame update
    void Start()
    {
        moveTo.parent = null;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, moveTo.position, moveSpeed * Time.deltaTime);
        if (Vector3.Distance(transform.position, moveTo.position) < .03f && canMove)
        {
            if (Mathf.Abs(Input.GetAxisRaw("Horizontal")) == 1)
            {
                if (!Physics2D.OverlapCircle(moveTo.position + new Vector3(Input.GetAxisRaw("Horizontal"), 0, 0), .2f, whatStopsMovement))
                {
                    moveTo.position += new Vector3(Input.GetAxisRaw("Horizontal"), 0, 0);
                }
            }
            else if (Mathf.Abs(Input.GetAxisRaw("Vertical")) == 1)
            {
                if (!Physics2D.OverlapCircle(moveTo.position + new Vector3(0, Input.GetAxisRaw("Vertical"), 0), .2f, whatStopsMovement))
                {
                    moveTo.position += new Vector3(0, Input.GetAxisRaw("Vertical"), 0);
                }
            }
        }
    }
    public void SwitchTurn()
    {
        canMove = !canMove;
    }
}
