using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragDrop : MonoBehaviour
{
    private Vector2 initialPosition;
    private Vector2 mousePosition;
    private Vector2 newPosition;
    public GameObject current;
    
    

    private void Start()
    {
        initialPosition = transform.position;
        newPosition = initialPosition;
    }

    private void OnMouseDown()
   {
       Debug.Log("doing pointer");
   }

   private void OnMouseUp()
   {
       Debug.Log("now");
       current.GetComponent<variablebusyornot>().isbusy=true;
       transform.position = new Vector2(newPosition.x,newPosition.y);
   }
   private void OnMouseDrag()
   {
        mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector2(mousePosition.x, mousePosition.y);
   }

   private void OnTriggerEnter2D(Collider2D col)
   {
      if (!col.gameObject.GetComponent<variablebusyornot>().isbusy)
      {
          current = col.gameObject;
          newPosition = col.transform.position;
      }

   }
}
