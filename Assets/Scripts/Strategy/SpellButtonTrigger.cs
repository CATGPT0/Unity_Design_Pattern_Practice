using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.Events;

public class SpellButtonTrigger : MonoBehaviour
{
    public Button[] spellButtons;
    public static UnityEvent<int> spellButtonTriggerEvent = new UnityEvent<int>();

    void Awake()
    {
        for (int i = 0; i < spellButtons.Length; i++)
        {
            int index = i;
            spellButtons[i].onClick.AddListener(() => spellButtonTriggerEvent.Invoke(index));
        }
    }
}
