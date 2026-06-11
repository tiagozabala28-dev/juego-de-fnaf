using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walk : MonoBehaviour
{
    public float speed = 5f;

    private Rigidbody2D rb;
    private Animator anim;
    private Vector2 movement;
    // Start is called before the first frame update
    void Start()
    {
       rb = GetComponent<Rigidbody2D>();
       anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
      movement.x = Input.GetAxisRaw("Horizontal"); 
      movement.y = Input.GetAxisRaw("Vertical");
      anim.SetBool("IsWalking", movement.x != 0 || movement.y !=0);
    }
    void FixedUpdate()
    {
        rb.velocity = movement.normalized * speed;
    }
}
