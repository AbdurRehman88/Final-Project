using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadRandomScene : MonoBehaviour
{
   public void LoadRandomScenes()
    {
        int index = Random.Range(3,4);
        SceneManager.LoadScene(index);
        Debug.Log("Scene loaded");
    }
}
