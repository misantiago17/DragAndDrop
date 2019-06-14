using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragAndDropTrigger : MonoBehaviour
{
    // Check if object has Action and if this object is his trigger
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(collision);
        Debug.Log(collision.gameObject.GetComponent<ActionTrigger>() + "action");
        Debug.Log(collision.gameObject.GetComponent<DragAndDropObject>() + "drag");

        if (collision.gameObject.GetComponent<ActionTrigger>() && collision.gameObject.GetComponent<DragAndDropObject>())
        {
            if (collision.gameObject.GetComponent<ActionTrigger>().triggerObject == this && !collision.gameObject.GetComponent<DragAndDropObject>().dragging) {
                collision.gameObject.GetComponent<ActionTrigger>().DoAction();
                Debug.Log("Soltou objeto");
            }
        }
        
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        Debug.Log(collision.gameObject.GetComponent<ActionTrigger>() + "action");
        Debug.Log(collision.gameObject.GetComponent<DragAndDropObject>() + "drag");

        if (collision.gameObject.GetComponent<ActionTrigger>() && collision.gameObject.GetComponent<DragAndDropObject>())
        {
            Debug.Log("Onde falha");

            if (collision.gameObject.GetComponent<ActionTrigger>().triggerObject == this && !collision.gameObject.GetComponent<DragAndDropObject>().dragging) {
                collision.gameObject.GetComponent<ActionTrigger>().DoAction();
                Debug.Log("Soltou objeto");
            }
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        
    }
}
