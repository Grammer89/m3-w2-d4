using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    [SerializeField] int _damage = 1;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (_damage == 0)
        { _damage = 1; }

        if (other.CompareTag("Player"))
        {
            //Debug.Log("Player Intercettato");
            gameObject.SetActive(false);
            Destroy(gameObject, 2f);
            Debug.Log("<color=orange>BOOM</color>");


            LifeController myHealthComponent = other.GetComponent<LifeController>();
            if (myHealthComponent)
            {
                myHealthComponent.TakeDamage(-_damage);
                //check se player è morto
                if (myHealthComponent.GetHealthPoint() == 0)
                {
                    other.gameObject.SetActive(false);
                    Destroy(other.gameObject, 5);
                    Debug.Log("<color=red>VOLEEEEEEEEEEVI VINCERE</color>");
                }
            }

        }
    }
}


