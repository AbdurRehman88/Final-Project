using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Openoption : MonoBehaviour
{
     public GameObject choices8;
     public GameObject choices9;
     public GameObject choices10;
     public GameObject choices11;
     public GameObject choices12;
     public GameObject choices13;
     public GameObject choices14;
     
public GameObject ChoiceI;
 public GameObject ChoiceJ;
public GameObject ChoiceK;
public GameObject ChoiceL;
public GameObject ChoiceM;

public GameObject ChoiceO;
public GameObject ChoiceP;    

    void OnTriggerEnter()
    {
        choices8.SetActive(true);
        choices9.SetActive(true);
        choices10.SetActive(true);
        choices11.SetActive(true);
        choices12.SetActive(true);
        choices13.SetActive(true);
        choices14.SetActive(true); 
        ChoiceI.SetActive(true); 
        ChoiceJ.SetActive(true); 
        ChoiceK.SetActive(true); 
        ChoiceL.SetActive(true); 
        ChoiceM.SetActive(true); 
        
        ChoiceO.SetActive(true); 
        ChoiceP.SetActive(true);
    }
}
