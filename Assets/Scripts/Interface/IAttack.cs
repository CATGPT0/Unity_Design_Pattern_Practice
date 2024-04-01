using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public interface IAttack
{
    public float AttackDamage { get; set; }
    public UnityEvent AttackEvent { get; set; }
    public void Attack();
}
