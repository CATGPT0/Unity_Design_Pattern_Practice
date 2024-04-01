using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Spell : ScriptableObject
{
    public abstract GameObject Prefab { get; }
    public abstract void Cast(Transform transform);
}
