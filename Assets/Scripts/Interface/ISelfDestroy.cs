using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public interface ISelfDestroy
{
    public float DestroyTime { get; set; }
    public UnityEvent DestroyEvent { get; set; }
    public void SelfDestroy();
}
