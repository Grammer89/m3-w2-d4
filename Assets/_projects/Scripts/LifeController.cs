using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class LifeController : MonoBehaviour
{
    [SerializeField] private int _healthLife;

    // Start is called before the first frame update

    //Constructor
    public LifeController( )
    {
    }
    public LifeController(int hp)
    {
        if (hp == 0)
        { _healthLife = 10; }
        else
        { _healthLife = hp; }
    }

    //Setter
    public void SetHealthPoint(int hp)
    {
        if (hp + _healthLife <= 0)
        {
            _healthLife = 0;
            Debug.Log("<color=grey>Player Morto</color>");
        }
        else
        {
            _healthLife = hp + _healthLife;
            Debug.Log("HP restanti: " + _healthLife);
        }
    }
    //Getter
    public int GetHealthPoint() => _healthLife;
    public void TakeDamage(int damage)
    { SetHealthPoint(damage); }
    public void TakeHeal(int heal)
    { SetHealthPoint(heal); }
}
