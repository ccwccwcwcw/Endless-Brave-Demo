using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class PickUpWeapon : XRGrabInteractable
{
    public Transform handleTransform; // 武器柄的 Transform
    private Transform attachTransform; // 撿起武器后要附著的 Transform
    //public Transform leftHandAttachTransform;
   // public Transform rightHandAttachTransform;
    protected override void OnSelectEntered(XRBaseInteractor interactor)
    {
        base.OnSelectEntered(interactor);

        attachTransform = interactor.transform; // 記錄附著的 Transform
        attachTransform.rotation = Quaternion.Euler(0, 0, 0); // 重置旋轉
    
        // 如果是右手控制器，則把武器柄設置在右手模型的位置上
        if (interactor.CompareTag("RightHand"))
        {

           // attachTransform = rightHandAttachTransform;
            handleTransform.position = attachTransform.position;
            handleTransform.rotation = attachTransform.rotation;
            handleTransform.parent = attachTransform;
        }
        // 如果是左手控制器，則把武器柄設置在左手模型的位置上
        else if (interactor.CompareTag("LeftHand"))

        {
           // attachTransform = leftHandAttachTransform;
            handleTransform.position = attachTransform.position;
            handleTransform.rotation = attachTransform.rotation;
            handleTransform.parent = attachTransform;
        }
    }

    protected override void OnSelectExited(XRBaseInteractor interactor)
    {
        base.OnSelectExited(interactor);

        handleTransform.parent = transform; // 解除武器柄的附著
    }
}