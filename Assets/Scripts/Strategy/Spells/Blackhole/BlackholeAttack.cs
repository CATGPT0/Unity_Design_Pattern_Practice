using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BlackholeAttack : MonoBehaviour, IAttack
{
    private float _attackDamage;
    private UnityEvent _attackEvent = new UnityEvent();

    public float AttackDamage { get => _attackDamage; set => _attackDamage = value; }
    public UnityEvent AttackEvent { get => _attackEvent; set => _attackEvent = value; }

    void Awake()
    {
        AttackEvent.AddListener(PlaySound);
    }

    private void PlaySound()
    {
        Debug.Log("Blackhole Attack Sound");
    }

    public void Attack()
    {
        _attackEvent.Invoke();
    }
}
