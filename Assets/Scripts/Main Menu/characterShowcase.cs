using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterShowcase : MonoBehaviour {

    menuScripts menu;
    public Sprite manBlue_standard;
    public Sprite manBlue_reload;
    public Sprite manBlue_idle;

    public Sprite robot1_standard;
    public Sprite robot1_reload;
    public Sprite robot1_idle;

    public Sprite hitman1_standard;
    public Sprite hitman1_reload;
    public Sprite hitman1_idle;

    private void Start()
    {
        menu = FindObjectOfType<menuScripts>();
    }

    public void ChangeCharacter(Sprite character)
    {
        this.GetComponent<SpriteRenderer>().sprite = character;

        if(character.name == "manBlue_machine")
        {
            ManBlue();
        }
        if (character.name == "hitman1_machine")
        {
            Hitman();
        }
        if (character.name == "robot1_machine")
        {
            Robot();
        }
    }

    public void ManBlue()
    {
        menu.playerStandardSprite = manBlue_standard;
        menu.playerReloadSprite = manBlue_reload;
        menu.playerIdleSprite = manBlue_idle;
    }

    public void Robot()
    {
        menu.playerStandardSprite = robot1_standard;
        menu.playerReloadSprite = robot1_reload;
        menu.playerIdleSprite = robot1_idle;
    }

    public void Hitman()
    {
        menu.playerStandardSprite = hitman1_standard;
        menu.playerReloadSprite = hitman1_reload;
        menu.playerIdleSprite = hitman1_idle;
    }
}
