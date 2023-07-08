using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour
{
    public string unitName;
    public int unitLevel;

    public int damage;

    public int maxHP;
    public int currentHP;

    // Returns a bool indicating whether the unit is dead.
    public bool TakeDamage(int dmg)
    {
        currentHP -= dmg;
        return currentHP <= 0;
    }
}
