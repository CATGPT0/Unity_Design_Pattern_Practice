using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class WeaponFactory : ScriptableObject
{
    public abstract GameObject WeaponPrefab { get; }
    public abstract IWeapon CreateWeapon();
    public abstract WeaponEntity CreateWeaponObject();
}
