using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{


    private string st = "Mouse ScrollWheel";

    [SerializeField]
    private Camera cam;


    float scrollSpeed = 1000;


    // Update is called once per frame
    void Update()
    {
        cam.orthographicSize += Input.GetAxis(st) * scrollSpeed * Time.deltaTime; ;
    }
  
}
