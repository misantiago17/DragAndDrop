using UnityEngine;

public class ActionShowAnimation : ActionTrigger
{
    public Animation ActionAnimation;

    public override void DoAction()
    {
        base.DoAction();

        if (ActionAnimation)
        {
            ActionAnimation.Play();
            isResolved = true;
        }

    }

    public override void EndAction()
    {
        base.EndAction();
    }

    public override void UndoAction()
    {
        base.UndoAction();
        isResolved = false;
    }

}
