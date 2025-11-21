using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            CoinsHandler myCoins = other.GetComponent<CoinsHandler>();
            myCoins.SetCoins(1);

            gameObject.SetActive(false);
            Destroy(gameObject, 2f);
            Debug.Log("<color=Yellow>CAAAASH</color>");

        }
    }
}
