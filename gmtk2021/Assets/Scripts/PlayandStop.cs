using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayandStop : MonoBehaviour
{
    public GameObject PackageObj;
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
        if (PackageObj.active == true )
        {
            PackageObj.SetActive(false);
            
        }
        else
        {
            PackageObj.SetActive(true);
        }
    }
}
