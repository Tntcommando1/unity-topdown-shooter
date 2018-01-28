using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimations : MonoBehaviour {

    public Sprite standard;
    public Sprite reload;
    public Sprite idle;

    private void Awake()
    {
        standard = GameObject.Find("Scripts").GetComponent<menuScripts>().playerStandardSprite;
        this.GetComponent<SpriteRenderer>().sprite = standard;
    }

    public void Reload(float time)
    {
        StartCoroutine(ReloadWait(time));
    }

    IEnumerator ReloadWait(float timeToWait)
    {
        this.GetComponent<SpriteRenderer>().sprite = reload;
        yield return new WaitForSeconds(timeToWait);
        this.GetComponent<SpriteRenderer>().sprite = standard;
    }
}
