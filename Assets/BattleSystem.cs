using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// waiting state used for animations to disable buttons
public enum BattleState { START, PLAYERTURN, ENEMYTURN, WON, LOST, WAITING }
public class BattleSystem : MonoBehaviour
{
    public GameObject monsterPrefab;
    public GameObject heroPrefab;

    public Transform monsterStation;
    public Transform heroStation;

    Unit monsterUnit;
    Unit heroUnit;

    public BattleState state;

    // Start is called before the first frame update
    void Start()
    {
        state = BattleState.START;
        SetUpBattle();
    }

    void SetUpBattle()
    {
        GameObject monster = Instantiate(monsterPrefab, monsterStation);
        monsterUnit = monster.GetComponent<Unit>();
        GameObject hero = Instantiate(heroPrefab, heroStation);
        heroUnit = hero.GetComponent<Unit>();

        // TODO: Update health bars, UI

        state = BattleState.PLAYERTURN;
        PlayerTurn();
    }

    void PlayerTurn()
    {
        // TODO: update UI
    }

    IEnumerator EnemyTurn()
    {
        // Enemy always attacks for now
        // TODO: Update UI
        yield return new WaitForSeconds(2f);
        state = BattleState.WAITING;

        // enemy attack
        bool isDead = monsterUnit.TakeDamage(heroUnit.damage);

        // TODO: start animation
        if (isDead)
        {
            state = BattleState.LOST;
            // TODO: end battle
        } else
        {
            state = BattleState.PLAYERTURN;
            PlayerTurn();
        }
    }

    IEnumerator PlayerAttack()
    {    
        bool isDead = heroUnit.TakeDamage(monsterUnit.damage);

        // TODO: start animation
        yield return new WaitForSeconds(2f);
        state = BattleState.WAITING;

        if (isDead)
        {
            state = BattleState.WON;
            // TODO: end battle
        }
        else
        {
            state = BattleState.ENEMYTURN;
            StartCoroutine(EnemyTurn());
        }
    }

    public void OnAttackButton()
    {
        if (state != BattleState.PLAYERTURN)
            return;
        StartCoroutine(PlayerAttack());       
    }
}
