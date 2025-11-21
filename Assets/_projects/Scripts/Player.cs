using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[Serializable]
public class Player
{
    [SerializeField] private int _healthLife;
    private int _coins;
    private Rigidbody2D _rb;

    public Player()
    { }
}
