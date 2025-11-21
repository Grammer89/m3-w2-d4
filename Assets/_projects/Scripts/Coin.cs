using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] private int _coins = 1;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (_coins == 0)
        { _coins = 1; }
        if (other.CompareTag("Player"))
        {
            CoinsHandler myCoins = other.GetComponent<CoinsHandler>();
            if (myCoins)
            {
                Debug.Log("Prende " + _coins + "Coins");
                myCoins.SetCoins(_coins);
            }
            gameObject.SetActive(false);
            Destroy(gameObject, 2f);
            Debug.Log("<color=Yellow>CAAAASH</color>");

        }
    }
}
