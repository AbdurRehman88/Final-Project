using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AICarTracking : MonoBehaviour
{
    public GameObject Point1;
    
    public GameObject Point2;
    
    public GameObject Point3;
    
    public GameObject Point4;
    
    public GameObject Point5;
    
    public GameObject Point6;
    
    public GameObject Point7;
    
    public GameObject Point8;

    public GameObject Point9;

    public GameObject Point10;

    public GameObject Point11;

    public GameObject Point12;

    public GameObject Point13;

    public GameObject Point14;

    public GameObject Point15;

    

    
    public GameObject Tracker;

    public int count;

      void Update()
    {
        if (count == 0)
        {
            Tracker.transform.position = Point1.transform.position;
        }
        if (count == 1)
        {
            Tracker.transform.position = Point2.transform.position;
        }
        if (count == 2)
        {
            Tracker.transform.position = Point3.transform.position;
        }
        if (count == 3)
        {
            Tracker.transform.position = Point4.transform.position;
        }
        if (count == 4)
        {
            Tracker.transform.position = Point5.transform.position;
        }
        if (count == 5)
        {
            Tracker.transform.position = Point6.transform.position;
        }
        if (count == 6)
        {
            Tracker.transform.position = Point7.transform.position;
        }
        if (count == 7)
        {
            Tracker.transform.position = Point8.transform.position;
        }
        if (count == 8)
        {
            Tracker.transform.position = Point9.transform.position;
        }
        if (count == 9)
        {
            Tracker.transform.position = Point10.transform.position;
        }
        if (count == 10)
        {
            Tracker.transform.position = Point11.transform.position;
        }
        if (count == 11)
        {
            Tracker.transform.position = Point12.transform.position;
        }
        if (count == 12)
        {
            Tracker.transform.position = Point13.transform.position;
        }
        if (count == 13)
        {
            Tracker.transform.position = Point14.transform.position;
        }
        if (count == 14)
        {
            Tracker.transform.position = Point15.transform.position;
        }

    }

      IEnumerator OnTriggerEnter(Collider c)
      {
          if (c.gameObject.tag == "AICar")
          {
              this.GetComponent<BoxCollider>().enabled = false;
              if (count == 15)
              {
                  count = 0;
              }
              count = count + 1;
              yield return new WaitForSeconds(0.02f);
              this.GetComponent<BoxCollider>().enabled = true;
             
          }
      }
}
