using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Round : MonoBehaviour
{
    //Credit: https://gist.github.com/thfm/ad88f31ec50a10acd689db153467d523
    public float damage;
    public GameObject explosion;

    void Start()
    {
        GameObject.Destroy(gameObject, 3f);
    }
        void OnCollisionEnter(Collision other)
    {
        Target target = other.gameObject.GetComponent<Target>();
        // Only attempts to inflict damage if the other game object has
        // the 'Target' component
        if (target != null)
        {
            Instantiate(explosion, target.transform.localPosition, Quaternion.identity);
            target.Hit(damage);
            Destroy(gameObject); // Deletes the round
        }
    }
}
