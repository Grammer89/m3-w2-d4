using System.Collections;
using System.Collections.Generic;
using System.Transactions;
using UnityEngine;

public class Mover
{
    private Rigidbody2D _rb;

    //Constructor
    public Mover(Rigidbody2D rb)
    { _rb = rb; }
    //Setter
    public void SetRigidBody2DGameObject(Rigidbody2D rb)
    { _rb = rb; }
    //Getter
    public Rigidbody2D GetRigidBody2DGameObject() => _rb;
    //Function
    public void Move(float h, float v)
    {
        Vector2 vett = new Vector2(h, v);
        _rb.MovePosition(_rb.position + vett * Time.deltaTime * 5);
    }
}
