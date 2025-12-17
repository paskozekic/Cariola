using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    public void LoadLevel(int lvl)
    {
        SceneManager.LoadScene(lvl);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
