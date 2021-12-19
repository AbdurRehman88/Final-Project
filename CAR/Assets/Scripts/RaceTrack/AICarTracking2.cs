using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AICarTracking2 : MonoBehaviour
{
    public GameObject Point16;
    
    public GameObject Point17;
    
    public GameObject Point18;
    
    public GameObject Point19;
    
    public GameObject Point20;
    
    public GameObject Point21;
    
    public GameObject Point22;
    
    public GameObject Point23;

    public GameObject Point24;

    public GameObject Point25;

    public GameObject Point26;

    public GameObject Point27;

    public GameObject Point28;

    public GameObject Point29;

    public GameObject Point30;

    

    
    public GameObject Tracker2;

    public int count;

      void Update()
    {
        if (count == 0)
        {
            Tracker2.transform.position = Point16.transform.position;
        }
        if (count == 16)
        {
            Tracker2.transform.position = Point17.transform.position;
        }
        if (count == 17)
        {
            Tracker2.transform.position = Point18.transform.position;
        }
        if (count == 18)
        {
            Tracker2.transform.position = Point19.transform.position;
        }
        if (count == 19)
        {
            Tracker2.transform.position = Point20.transform.position;
        }
        if (count == 20)
        {
            Tracker2.transform.position = Point21.transform.position;
        }
        if (count == 21)
        {
            Tracker2.transform.position = Point22.transform.position;
        }
        if (count == 22)
        {
            Tracker2.transform.position = Point23.transform.position;
        }
        if (count == 23)
        {
            Tracker2.transform.position = Point24.transform.position;
        }
        if (count == 24)
        {
            Tracker2.transform.position = Point25.transform.position;
        }
        if (count == 25)
        {
            Tracker2.transform.position = Point26.transform.position;
        }
        if (count == 26)
        {
            Tracker2.transform.position = Point27.transform.position;
        }
        if (count == 27)
        {
            Tracker2.transform.position = Point28.transform.position;
        }
        if (count == 28)
        {
            Tracker2.transform.position = Point29.transform.position;
        }
        if (count == 29)
        {
            Tracker2.transform.position = Point30.transform.position;
        }

    }

      IEnumerator OnTriggerEnter(Collider c)
      {
          if (c.gameObject.tag == "AICar2")
          {
              this.GetComponent<BoxCollider>().enabled = false;
              if (count == 30)
              {
                  count = 0;
              }
              count = count + 1;
              yield return new WaitForSeconds(0.02f);
              this.GetComponent<BoxCollider>().enabled = true;
             
          }
      }
}
