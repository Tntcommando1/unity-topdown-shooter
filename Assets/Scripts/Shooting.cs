using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shooting : MonoBehaviour {

    [Header("Effects")]
    public GameObject effect;
    public PlayerAnimations anim;

    [Header("UI")]
    public Image radial;
    public Text ammo;

    [Header("Ammo")]
    public int currentAmmo = 30;

    bool isReloading = false;
    AudioSource gunShot;

    void Start()
    {
        effect.SetActive(false);
        gunShot = GetComponent<AudioSource>();
    }

    void Update () {

        ammo.text = currentAmmo.ToString();

        if(currentAmmo <= 0)
        {
            Reload();
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            Reload();
        }

		if (Input.GetKeyDown(KeyCode.Space))
        {
            if(isReloading == true)
            {
                return;
            }

            StartCoroutine(Effect());
            Shoot();
        }
	}

    void Shoot()
    {
        RaycastHit2D hit = Physics2D.Raycast(this.transform.position, transform.right);
        gunShot.Play();
        currentAmmo--;
        Debug.DrawLine(transform.position, hit.point, Color.red);
        if(hit.collider.gameObject.tag == "Enemy")
        {
            GameObject.Destroy(hit.collider.gameObject);
        }
    }

    void Reload()
    {
        anim.Reload(3);
        StartCoroutine(ReloadWait());
    }

    IEnumerator Effect()
    {
        effect.SetActive(true);
        yield return new WaitForSeconds(0.1f);
        effect.SetActive(false);
    }

    IEnumerator ReloadWait()
    {
        isReloading = true;
        radial.fillAmount += (0.0055f);
        yield return new WaitForSeconds(3);
        currentAmmo = 30;
        isReloading = false;
        radial.fillAmount = 0;
    }
}
