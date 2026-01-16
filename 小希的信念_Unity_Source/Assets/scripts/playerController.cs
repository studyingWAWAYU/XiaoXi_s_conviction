using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class playerController : MonoBehaviour
{
    private Rigidbody2D rb;
    //¶¯»­public Animator anim;
    //public Collider2D coll;
    public float speed = 500;
    public float Jumpforce = 200;
    public LayerMask ground;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Movement();
        //¶¯»­void SwitchAnim()
    }
    void Movement()
    {
        float HorizontalMove = Input.GetAxis("Horizontal");
        float faceDirection = Input.GetAxisRaw("Horizontal");
        //½ÇÉ«ÒÆ¶¯
        if (HorizontalMove != 0)
        {
            rb.velocity = new Vector2(HorizontalMove * speed * Time.deltaTime, rb.velocity.y);
            //¶¯»­ÇÐ»»anim.SetFloat("running", Mathf.Abs(facedirection));
        }
        //½ÇÉ«×ªÏò
        if (faceDirection != 0)
        {
            transform.localScale = new Vector3(faceDirection, 1, 1);
        }
        //½ÇÉ«ÌøÔ¾
        if (Input.GetButton("Jump") && rb.IsTouchingLayers(ground))
        {
            rb.velocity = new Vector2(rb.velocity.x, Jumpforce * Time.fixedDeltaTime);
            //ÌøÔ¾¶¯»­anim.SetBool("jumping", true);
        }


    }
    //Åö×²Æ÷
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //ËÀÍöÏß
        if (collision.tag == "DeadLine")
        {
            GetComponent<AudioSource>().enabled = false;
            Invoke("Restart", 1f);
        }
        if (collision.tag == "virus")
        {
            GetComponent<AudioSource>().enabled = false;
            Invoke("Restart", 1f);
        }

    }


}
