using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class ButtonStart : MonoBehaviour
{
    public float speed = 1.0f;
    private Rigidbody2D rb;
    public AnimationScript roomAnimation;
    [SerializeField] private  string directionGet;
    
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
        GameObject package = other.gameObject;
        roomAnimation = package.GetComponent<AnimationScript>();
        roomAnimation.GetPackageFrom(directionGet);
        this.GetComponent<SpriteRenderer>().enabled = false;

        if (directionGet.Equals("GetUp"))
        {
           yield return new WaitForSeconds(1.5f);
           
        }else if (directionGet.Equals("GetDown"))
        {
            yield return new WaitForSeconds(1.16f);
            
        }else if (directionGet.Equals("GetLeft"))
        {
            yield return new WaitForSeconds(1.1f);
            
        }else if (directionGet.Equals("GetRight"))
        {
            yield return new WaitForSeconds(1.4f);
        }
        
        rb.velocity = new Vector2(0,0);
        //yield return new WaitForSeconds(2f);
        Debug.Log("I waiteded");
        if (package.CompareTag("up") )
        {    
            roomAnimation.GivePackageTo("GiveUp");
            yield return new WaitForSeconds(2f);
            this.transform.position = new Vector2(other.transform.position.x, transform.position.y+1.5f);
            directionGet = "GetDown";
        }
        if (package.CompareTag("down"))
        {
            roomAnimation.GivePackageTo("GiveDown");
            yield return new WaitForSeconds(1.45f);
            this.transform.position = new Vector2(other.transform.position.x, transform.position.y-1.5f);
            directionGet = "GetUp";
        }
        if (package.CompareTag("left"))
        {
            roomAnimation.GivePackageTo("GiveLeft");
            yield return new WaitForSeconds(2.05f);
            this.transform.position = new Vector2(other.transform.position.x-1.5f, transform.position.y);
            directionGet = "GetRight";
        }
        if (package.CompareTag("right"))
        {
            roomAnimation.GivePackageTo("GiveRight");
            yield return new WaitForSeconds(2.1f);
            this.transform.position = new Vector2(other.transform.position.x+1.5f, transform.position.y);
            directionGet = "GetLeft";
        }
        if (package.CompareTag("endtag"))
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
