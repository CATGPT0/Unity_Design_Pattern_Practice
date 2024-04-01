using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IMove
{
    public float Speed { get; set; }
    public void Move(Vector3 direction);
}

