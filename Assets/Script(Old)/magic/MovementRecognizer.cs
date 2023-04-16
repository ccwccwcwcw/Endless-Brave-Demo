using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class MovementRecognizer : MonoBehaviour
{
    public XRNode inputSource;
    public InputHelpers.Button inputButton;
    public float inputThreshold =0.1f;
    public Transform movementSource;
    public float newPositionThresholdDistance = 0.05f;
    public GameObject debugCubePrefab;

    private bool isMoving=false;
    private List<Vector3> positionList = new List<Vector3>();

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        InputHelpers.IsPressed(InputDevices.GetDeviceAtXRNode(inputSource),inputButton,out bool isPressed,inputThreshold);

        if(!isMoving && isPressed)
        { 
            StartMovement();
            }
        else if(isMoving && !isPressed)
        {
            EndMovement();
            }
        else if(isMoving && !isPressed)
        { 
            UpdateMovement();
            }

    }

    void StartMovement()
    { 
        Debug.Log("Start Movement");
        isMoving = true;
        positionList.Clear();
        positionList.Add(movementSource.position);

        if(debugCubePrefab)
         Destroy(Instantiate(debugCubePrefab,movementSource.position,Quaternion.identity),3);
    }
   
    void EndMovement()
    { 
        Debug.Log("End Movement");
        isMoving=false;
        }

    void UpdateMovement()
    { 
        Debug.Log("Update Movement");
        Vector3 lastPosition = positionList[positionList.Count-1];
        if(Vector3.Distance(movementSource.position,lastPosition)>newPositionThresholdDistance)
        {
            positionList.Add(movementSource.position);

            if (debugCubePrefab)
                Destroy(Instantiate(debugCubePrefab, movementSource.position, Quaternion.identity), 3);
        
    }
        positionList.Add(movementSource.position);

        }
}
