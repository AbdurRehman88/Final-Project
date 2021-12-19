using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCamera : MonoBehaviour
{
    public GameObject MainCamera;

    public GameObject FrontCamera;
    
    public GameObject FarCamera;

    public int count;

    void Update()
    {
        if (Input.GetButtonDown("ChangeCameraView")){
            if (count == 2){
                count = 0;
            }
            else
            {
                count = count + 1;
            }
            StartCoroutine(ChangeCameraV());
        }  
    }
    IEnumerator ChangeCameraV()
    {
        yield return new WaitForSeconds(0.01f);
        if (count == 0)
        {
            MainCamera.SetActive(true);
            FarCamera.SetActive(false);
        }
        if (count == 1)
        {
            FrontCamera.SetActive(true);
            MainCamera.SetActive(false);
        }
        if (count == 2)
        {
            FarCamera.SetActive(true);
            FrontCamera.SetActive(false);
        }
      
    }
}
