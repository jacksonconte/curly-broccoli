using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum GameState { MAINMENU, BUYPHASE, COMBATPHASE, TRAPPHASE, PAUSEMENU}

public class GameManager : MonoBehaviour
{
    public Array rooms = new Array[7];
    public int money;
    public GameState state;


    // Start is called before the first frame update
    void Start()
    {
        state = GameState.BUYPHASE;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
