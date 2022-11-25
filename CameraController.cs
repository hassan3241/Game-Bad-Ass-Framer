using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;
    public float smoothSpeed = 2f;
    public float currentZoom = 1f;
    public float maxZoom = 3f;
    public float minZoom = 0.3f;
    public float yawSpeed = 70f;
    public float zoomsensitive = 0.7f;
    float dst;//ระยะห่่างของผู้เล่น
    float zoomSmooth;
    float targetZoom;

    // Start is called before the first frame update
    void Start()
    {
        dst = offset.magnitude;
        transform.LookAt(target);
        targetZoom = currentZoom;

    }

    // Update is called once per frame
    void Update()
    {
        float scroll=Input.GetAxisRaw("Mouse ScrollWheel") * zoomsensitive;
        if (scroll != 0f)
        {
            targetZoom = Mathf.Clamp(targetZoom-scroll,minZoom,maxZoom);
        }
        currentZoom = Mathf.SmoothDamp(currentZoom,targetZoom,ref zoomSmooth,0.15f);

    }
    private void LateUpdate()
    {
       transform.position=target.position-transform.forward*dst*currentZoom;
       transform.LookAt(target.position);
       float yawInput = Input.GetAxisRaw("Horizontal");
       transform.RotateAround(target.position,Vector3.up,-yawInput*yawSpeed*Time.deltaTime);
    }


}
