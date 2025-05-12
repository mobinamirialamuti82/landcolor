using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public float speed;
    private float Move;
    public float jump;
    public bool isjumping;
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb=GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Move=Input.GetAxis("Horizontal");
        rb.velocity= new Vector2(speed*Move,rb.velocity.y);
        if(Input.GetButtonDown("Jump") && isjumping==false)
        {
            rb.AddForce(new Vector2(rb.velocity.x,jump));
            Debug.Log("jump");
        }

    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag=="Ground")
        {
            isjumping=false;
            Debug.Log("on the Ground");
        
        }
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        if(other.gameObject.tag=="Ground")
        {
            isjumping=true;
            Debug.Log("on the fly");
        
        }
    }

}
