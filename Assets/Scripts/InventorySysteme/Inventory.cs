using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    [SerializeField]
    private List<ItemData> content = new List<ItemData>();

    [SerializeField]
    private GameObject inventoryPanel;

    [SerializeField]
    private Transform inventorySlotsParent;

    const int InventorySize = 24;

    [Header("Action Panel References")]

    [SerializeField]
    private GameObject actionspanel;

    [SerializeField]
    private GameObject useItemButton;

    [SerializeField]
    private GameObject equipeItemButton;

    [SerializeField]
    private GameObject dropItemButton;

    [SerializeField]
    private GameObject destroyItemButton;

    [SerializeField]
    private Sprite emptySlotsVisuals;

    private ItemData itemCurrentlySelected;

    [SerializeField]
    private Transform dropPoint;

    public static Inventory instance;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        RefreshContent();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            inventoryPanel.SetActive(!inventoryPanel.activeSelf);
        }
    }

    public void AddItem(ItemData item)
    {
        content.Add(item);
        RefreshContent();
    }

    public void CloseInventory()
    {
        inventoryPanel.SetActive(false);
    }

    private void RefreshContent()
    {
        // on vide teou les slot 
        for (int i = 0; i < inventorySlotsParent.childCount; i++)
        {
            Slot currentSlot = inventorySlotsParent.GetChild(i).GetComponent<Slot>();

            currentSlot.item = null;
            currentSlot.itemVisual.sprite = emptySlotsVisuals;
        }

        // on peuple le contenue des slots
        for (int i = 0; i < content.Count; i++)
        {
            Slot currentSlot = inventorySlotsParent.GetChild(i).GetComponent<Slot>();

            currentSlot.item = content[i];
            currentSlot.itemVisual.sprite = content[i].visual;
        }
    }

    public bool IsFull()
    {
        return InventorySize == content.Count;
    }

    public void OpenActionPalnel(ItemData item, Vector3 slotPosition)
    {
        itemCurrentlySelected = item;

        if(item == null)
        {
            actionspanel.SetActive(false);
            return;
        }

        switch (item.itemType)
        {
            case ItemType.Ressources:
                useItemButton.SetActive(false);
                equipeItemButton.SetActive(false);
                break;
            case ItemType.Equipement:
                useItemButton.SetActive(false);
                equipeItemButton.SetActive(true);
                break;
            case ItemType.Consomable:
                useItemButton.SetActive(true);
                equipeItemButton.SetActive(false);
                break;
        }

        actionspanel.transform.position = slotPosition;
        actionspanel.SetActive(true);
    }

    public void CloseActionPanel()
    {
        actionspanel.SetActive(false);
        itemCurrentlySelected = null;
    }

    public void UseActionButton()
    {
        print(" use item : " + itemCurrentlySelected.name);
        CloseActionPanel();
    }

    public void EquipeActionButton()
    {
        print(" equipe item : " + itemCurrentlySelected.name);
        CloseActionPanel();
    }

    public void DropActionButton()
    {
        GameObject instantiatedItem = Instantiate(itemCurrentlySelected.prefab);
        instantiatedItem.transform.position = dropPoint.position;
        content.Remove(itemCurrentlySelected);
        RefreshContent();
        CloseActionPanel();
    }

    public void DestroyActionButton()
    {
        content.Remove(itemCurrentlySelected);
        RefreshContent();
        CloseActionPanel();
    }
}
