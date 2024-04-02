using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IWeapon
{
    public float Damage { get; set; }
    public void Attack();
    static IWeapon CreateDefaultWeapon()
    {
        return new Bow();
    }
}
