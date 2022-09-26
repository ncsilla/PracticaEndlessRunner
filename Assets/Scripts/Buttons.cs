using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("escape"))
            {
            Exit();
            }
    }

    public void Exit()
    {
        Application.Quit();
    }

    public void NewGame()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void EndScene()
    {
        SceneManager.LoadScene("StartScene");
    }

}
