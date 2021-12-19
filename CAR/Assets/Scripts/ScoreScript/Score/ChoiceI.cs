using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChoiceI : MonoBehaviour
{
//public GameObject choices1;

    void OnTriggerEnter()
    {
        ModeScore.CurrentScore += 100;
        gameObject.SetActive(false);
        //choices1.SetActive(TRUE);
        
    }
}
