using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camara : MonoBehaviour
{
    private bool isDragging = false;
    private Vector3 dragStartPosition;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            isDragging = true;
            dragStartPosition = Input.mousePosition;
        }
        else if (Input.GetMouseButtonUp(0))
        {
            isDragging = false;
        }

        if (isDragging)
        {
            Vector3 currentPosition = Input.mousePosition;
            float deltaX = currentPosition.x - dragStartPosition.x;
            float deltaY = currentPosition.y - dragStartPosition.y;
            float deltaZ = currentPosition.z - dragStartPosition.z;
            transform.Translate(deltaX * Time.deltaTime, deltaY * Time.deltaTime, deltaZ * Time.deltaTime);
        }
    }
}
    
