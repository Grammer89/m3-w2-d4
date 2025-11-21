using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heal : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {

            LifeController myHealthComponent = other.GetComponent<LifeController>();
            myHealthComponent.TakeHeal(1);

            gameObject.SetActive(false);
            Destroy(gameObject, 2f);
            Debug.Log("<color=green>Sto meglio grazie</color>");

        }
    }
}
