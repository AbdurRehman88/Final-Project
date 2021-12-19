using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Unlockables : MonoBehaviour
{
    public GameObject silverButton;
    public int cashValue;
    void Update()
    {
        cashValue = GlobalCash.TotalCash;
        if (cashValue >= 100)
        {
            silverButton.GetComponent<Button>().interactable = true;
        }
    }
    public void SilverUnlock()
    {
        silverButton.SetActive(false);
        cashValue -= 100;
        GlobalCash.TotalCash -= 100;
        PlayerPrefs.SetInt("SavedCash", GlobalCash.TotalCash);
        PlayerPrefs.SetInt("SilverBought", 100);

    }
}
