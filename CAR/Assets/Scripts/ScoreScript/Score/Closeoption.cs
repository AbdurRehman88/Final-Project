using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Closeoption : MonoBehaviour
{
     public GameObject choices1;
     public GameObject choices2;
     public GameObject choices3;
     public GameObject choices4;
     public GameObject choices5;
     public GameObject choices6;
     public GameObject choices7;
     public GameObject optionOpen;
     

    void OnTriggerEnter()
    {
        choices1.SetActive(false);
        choices2.SetActive(false);
        choices3.SetActive(false);
        choices4.SetActive(false);
        choices5.SetActive(false);
        choices6.SetActive(false);
        choices7.SetActive(false);
        optionOpen.SetActive(true);  
        
    }
}
