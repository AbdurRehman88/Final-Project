using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LapTimerDown : MonoBehaviour
{
    public GameObject miliLabel;

    public GameObject SecondLabel;
    
    public GameObject MinLabel;

    public static int min;

    public static int sec;

    public static float mili;
 
    void Update()
    {
        mili = mili + Time.deltaTime * 10;
        miliLabel.GetComponent<Text>().text = "" + mili.ToString("F0");
        if (mili > 9)
        {
            sec = sec + 1;
            mili = 0;
        }
        if (sec >= 0 && sec < 10)
        {
            SecondLabel.GetComponent<Text>().text = "0" + sec.ToString() + ".";
        }
        else if (sec >= 10 && sec <= 59)
        {
            SecondLabel.GetComponent<Text>().text = "" + sec.ToString() + ".";
        }
        else if (sec == 60)
        {
            sec = 0;
            min = min + 1;
        }
        if (min >= 0 && min < 10)
        {
           MinLabel.GetComponent<Text>().text = "0" + min.ToString() + ":";
        }
        else if (min >= 10 && min <= 59)
        {
            MinLabel.GetComponent<Text>().text = "" + min .ToString() + ":";
        }
    }
}
