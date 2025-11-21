using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CoinsHandler : MonoBehaviour
{
    private int _coins;
    // Start is called before the first frame update
    //Constructor
    public CoinsHandler()
    { _coins = 0; }
    //Getter
    public int GetCoins() => _coins;

    //Setter
    public void SetCoins(int coins)
    {
        _coins += coins;
        Debug.Log("<color=Yellow>Il Player ha ottenuto: " + _coins + " Coins!</color>");
    }



}
