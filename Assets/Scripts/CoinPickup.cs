using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPickup : MonoBehaviour
{
    CapsuleCollider2D myBodyCollider2D;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject);
    }

}
