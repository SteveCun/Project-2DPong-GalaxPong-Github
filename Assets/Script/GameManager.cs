using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //public  int PlayerScoreL = 0;
   // public  int PlayerScoreR = 0;

    //Buat UI Text
    //public TMP_Text txtPlayerScoreL;
    //public TMP_Text txtPlayerScoreR;
    
    [Header ("Variable untuk Score")]
    public int PlayerScoreL;
    public int PlayerScoreR;

    [Header ("Text untuk Score")]
    public TMP_Text txtPlayerScoreL;
    public TMP_Text txtPlayerScoreR;

    [Header ("Panel Player Win")]
    public GameObject panelWin;
    public TMP_Text playerWin;



    public static GameManager instance;
    public SceneManagement sm;
    public void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        //Mengisikan nilai integer PlayerScore ke UI
        //txtPlayerScoreL.text = PlayerScoreL.ToString();
        //txtPlayerScoreR.text = PlayerScoreR.ToString();

        panelWin.SetActive(false);
    }


    //Method penyeleksi untuk menambah score
    public void Score(string wallID)
    {
        if (wallID == "Line L")
        {
            PlayerScoreR = PlayerScoreR + 10; //Menambah score
            txtPlayerScoreR.text = PlayerScoreR.ToString(); //Mengisikan nilai integer PlayerScore ke UI
            ScoreCheck();
        }
        else
        {
            PlayerScoreL = PlayerScoreL + 10;
            txtPlayerScoreL.text = PlayerScoreL.ToString();
            ScoreCheck();
        }
    }

    public void ScoreCheck()
    {
        if (PlayerScoreL == 100)
        {
            panelWin.SetActive(true);
            playerWin.text = "Player L Win !!!";
            Invoke ("ChangeTheScene",2f);
            //Debug.Log("playerL win");
            //this.gameObject.SendMessage("ChangeScene","MainMenu");
        }
        else if (PlayerScoreR == 100)
        {
            panelWin.SetActive(true);
            playerWin.text = "Player R Win !!!";
            Invoke ("ChangeTheScene",2f);
           // Debug.Log("playerR win");
            // this.gameObject.SendMessage("ChangeScene", "MainMenu");
        }
    }

    public void ChangeTheScene()
    {
       // this.gameObject.SendMessage("ChangeTheScene","MainMenu");
       sm.ChangeScene("MainMenu");
    }


}