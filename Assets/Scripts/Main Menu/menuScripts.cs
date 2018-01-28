using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class menuScripts : MonoBehaviour {

    public Sprite playerStandardSprite;
    public Sprite playerReloadSprite;
    public Sprite playerIdleSprite;

    void Awake()
    {
        DontDestroyOnLoad(this);  
    }

    void Update()
    {
        if(SceneManager.GetActiveScene().buildIndex == 1)
        {
            FindObjectOfType<PlayerAnimations>().standard = playerStandardSprite;
            FindObjectOfType<PlayerAnimations>().reload = playerReloadSprite;
            FindObjectOfType<PlayerAnimations>().idle = playerIdleSprite;
        }    
    }

    public void play()
    {
        SceneManager.LoadScene(1);
    }
}
