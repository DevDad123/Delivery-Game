using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] GameObject thingtofollow;
    void LateUpdate()
    {
        transform.position = thingtofollow.transform.position + new Vector3(0,0,-10);
    }
}
