using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponEntity : MonoBehaviour
{
    private IWeapon _weapon;
    public IWeapon Weapon { get => _weapon; set => _weapon = value; }
}
