using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinishPoint : MonoBehaviour
{
    public GameObject MinLabelBest;

    public GameObject SecLabelBest;

    public GameObject MiliLabelBest;

    public GameObject FPoint;

    public GameObject HalfPoint;

    public GameObject LapsCounterLabel;

    public GameObject RaceFinish;



    public int lapscounter;

    void OnTriggerEnter()
    {
        lapscounter = lapscounter + 1;
        if (lapscounter == 2)
        {
            RaceFinish.SetActive(true);
        }
        MiliLabelBest.GetComponent<Text>().text = "" +LapTimerDown.mili.ToString("F0");

        if (LapTimerDown.sec >= 0 && LapTimerDown.sec < 10)
        {
            SecLabelBest.GetComponent<Text>().text = "0" + LapTimerDown.sec.ToString() + ".";
        }
        else if (LapTimerDown.sec >= 10 && LapTimerDown.sec <= 59)
        {
            SecLabelBest.GetComponent<Text>().text = "" + LapTimerDown.sec.ToString() + ".";
        }

        if (LapTimerDown.min >= 0 && LapTimerDown.min < 10)
        {
            MinLabelBest.GetComponent<Text>().text = "0" + LapTimerDown.min.ToString() + ":";
        }
        else if (LapTimerDown.min >= 10 && LapTimerDown.min <= 59)
        {
            MinLabelBest.GetComponent<Text>().text = "" + LapTimerDown.min.ToString() + ":";
        }
        LapsCounterLabel.GetComponent<Text>().text = "" + lapscounter;
        LapTimerDown.mili = 0;
        LapTimerDown.sec = 0;
        LapTimerDown.min = 0;

        FPoint.SetActive(false);
        HalfPoint.SetActive(true);
    }
}
