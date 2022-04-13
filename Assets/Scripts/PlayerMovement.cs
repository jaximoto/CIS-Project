using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float jump_height;
    private Rigidbody2D body;
    private Animator anim;

    private void Awake()
    {
        body = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Left right movement
        float horizontalInput = Input.GetAxis("Horizontal");
        body.velocity = new Vector2(Input.GetAxis("Horizontal") * speed, body.velocity.y);


        // Flip Player when turning around
        if (horizontalInput > 0.01f)
            transform.localScale = new Vector2(6, 6);
        else if (horizontalInput < -0.01f)
            transform.localScale = new Vector2(-6, 6);

        // Jumping
        if (Input.GetKey(KeyCode.Space))
            body.velocity = new Vector2(body.velocity.x, jump_height);
        //Set Animator Params
        anim.SetBool("run", horizontalInput != 0);
    }
}
