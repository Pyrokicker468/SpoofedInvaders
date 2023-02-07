using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienShipTravel : MonoBehaviour
{
    public GameObject root, panel;
    float speed = 10;
    float backup = 10;
    // Start is called before the first frame update
    void Start()
    {
        root = GameObject.Find("Directional Light");
        if (GameObject.Find("Canvas") != null)
        {
            panel = GameObject.Find("Canvas");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("ValueHolder") != null)
        {
            panel = GameObject.Find("ValueHolder");
            backup = panel.GetComponent<ValueHolder>().returnSpeed();
        }
        if (root.GetComponent<TheWorld>().returnCheck()) {
            function();
        }
    }

    void function()
    {
        speed = backup;
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
        if (transform.position.z < 5f)
        {
            Destroy(gameObject);
            root.GetComponent<TheWorld>().takeDamage();
        }
    }
}
