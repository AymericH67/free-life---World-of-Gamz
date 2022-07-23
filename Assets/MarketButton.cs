using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarketButton : MonoBehaviour
{
    public bool isInMarrket = false;

    [SerializeField]
    private GameObject exitMarketButton;
    [SerializeField]
    private GameObject cabineTelephoniquePositions;
    [SerializeField]
    private GameObject Player;
    private void OnTriggerStay(Collider col)
    {
        if (col.tag == "Player")
        {
            isInMarrket = true;
        }
    }

    private void Update()
    {
        if (isInMarrket  == true)
        {
            exitMarketButton.SetActive(true);
        }
        else
        {
            exitMarketButton.SetActive(false);
        }
    }

    public void ExitMarketButton()
    {
        Player.transform.position = cabineTelephoniquePositions.transform.position;
    }
}
