using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class Escape : MonoBehaviour
{
    public static bool GameIsPaused = false;

    public GameObject Escapee;

    void Update()
    {
      if(Input.GetKeyDown(KeyCode.Escape))
        {
            if (!GameIsPaused)
            {
                Pause();
            }
        }
    }
    void Resume()
    {
        Escapee.SetActive(false);

        Debug.Log("Lanjut");
        Time.timeScale = 1f;
        GameIsPaused = false;

    }

    void Pause()
    {
        Escapee.SetActive(true);
        Debug.Log("Bentar Ye");
        /*ScoreC.SetActive(false);*/
        Time.timeScale = 0f;
        GameIsPaused = true;


    }
    public void ChangeScenee(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
        Resume();
    }
    public void QuitApp()
    {
        Application.Quit();
    }

    public void ChangeLoadScene(string sceneName)
    {
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Debug.Log("Ganti LoadScene");
        Resume();
    }

    public void OnResumeButtonClicked()
    {
        Resume();
    }





}