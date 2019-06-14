using UnityEngine;
using System.Collections.Generic;

public class ActionTrigger : MonoBehaviour
{
    [HideInInspector] public bool isResolved = false;
    public GameObject triggerObject;

    public void Update()
    {
        // Can't do this action again
        if (isResolved)
        {
            DoAction();
        }
    }

    public virtual void DoAction()
    {

        
    }

    public virtual void EndAction() { }

    public virtual void UndoAction() { }
}