using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class DamageEngine
{
    public static void HandleDamage(IAttack attacker, IDamageable victim)
    {
        victim.TakeDamage(attacker.AttackDamage);
    }
}
