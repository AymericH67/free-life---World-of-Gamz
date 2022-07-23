using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CabineTelephoniquePassword : MonoBehaviour
{
    [SerializeField]
    public InputField passwordInputField;

    [SerializeField]
    public string password;
    
    [SerializeField]
    private string GameScene;

    [SerializeField]
    private GameObject Player;

    [SerializeField]
    private GameObject TeleportePoint;

    [SerializeField]
    private GameObject cabineTelephoniquePasswordPanel;

    public bool reussit = false;
    void Update()
    {
        // l input "return" signifie entrer
        if(passwordInputField.text == password && Input.GetKeyDown("return"))
        {
            reussit = true;
            cabineTelephoniquePasswordPanel.SetActive(false);
            if(reussit == true)
            {
                Player.transform.position = TeleportePoint.transform.position;
            }
        }
        else
        {
            reussit = false;
        }
    }

    public void ReturnButton()
    {
        cabineTelephoniquePasswordPanel.SetActive(false);
    }
}
