using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    private Transform target;
    [SerializeField]
    private Vector3 offset;


    void Start()
    {
        target = GameObject.FindWithTag(Tags.PLAYER_TAG).transform;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        FollowPlayer();
    }
    void FollowPlayer()
    {
        transform.position = target.TransformPoint(offset);
        transform.rotation = target.rotation;
    }
}
