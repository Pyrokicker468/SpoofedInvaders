using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class TheWorld : MonoBehaviour
{
    [ExecuteInEditMode]
    public SceneNode TheRoot;
    public TMP_Text healthText, deadText;
    public int health = 15;
    private int dead = 0;
    public GameObject canvas;
    private bool check = true;
    // Start is called before the first frame update
    void Start()
    {
        canvas.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        string sliderMessage = "Health: " + health;
        healthText.text = sliderMessage;
        sliderMessage = "Eliminations: " + dead;
        deadText.text = sliderMessage;
        Matrix4x4 i = Matrix4x4.identity;
        TheRoot.CompositeXform(ref i);
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            pauseMenu();
        }
    }

    public void deadAlien()
    {
        dead++;
        if (dead == 50)
        {
            SceneManager.LoadScene("WinScene", LoadSceneMode.Single);
        }
    }

    public void takeDamage()
    {
        health--;
        if (health == 0)
        {
            SceneManager.LoadScene("LoseScene", LoadSceneMode.Single); 
        }
    }

    public bool returnCheck()
    {
        return check;
    }

    public void pauseMenu()
    {
       canvas.SetActive(check);
       check = !check;
       
    }
}
