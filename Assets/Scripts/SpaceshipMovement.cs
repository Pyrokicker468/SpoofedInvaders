using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SpaceshipMovement : MonoBehaviour
{
    //Credit: https://www.tutorialspoint.com/unity/unity_basic_movement_scripting.htm
    public float speed;
    public GameObject root;
    public Slider GameWindowSlider;
    // Start is called before the first frame update
    void Start()
    {
        root = GameObject.Find("Directional Light");
    }

    // Update is called once per frame
    void Update()
    {
        if (root.GetComponent<TheWorld>().returnCheck())
        {
            function();
        }
    }

    void function()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float xPosition = Mathf.Clamp(transform.position.x + (h * speed), -(int)GameWindowSlider.value + 10, (int)GameWindowSlider.value - 40);

        gameObject.transform.position = new Vector2(xPosition, transform.position.y);
    }
}
