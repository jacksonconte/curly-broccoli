using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum GameState { MAINMENU, BUYPHASE, COMBATPHASE, TRAPPHASE, PAUSEMENU}

public class GameManager : MonoBehaviour
{
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

    void BuyPhase()
    {
        // TODO: hide battle UI and show buy UI
        GameObject battleUI = GameObject.Find("BattleUI");
        battleUI.SetActive(false);
        GameObject.Find("BuyUI").SetActive(true);
    }
}
