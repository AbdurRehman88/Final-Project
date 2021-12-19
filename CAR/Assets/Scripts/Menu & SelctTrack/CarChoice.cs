using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarChoice : MonoBehaviour
{
    public GameObject BlackBody;
    public GameObject OrangeBody;
    public GameObject SilverBody;

    public int CarImport;

    void Start()
    {
        CarImport = GlobalCar.CarType;
        if (CarImport == 1)
        {
            BlackBody.SetActive(true);
        }
        if (CarImport == 2)
        {
            OrangeBody.SetActive(true);
        }
        if (CarImport == 3)
        {
            SilverBody.SetActive(true);
        }
    }

    
}
