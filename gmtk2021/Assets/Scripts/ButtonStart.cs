using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

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
    void OnEnable()
    {
        rb= this.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(speed,0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   
    private IEnumerator desplazar(Collider2D other) 
    {
        rb.velocity = new Vector2(0,0);
        yield return new WaitForSeconds(2f);
        Debug.Log("I waiteded");
        if (other.gameObject.tag == "up")
        {
            this.transform.position = new Vector2(other.transform.position.x, transform.position.y+1.5f);
        }
        if (other.gameObject.tag == "down")
        {
            this.transform.position = new Vector2(other.transform.position.x, transform.position.y-1.5f);
        }
        if (other.gameObject.tag == "left")
        {
            this.transform.position = new Vector2(other.transform.position.x-1.5f, transform.position.y);
        }
        if (other.gameObject.tag == "right")
        {
            this.transform.position = new Vector2(other.transform.position.x+1.5f, transform.position.y);
        }
        if (other.gameObject.tag == "endtag")
        {
            Debug.Log("yay u did it");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
        }
    }
     private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag!="cuadricula")
        {
            StartCoroutine(desplazar(other));
        }
        
    }

}
