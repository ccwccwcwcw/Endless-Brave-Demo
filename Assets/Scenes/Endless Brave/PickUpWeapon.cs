using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class PickUpWeapon : XRGrabInteractable
{
    public Transform handleTransform; // �Z���`�� Transform
    private Transform attachTransform; // �߰_�Z���Z�n���۪� Transform
    //public Transform leftHandAttachTransform;
   // public Transform rightHandAttachTransform;
    protected override void OnSelectEntered(XRBaseInteractor interactor)
    {
        base.OnSelectEntered(interactor);

        attachTransform = interactor.transform; // �O�����۪� Transform
        attachTransform.rotation = Quaternion.Euler(0, 0, 0); // ���m����
    
        // �p�G�O�k�ⱱ��A�h��Z���`�]�m�b�k��ҫ�����m�W
        if (interactor.CompareTag("RightHand"))
        {

           // attachTransform = rightHandAttachTransform;
            handleTransform.position = attachTransform.position;
            handleTransform.rotation = attachTransform.rotation;
            handleTransform.parent = attachTransform;
        }
        // �p�G�O���ⱱ��A�h��Z���`�]�m�b����ҫ�����m�W
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

        handleTransform.parent = transform; // �Ѱ��Z���`������
    }
}