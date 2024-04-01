using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ISpellBuilder
{
    ISpellBuilder SetPrefab(GameObject prefab);
    ISpellBuilder SetSpeed(float speed);
    ISpellBuilder SetDamage(float damage);
    GameObject Build(Transform transform);
}
