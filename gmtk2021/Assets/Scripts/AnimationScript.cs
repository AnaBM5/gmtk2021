using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationScript : MonoBehaviour
{
    public Animator roomAnim;
    
    
    public void GivePackageTo(string direction){
        roomAnim.SetTrigger(direction);
    }
    
    public void GetPackageFrom(string direction){
        roomAnim.SetTrigger(direction);
    }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
