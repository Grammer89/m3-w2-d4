using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D _rb;
    private Coin _coin;
    private Bomb _bomb;
    private Heal _heal;
    private float _time;
    // Start is called before the first frame update
    void Awake()
    {
        if (_rb == null)
        {
            _rb = GetComponent<Rigidbody2D>();
        }
    }

    private void Start()
    {
        _coin = (Coin)FindAnyObjectByType(typeof(Coin));
        _bomb = (Bomb)FindAnyObjectByType(typeof(Bomb));
        _heal = (Heal)FindAnyObjectByType(typeof(Heal));
    }

    private void Update()
    {
        if (Time.time - _time > 5f)
        {
            _coin = (Coin)FindAnyObjectByType(typeof(Coin));
            _bomb = (Bomb)FindAnyObjectByType(typeof(Bomb));
            _heal = (Heal)FindAnyObjectByType(typeof(Heal));
            if ((_bomb == null) && (_bomb == null) && (_bomb == null))
            {
                Debug.Log("<color=gold> Hai vinto </color>");
            }
            _time = Time.time;
        }
    }
    void FixedUpdate()
    {
        Vector2 vett = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));

        _rb.MovePosition(_rb.position + vett * Time.deltaTime * 10);
        //vett.x *= 2;
        //vett.y *= 2;
        //_rb.velocity = (vett);


    }

}

