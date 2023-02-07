using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void quit()
    {
        Application.Quit();
        Debug.Log("Quit Game");
    }

    public void again()
    {
        SceneManager.LoadScene("GameScene", LoadSceneMode.Single);
    }

    public void credits()
    {
        SceneManager.LoadScene("Credits", LoadSceneMode.Single);
    }

    public void startScene()
    {
        SceneManager.LoadScene("StartScreen", LoadSceneMode.Single);
    }
}
