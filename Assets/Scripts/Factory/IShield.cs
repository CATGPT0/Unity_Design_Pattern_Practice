using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IShield
{
    public float ShieldValue { get; set; }
    public void Defend();
    static IShield CreateDefaultShield()
    {
        return new WoodenShield();
    }
}
