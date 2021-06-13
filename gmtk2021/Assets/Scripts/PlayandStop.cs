using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayandStop : MonoBehaviour
{
    public GameObject PackageObj;
    public bool running;
    public GameObject beginning;

    [SerializeField] private Image playButton;
    [SerializeField] private Sprite playSprite;

    [SerializeField] private Sprite pauseSprite;
    
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
            Debug.Log("Stop");
            running = false;
            PackageObj.transform.position = beginning.transform.position;
            PackageObj.SetActive(false);
            playButton.sprite = playSprite;


        }
        else
        { 
            Debug.Log(("Start"));
            PackageObj.SetActive(true);
            
            running = true;
            playButton.sprite = pauseSprite;
        }
    }

    public void RestartLevel(int level)
    {
        SceneManager.LoadScene("Level" + level.ToString());
    }
}
