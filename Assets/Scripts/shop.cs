using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class shop : MonoBehaviour
{
    public Inventory inventory;
    public PlayerCoins playerCoins;

    [Header("instance du produit dans ItemData")]
    public ItemData priduit1;
    public ItemData priduit2;
    public ItemData priduit3;
    public ItemData priduit4;
    public ItemData priduit5;
    public ItemData priduit6;

    [Header("Prix du produit")]
    public int priduit1price;
    public int priduit2price;
    public int priduit3price;
    public int priduit4price;
    public int priduit5price;
    public int priduit6price;

    public void ProdiutButton1()
    {
        if (playerCoins.coins >= priduit1price)
        {
            inventory.AddItem(priduit1);
        }
        else
        {
            print("vous n'avez pas asser d'argent");
        }
    }

    public void ProdiutButton2()
    {
        if (playerCoins.coins >= priduit2price)
        {
            inventory.AddItem(priduit2);
        }
        else
        {
            print("vous n'avez pas asser d'argent");
        }
    }

    public void ProdiutButton3()
    {
        if (playerCoins.coins >= priduit3price)
        {
            inventory.AddItem(priduit3);
        }
        else
        {
            print("vous n'avez pas asser d'argent");
        }
    }

    public void ProdiutButton4()
    {
        if (playerCoins.coins >= priduit4price)
        {
            inventory.AddItem(priduit4);
        }
        else
        {
            print("vous n'avez pas asser d'argent");
        }
    }

    public void ProdiutButton5()
    {
        if (playerCoins.coins >= priduit5price)
        {
            inventory.AddItem(priduit5);
        }
        else
        {
            print("vous n'avez pas asser d'argent");
        }
    }

    public void ProdiutButton6()
    {
        if (playerCoins.coins >= priduit6price)
        {
            inventory.AddItem(priduit6);
        }
        else
        {
            print("vous n'avez pas asser d'argent");
        }
    }
}
