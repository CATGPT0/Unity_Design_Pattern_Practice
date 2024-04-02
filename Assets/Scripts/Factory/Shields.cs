using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WoodenShield : IShield
{
    public float ShieldValue { get; set; }

    public void Defend()
    {
        Debug.Log("Defending with Wooden Shield");
    }
}

public class IronShield : IShield
{
    public float ShieldValue { get; set; }

    public void Defend()
    {
        Debug.Log("Defending with Iron Shield");
    }
}