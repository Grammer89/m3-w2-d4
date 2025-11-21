using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            //Debug.Log("Player Intercettato");
            gameObject.SetActive(false);
            Destroy(gameObject, 2f);
            Debug.Log("<color=orange>BOOM</color>");

            //check se player è morto
            LifeController myHealthComponent = other.GetComponent<LifeController>();
            myHealthComponent.TakeDamage(-1);
            if (myHealthComponent.GetHealthPoint() == 0)
            {
                other.gameObject.SetActive(false);
                Destroy(other.gameObject, 5);
                Debug.Log("<color=red>VOLEEEEEEEEEEVI VINCERE</color>");
            }

        }
    }

}
