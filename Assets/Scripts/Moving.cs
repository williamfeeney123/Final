using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour
{

    [SerializeField] private LayerMask PlatformsLayerMask;
    public float speed;
    public float jumpSpeed;
    private bool onGround;
    public Rigidbody2D rigidbody2d;
    private BoxCollider2D boxCollider2d;
    public Animator Animator;
    
    // Start is called before the first frame update
    void Start()
    {
        
   
        rigidbody2d = transform.GetComponent<Rigidbody2D>();
        boxCollider2d = transform.GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
       


       if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(speed, 0f, 0f) * Time.deltaTime;
            Animator.SetFloat("speed", Mathf.Abs(speed));
            transform.eulerAngles = new Vector3(0, 0, 0);
           
        }

        else if (Input.GetKey(KeyCode.A))
        {
            transform.position += new Vector3(-speed, 0f, 0f) * Time.deltaTime;
            Animator.SetFloat("speed", Mathf.Abs(speed));
            transform.eulerAngles = new Vector3(0, 180, 0);
          
        }


        else
        {
            Animator.SetFloat("speed", 0f);
          
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            
            if (onGround)
            {
                rigidbody2d.AddForce(new Vector2(0f, jumpSpeed), ForceMode2D.Impulse);
               
                onGround = false;
                Animator.SetBool("isJumping", true);
            }
        }


    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            if (collision.transform.position.y < transform.position.y)
            {
                Animator.SetBool("isJumping", false);
                onGround = true;
            }
        }
    }


}
