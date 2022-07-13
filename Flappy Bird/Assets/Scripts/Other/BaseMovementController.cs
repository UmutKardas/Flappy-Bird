using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseMovementController : MonoBehaviour
{
    [SerializeField] private GameObject lastBase;
    [SerializeField] private float horizontalValue;
    [SerializeField] private float moveSpeed;



    void Update()
    {
        SetBaseLeftMovement();
        CheckBaseHorizontalPosition();
    }


    private void CheckBaseHorizontalPosition()
    {
        if (transform.position.x <= horizontalValue)
        {
            transform.position = new Vector2(
                lastBase.transform.position.x + 6.222f,
                transform.position.y
            );
        }
    }


    private void SetBaseLeftMovement()
    {
        transform.Translate(Vector2.left * moveSpeed * Time.deltaTime);
    }
}
