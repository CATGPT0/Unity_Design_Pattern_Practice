using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public interface IDamageable
{
    public float Health { get; set; }
    public UnityEvent TakeDamageEvent { get; set; }
    public void TakeDamage(float damage);
}
