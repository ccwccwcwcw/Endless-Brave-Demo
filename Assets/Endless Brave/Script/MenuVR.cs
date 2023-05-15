using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR;

public class MenuVR : MonoBehaviour
{
    public GameObject Menu;
    public GameObject Anchor;
    bool UIActive;
    bool menuOpened;
    bool buttonPressed;
    public XRController leftHandController;

    private void Start()
    {
        Menu.SetActive(false);
        UIActive = false;
        menuOpened = false;
        buttonPressed = false;
    }

    private void Update()
    {
        bool primaryButtonValue;
        bool secondaryButtonValue;
        if (leftHandController.inputDevice.TryGetFeatureValue(CommonUsages.primaryButton, out primaryButtonValue) && primaryButtonValue)
        {
            if (!buttonPressed)
            {
                if (menuOpened)
                {
                    UIActive = false;
                    Menu.SetActive(false);
                    menuOpened = false;
                }
                else
                {
                    UIActive = true;
                    Menu.SetActive(true);
                    menuOpened = true;
                }
                buttonPressed = true;
            }
        }
        if (UIActive)
        {
            Menu.transform.position = Anchor.transform.position;
            Menu.transform.eulerAngles = new Vector3(Anchor.transform.eulerAngles.x + 15, Anchor.transform.eulerAngles.y, 0);
        }
        if (leftHandController.inputDevice.TryGetFeatureValue(CommonUsages.secondaryButton, out secondaryButtonValue) && secondaryButtonValue)
        {
            buttonPressed = false;
        }
    }
}