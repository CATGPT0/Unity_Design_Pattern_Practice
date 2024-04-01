using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BlackholeDestroy : MonoBehaviour, ISelfDestroy
{
    private float _destroyTime;
    public float DestroyTime { get => _destroyTime; set => _destroyTime = value; }
    private UnityEvent _destroyEvent = new UnityEvent();
    public UnityEvent DestroyEvent { get => _destroyEvent; set => _destroyEvent = value; }

    void Awake()
    {
        DestroyEvent.AddListener(PlayerSound);
    }

    void Start()
    {
        SelfDestroy();
    }
    
    private void PlayerSound()
    {
        Debug.Log("Blackhole Destroy Sound");
    }

    public void SelfDestroy()
    {
        Destroy(gameObject, DestroyTime);
    }

    void OnDestroy()
    {
        DestroyEvent.Invoke();
    }
}
