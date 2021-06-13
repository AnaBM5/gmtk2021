using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayandStop : MonoBehaviour
{
    public GameObject PackageObj;
    public bool running;
    public GameObject beginning;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void click()
    {
        if (running)
        {
            running = false;
            PackageObj.transform.position = beginning.transform.position;
            PackageObj.SetActive(false);
            
        }
        else
        { 
            PackageObj.SetActive(true);
           
            running = true;
        }
    }
}
