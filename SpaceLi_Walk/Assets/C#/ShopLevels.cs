using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ShopLevels : MonoBehaviour
{
    public Text ShopLevel1;
    public Text ShopLevel2;
    public Text ShopLevel3;
    public Text ShopLevel4;

    private void Update()
    {
        ShopLevel1.text = "BATTERIES level " + Screen4.Batteries;
        ShopLevel2.text = "OXYGEN level " + Screen4.Oxygen;
        ShopLevel3.text = "STRENGTH level " + Screen4.Strength;
        ShopLevel4.text = "TRAINING level " + Screen4.Trainer;
    }
}
