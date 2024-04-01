using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Waterball", menuName = "Spells/Waterball")]
public class Waterball : Spell
{
    [SerializeField]
    private GameObject prefab;
    public override GameObject Prefab => prefab;

    public override void Cast(Transform transform)
    {
        Debug.Log("Waterball casted!");
    }
}
