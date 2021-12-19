using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockedObjects : MonoBehaviour
{
    public int silverSelect;

    public GameObject fakeSilver;
    
    void Start()
    {
        silverSelect = PlayerPrefs.GetInt("SilverBought");
        if (silverSelect == 100)
        {
            fakeSilver.SetActive(false);
        }
    }

   
}
