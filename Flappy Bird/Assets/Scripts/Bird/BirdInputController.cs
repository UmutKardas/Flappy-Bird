using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdInputController : MonoBehaviour
{
    [SerializeField] private BirdDataTransmitter birdDataTransmitter;


    void Update()
    {
        BirdTouchDetection();
    }

    private void BirdTouchDetection()
    {
        if (Input.GetMouseButton(0))
        {
            birdDataTransmitter.isTouch = true;
        }
    }

}
