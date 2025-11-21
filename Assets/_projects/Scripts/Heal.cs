using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heal : MonoBehaviour
{
    [SerializeField] int _heal = 1;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (_heal == 0)
        { _heal = 1; }

        if (other.CompareTag("Player"))
        {

            LifeController myHealthComponent = other.GetComponent<LifeController>();
            if (myHealthComponent)
            {
                myHealthComponent.TakeHeal(_heal);
            }
            gameObject.SetActive(false);
            Destroy(gameObject, 2f);
            Debug.Log("<color=green>Sto meglio grazie</color>");

        }
    }
}
