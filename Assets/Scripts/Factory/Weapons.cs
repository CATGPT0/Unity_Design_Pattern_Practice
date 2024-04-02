using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bow : IWeapon
{
    public float Damage { get; set; }

    public void Attack()
    {
        Debug.Log("Bow Attack");
    }
}

public class Sword : IWeapon
{
    public float Damage { get; set; }

    public void Attack()
    {
        Debug.Log("Sword Attack");
    }
}