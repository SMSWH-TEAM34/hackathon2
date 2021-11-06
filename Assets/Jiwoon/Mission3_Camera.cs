using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mission3_Camera : MonoBehaviour
{
    public Transform target;        // 따라다닐 타겟 오브젝트의 Transform
    public float cameraHeight = 10f;

    private Transform transform;                // 카메라 자신의 Transform

    void Start()
    {
        transform = GetComponent<Transform>();

    }

    void LateUpdate()
    {
        transform.position = new Vector3(target.position.x - 0.52f, cameraHeight, target.position.z + 6.56f);

        transform.LookAt(target);
    }
}
