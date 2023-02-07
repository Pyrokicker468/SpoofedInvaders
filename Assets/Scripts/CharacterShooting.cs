using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterShooting : MonoBehaviour
{
    //Credit: https://gist.github.com/thfm/ad88f31ec50a10acd689db153467d523
    public Gun gun;
    public Gun gun2;

    public int shootButton;
    public KeyCode reloadKey;
    public GameObject root;

    void Start()
    {
        root = GameObject.Find("Directional Light");
    }

    void Update()
    {
        if (root.GetComponent<TheWorld>().returnCheck())
        {
            if (Input.GetMouseButton(shootButton))
            {
                gun.Shoot();
                gun2.Shoot();
            }

            if (Input.GetKeyDown(reloadKey))
            {
                gun.Reload();
                gun2.Reload();
            }
        }
    }
}