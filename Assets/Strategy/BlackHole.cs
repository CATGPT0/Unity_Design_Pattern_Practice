using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Black Hole", menuName = "Spells/Black Hole")]
public class BlackHole : Spell
{
    [SerializeField]
    private GameObject prefab;
    public override GameObject Prefab => prefab;

    public override void Cast(Transform transform)
    {
        Debug.Log("Black hole casted!");
    }
}
