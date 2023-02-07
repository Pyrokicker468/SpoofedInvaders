using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SpawnEnemies : MonoBehaviour
{
    
    public GameObject drone, panel;
    public Slider GameWindowSlider;
    public GameObject root;
    float seconds = 5;
    float backup = 5;
    float count = 0;
    bool flag = false;
    // Start is called before the first frame update
    void Start()
    {
        root = GameObject.Find("Directional Light");
        if (GameObject.Find("Canvas") != null)
        {
            panel = GameObject.Find("Canvas");
        }
        Invoke("flagTrue", 4);
    }

    void flagTrue()
    {
        flag = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("Canvas") != null)
        {
            panel = GameObject.Find("Canvas");
            backup = panel.GetComponent<Controller>().returnSpawnRate();
        }
        if (flag)
        {
            if (root.GetComponent<TheWorld>().returnCheck())
            {
                function();
            }
        }
    }

    void function()
    {
        seconds = backup;
        System.Random rnd = new System.Random();
        count += Time.deltaTime * 3;
        if (count > seconds)
        {
            int numx = rnd.Next((int)(-(GameWindowSlider.value) + 30), (int)GameWindowSlider.value - 60);
            int numy = rnd.Next(-20, 25);
            GameObject droneObject = Instantiate(drone, new Vector3(numx, numy, 90), Quaternion.identity);
            droneObject.transform.eulerAngles = new Vector3(
                droneObject.transform.eulerAngles.x,
                droneObject.transform.eulerAngles.y + 180,
                droneObject.transform.eulerAngles.z
);
            count = 0;
        }
    }
}
