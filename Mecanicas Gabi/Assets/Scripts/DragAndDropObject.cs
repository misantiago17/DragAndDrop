using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent((typeof(ActionTrigger)))]
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

    // do action trigger when user let go object
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject == this.GetComponent<ActionTrigger>().triggerObject)
        {
            if (!dragging)
            {
                this.gameObject.GetComponent<ActionTrigger>().DoAction();
            }
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject == this.GetComponent<ActionTrigger>().triggerObject)
        {
            if (!dragging)
            {
                this.gameObject.GetComponent<ActionTrigger>().DoAction();
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        
    }
}
