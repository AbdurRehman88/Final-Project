﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalCar : MonoBehaviour
{
   public static int CarType;

   public GameObject TrackWindow;



    public void BlackCar()
    {
        CarType = 1;
        TrackWindow.SetActive(true);
    }

    public void OrangeCar ()
    {
        CarType = 2;
        TrackWindow.SetActive(true);
    }
    public void SilverCar()
    {
        CarType = 3;
        TrackWindow.SetActive(true);
    }

}
