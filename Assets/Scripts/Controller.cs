using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Controller : MonoBehaviour
{
    public Slider GameWindowSlider, SpawnRateSlider, SpeedSlider;
    public Camera main;
    public Text GameWindowText, SpawnRatesText, SpeedText;
    public GameObject left, right;
    float speed = 10f;
    float spawnRate = 5;
    public GameObject root;

    void Start()
    {
        root = GameObject.Find("Directional Light");
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void resume()
    {
        root.GetComponent<TheWorld>().pauseMenu();
    }

    public void quit()
    {
        Application.Quit();
        Debug.Log("Quit Game");
    }

    public void updateGameWindowText()
    {
        string sliderMessage = "" + GameWindowSlider.value;
        GameWindowText.text = sliderMessage;
        right.transform.localPosition = new Vector3(GameWindowSlider.value - 60, right.transform.localPosition.y, right.transform.localPosition.z);
        left.transform.localPosition = new Vector3(-(GameWindowSlider.value + 30), left.transform.localPosition.y, left.transform.localPosition.z);
        main.fieldOfView = GameWindowSlider.value;
    }
    public void updateSpawnRatesText()
    {
        string sliderMessage = "" + SpawnRateSlider.value;
        SpawnRatesText.text = sliderMessage;
        spawnRate = SpawnRateSlider.value;

    }
    public void updateSpeedText()
    {
        string sliderMessage = "" + SpeedSlider.value;
        SpeedText.text = sliderMessage;
        speed = SpeedSlider.value;
    }

    public float returnSpeed()
    {
        return speed;
    }

    public float returnSpawnRate()
    {
        return spawnRate;
    }
}

