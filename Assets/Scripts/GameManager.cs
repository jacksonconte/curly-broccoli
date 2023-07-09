using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum GameState { MAINMENU, BUYPHASE, COMBATPHASE, TRAPPHASE, PAUSEMENU}

public class GameManager : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI;
    public Array rooms = new Array[7];
    public int money;
    public int round = 0;
    public GameState state;


    // Start is called before the first frame update
    void Start()
    {
        state = GameState.BUYPHASE;
        BuyPhase();
    }

    // Pause Menu
    void Update() {
        if (Input.GetKeyDown(KeyCode.Escape)) {
            if(GameIsPaused) {
                Resume();
            }
            else {
                Pause();
            }
        }
    }
    
    // Resumes Game
    public void Resume() {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    // Pauses Game
    void Pause() {
        if (GameIsPaused) {
            pauseMenuUI.SetActive(true);
            Time.timeScale = 0f;
            GameIsPaused = true;
        }
    }

    public void LoadMenu() {
        Debug.Log("Loading Menu...");
    }

    public void QuitGame() {
        Debug.Log("Quiting Game...");
    }
    

    void BuyPhase()
    {
        // TODO: hide battle UI and show buy UI
        GameObject battleUI = GameObject.Find("BattleUI");
        battleUI.SetActive(false);
        GameObject.Find("BuyUI").SetActive(true);
    }
}