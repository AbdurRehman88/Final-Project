using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class optionC : MonoBehaviour
{
     void OnTriggerEnter()
    {
        ModeScore.CurrentScore -= 50;
        gameObject.SetActive(false);
    }
}
