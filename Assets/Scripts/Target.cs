using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    //Credit: https://gist.github.com/thfm/ad88f31ec50a10acd689db153467d523
    public float health;
    public GameObject root;

    void Start()
    {
        root = GameObject.Find("Directional Light");
    }

    void Update()
    {
        if (health <= 0)
        {
            root.GetComponent<TheWorld>().deadAlien();
            Destroy(gameObject);
        }
    }

    /// 'Hits' the target for a certain amount of damage
    public void Hit(float damage)
    {
        health -= damage;
    }
}
