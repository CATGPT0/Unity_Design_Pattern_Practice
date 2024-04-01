using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Iceball", menuName = "Spells/Iceball")]
public class Iceball : Spell
{
    [SerializeField]
    private GameObject prefab;
    public override GameObject Prefab => prefab;

    public override void Cast(Transform transform)
    {
        Debug.Log("Iceball casted!");
    }
}
