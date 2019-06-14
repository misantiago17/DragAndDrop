﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragAndDropObject : MonoBehaviour
{
    [HideInInspector] public bool dragging = false;
    private float distance;

    // Botar um highlight?
    void OnMouseEnter()
    {
    }

    void OnMouseExit()
    {
    }

    void OnMouseDown()
    {
        distance = Vector3.Distance(transform.position, Camera.main.transform.position);
        dragging = true;
    }

    void OnMouseUp()
    {
        dragging = false;
    }

    void Update()
    {
        if (dragging)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Vector3 rayPoint = ray.GetPoint(distance);
            transform.position = rayPoint;
        }
    }
}
