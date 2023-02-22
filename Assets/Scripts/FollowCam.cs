using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCam : MonoBehaviour
{
    public Transform followTarget;
    Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - followTarget.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = followTarget.position +  offset;
    }
}
