using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class optionCC : MonoBehaviour
{
     void OnTriggerEnter()
    {
        ModeScore.CurrentScore -= 50;
        gameObject.SetActive(false);
    }
}
