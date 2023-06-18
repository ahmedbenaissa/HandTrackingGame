using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandTracking : MonoBehaviour
{
    public UDPReceive udpReceive;
    public GameObject[] handPoints;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        string data = udpReceive.data;
        if(data != ""){
        data = data.Remove(0, 1);
        data = data.Remove(data.Length-1, 1);

        string[] points = data.Split(',');


        for (int i = 0; i < 21; i++)
        {
            float x =  float.Parse(points[i * 3])/100 ;
            float y = float.Parse(points[i * 3 + 1]) / 100;
            float z = 0;

            handPoints[i].transform.localPosition = new Vector3(x, y, z);

        }
       
      }
    }

}
