using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CabineTelephoniqueSysteme : MonoBehaviour
{
    [SerializeField]
    private GameObject EnterText;

    [SerializeField]
    private GameObject Player;

    [SerializeField]
    public GameObject TeleporteDestination;

    private bool isInCabine = false;

    public string MotDePasseCabineTelephoniqueScene;

    [SerializeField]
    private CabineTelephoniquePassword cabineTelephoniquePassword;

    [SerializeField]
    private GameObject cabineTelephoniquePasswordPanel;

    private void OnTriggerEnter(Collider col)
    {
        if(col.tag == "Player")
        {
            EnterText.SetActive(true);
            isInCabine = true;  
        }
    }

    private void OnTriggerExit(Collider col)
    {
        if (col.tag == "Player")
        {
            EnterText.SetActive(false);
            isInCabine = false;
        }
    }

    private void Update()
    {
        if (isInCabine == true)
        {
            if(Input.GetKeyDown(KeyCode.E))
            {
                cabineTelephoniquePasswordPanel.SetActive(true);
            }
        }
    }
}
