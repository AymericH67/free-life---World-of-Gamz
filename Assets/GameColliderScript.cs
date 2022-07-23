using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameColliderScript : MonoBehaviour
{
    [SerializeField]
    private MarketButton marketButton;

    private void OnTriggerStay(Collider col)
    {
        if (col.tag == "Player")
        {
            marketButton.isInMarrket = false;
        }
    }
}
