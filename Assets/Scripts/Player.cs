using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Player : MonoBehaviour
{
    public string Name;
    public int Health;
    public TMP_Text Text;

    private Inventory playerInventory;
    private float delay;

    private void Start()
    {
        //Create an inventory object and set some values. An "object" is an instance of a class.
        playerInventory = new Inventory()
        {
            Points = 0,
            Points2 = 0
        };
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            playerInventory.Points++;
        }
        if (Input.GetMouseButtonDown(1))
        {
            playerInventory.Points2++;
        }
        Text.text = Name + "\nLeft Clicks: " + playerInventory.Points + "\nRight Clicks " + playerInventory.Points2;

    }

   
}
