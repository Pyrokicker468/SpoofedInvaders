using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ValueHolder : MonoBehaviour
{
    public GameObject root, panel;
    float speed = 10;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("Canvas") != null)
        {
            panel = GameObject.Find("Canvas");
            speed = panel.GetComponent<Controller>().returnSpeed();
        }
    }

    public float returnSpeed()
    {
        return speed;
    }
}