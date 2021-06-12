using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragDrop : MonoBehaviour
{
    private RectTransform rectTransform;
    private void Awake() 
    {
        rectTransform = GetComponent<RectTransform>();
    }
   public void OnMouseDown()
   {
       Debug.Log("doing pointer");
   }
   public void OnMouseEndDrag()
   {
       Debug.Log("doing enddrag");
   }
   public void OnMouseBeginDrag()
   {
       Debug.Log("doing begindrag");
   }
   public void OnMouseDrag()
   {

   }
}
