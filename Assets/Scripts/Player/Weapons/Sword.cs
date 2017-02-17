using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword : PlayerWeapon
{

    void Start()
    {
        attack = 20;
        defense = 5;
        attackSpeed = 0.75f;
        attackRange = 1f;
    }

    void Update()
    {

    }
}
