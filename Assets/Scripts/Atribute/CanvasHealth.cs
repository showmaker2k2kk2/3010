using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CanvasHealth : MonoBehaviour
{
    public Slider slidehealth;

    public void sethealth(int curenthealth)
    {
        slidehealth.value = curenthealth;
    }
    public void setUpMaxHealth(int mau_ban_dau)
    {
        slidehealth.maxValue = mau_ban_dau;
        //slidehealth.value = mau_ban_dau;
    }
}
