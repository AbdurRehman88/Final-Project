﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class optionB : MonoBehaviour
{
    void OnTriggerEnter()
    {
        ModeScore.CurrentScore -= 50;
        gameObject.SetActive(false);
    }
}
