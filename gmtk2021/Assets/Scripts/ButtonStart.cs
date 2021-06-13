using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonStart : MonoBehaviour
{
    public float speed = 1.0f;
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb= this.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(speed,0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2d(Collision2D col)
    {
        if (col.gameObject.tag == "up")
        {
            rb.velocity = new Vector2(0,speed);
        }
        if (col.gameObject.tag == "down")
        {
            rb.velocity = new Vector2(0,-speed);
        }
        if (col.gameObject.tag == "left")
        {
            rb.velocity = new Vector2(-speed,0);
        }
        if (col.gameObject.tag == "right")
        {
            rb.velocity = new Vector2(speed,0);
        }
        
    }

}
