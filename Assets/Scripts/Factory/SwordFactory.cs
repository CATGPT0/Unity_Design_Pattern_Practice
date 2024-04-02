using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "SwordFactory", menuName = "Factory/SwordFactory")]
public class SwordFactory : WeaponFactory
{
    [SerializeField] private GameObject _swordPrefab;
    public override GameObject WeaponPrefab => _swordPrefab;

    public override IWeapon CreateWeapon()
    {
        return new Sword();
    }
    public override WeaponEntity CreateWeaponObject()
    {
        var weapon = CreateWeapon();
        var weaponObject = new GameObject("Sword").AddComponent<WeaponEntity>();
        weaponObject.Weapon = weapon;
        return weaponObject;
    }
}
