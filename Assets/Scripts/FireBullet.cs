using System.Collections;
using System.Collections.Generic;
using UnityEngine; 

public class FireBullet : MonoBehaviour
{
    public float bulletSpeed = 10;
    public Rigidbody bullet;
    public GameObject root;

    void Start()
    {
        root = GameObject.Find("Directional Light");
    }

        void Fire()
    {
        Rigidbody bulletClone = (Rigidbody)Instantiate(bullet, transform.position + new Vector3(1,0.5f,0), Quaternion.identity);
        bulletClone.velocity = transform.forward * bulletSpeed * 20;
    }

    void Update()
    {
        if (root.GetComponent<TheWorld>().returnCheck())
        {
            if (Input.GetButtonDown("Fire1"))
                Fire();
        }
    }
}