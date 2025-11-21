using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D _rb;
    private Coin _coin;
    private float _time;
    // Start is called before the first frame update
    void Awake()
    {

        _rb = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        _coin = (Coin)FindAnyObjectByType(typeof(Coin));

    }

    private void Update()
    {
        if (Time.time - _time > 3f)
        {
            _coin = (Coin)FindAnyObjectByType(typeof(Coin));

            if (_coin == null)
            {
                gameObject.SetActive(false);
                Debug.Log("<color=gold> Hai vinto </color>");
                Destroy(gameObject, 2f);
            }
            _time = Time.time;
        }
    }
    void FixedUpdate()
    {
        Vector2 vett = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));

        //_rb.MovePosition(_rb.position + vett * Time.deltaTime * 10);
        _rb.MovePosition(_rb.position + vett * (Time.deltaTime * 10));//Perche non va?

        ////vett.x *= 10;
        ////vett.y *= 10;
        ////_rb.velocity = (vett);


    }

}

