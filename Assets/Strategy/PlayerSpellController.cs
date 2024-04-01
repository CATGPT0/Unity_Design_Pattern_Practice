using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpellController : MonoBehaviour
{
    public Spell[] spells;

    public void CastSpell(int index)
    {
        spells[index].Cast(gameObject.transform);
    }

    void OnEnable()
    {
        SpellButtonTrigger.spellButtonTriggerEvent.AddListener(CastSpell);
    }

    void OnDisable()
    {
        SpellButtonTrigger.spellButtonTriggerEvent.RemoveListener(CastSpell);
    }
}
