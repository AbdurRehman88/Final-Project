using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;

public class FinishRace : MonoBehaviour
{
    public GameObject Car;
    public GameObject AICar;
    
    public GameObject FinishCamera;

    public GameObject NormalCamera;

    public GameObject FinishPoint;

    public AudioSource FinishSound;


    void OnTriggerEnter()
    {
        if (ModeTime.isTimeMode == true)
        {

        }
        else {
            this.GetComponent<BoxCollider>().enabled = false;
            Car.SetActive(false);
            CarController.m_Topspeed = 0.0f;
            Car.GetComponent<CarController>().enabled = false;
            Car.GetComponent<CarUserControl>().enabled = false;
            Car.SetActive(true);

            this.GetComponent<BoxCollider>().enabled = false;
            AICar.SetActive(false);
            

            FinishCamera.SetActive(true);
            NormalCamera.SetActive(false);
            FinishSound.Play();
            GlobalCash.TotalCash += 100;
            PlayerPrefs.SetInt("SavedCash", GlobalCash.TotalCash);

        }
        
    }
}
