using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdMovementController : MonoBehaviour
{
    [SerializeField] BirdDataTransmitter birdDataTransmitter;
    [SerializeField] private Rigidbody2D rigi2D;
    public float flySpeed;


    void FixedUpdate()
    {
        BirdFlyController();
    }

    void BirdFlyController()
    {
        if (birdDataTransmitter.isTouch)
        {
            rigi2D.velocity = Vector2.up * flySpeed * Time.fixedDeltaTime;
            birdDataTransmitter.isTouch = false;
        }

    }
}
