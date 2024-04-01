using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackholeMove : MonoBehaviour, IMove
{
    private float _speed;
    public float Speed { get => _speed; set => _speed = value;}

    public void Move(Vector3 direction)
    {
        transform.position += direction * Speed * Time.deltaTime;
    }
}
