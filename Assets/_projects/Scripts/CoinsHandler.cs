using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CoinsHandler : MonoBehaviour
{
    [SerializeField] private int _coins = 0;
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
        Debug.Log("Il Player ha ottenuto: " + _coins + " Coins!");
    }

}
