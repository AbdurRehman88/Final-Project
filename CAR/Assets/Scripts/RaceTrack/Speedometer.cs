using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Speedometer : MonoBehaviour
{
    public GameObject Needle;

    public GameObject SpeedLabel;

    public Rigidbody Car;

    public float maxAngle = -95;

    public float minAngle = 99;

    public int maxSpeed = 100;

    public float speed;


    void Update()
    {
        speed = Car.velocity.magnitude * 1.5f;
        
        SpeedLabel.GetComponent<Text>().text= (int)speed + "Km/h";

        Needle.transform.localEulerAngles = new Vector3(0, 0, Mathf.Lerp(minAngle, maxAngle, speed / maxSpeed));
    }
}
