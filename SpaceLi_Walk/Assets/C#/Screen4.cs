using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Screen4 : MonoBehaviour
{
    public static float Batteries = 1;
    public static float Oxygen = 1;
    public static float Strength = 1;
    public static float Trainer = 1;

    public void BatteriesPlus()
    {
        Batteries += 1;
    }
    public void BatteriesMinus()
    {
        Batteries -= 1;
    }
    public void OxygenPlus()
    {
        Oxygen += 1;
    }
    public void OxygenMinus()
    {
        Oxygen -= 1;
    }
    public void StrengthPlus()
    {
        Strength += 1;
    }
    public void StrengthMinus()
    {
        Strength -= 1;
    }
    public void TrainerPlus()
    {
        Trainer += 1;
    }
    public void TrainerMinus()
    {
        Trainer -= 1;
    }
}
