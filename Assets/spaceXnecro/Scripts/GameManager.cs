using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject panelWin;

    public SceneHandler sceneHandler;

    public string strPlayerL, strPlayerR;

    public TMP_Text UIPlayerWin;

    public int PlayerScoreL;

    public int PlayerScoreR;

    public TMP_Text UIPlayerScoreL;

    public TMP_Text UIPlayerScoreR;

    public static GameManager instance;

    private void Awake()
    {
        if (instance == null) instance = this;
        else Destroy (gameObject);        
    }

    private void Start()
    {
        PlayerScoreL = 0;
        PlayerScoreR = 0;

        UIPlayerScoreL.text = PlayerScoreL.ToString();
        UIPlayerScoreR.text = PlayerScoreR.ToString();
    }

    public void Scoring(string wallID)
    {
        if (wallID == "Wall L")
        {
            PlayerScoreR = PlayerScoreR + 10;
            UIPlayerScoreR.text = PlayerScoreR.ToString();
            ScoreCheck();

        }
        else
        {
            PlayerScoreL = PlayerScoreL + 10;
            UIPlayerScoreL.text = PlayerScoreL.ToString();
            ScoreCheck();
        }
        
    }

    private void ChangeSceneAfter()
    {
        Invoke("ChangeSceneToMenu", 2f);
    }

    private void ChangeSceneToMenu()
    {
        sceneHandler.ChangeSceneTo("Menu");
    }
    public void ScoreCheck()
    {
        if (PlayerScoreL == 100)
        {
            Debug.Log("Player L Win!");
            UIPlayerWin.text = strPlayerL;
            panelWin.SetActive(true);
            ChangeSceneAfter();
        }
        else if ( PlayerScoreR == 100)
        {
            Debug.Log("Player R Win!");
            UIPlayerWin.text = strPlayerR;
            panelWin.SetActive(true);
            ChangeSceneAfter();
        }
    }

}
