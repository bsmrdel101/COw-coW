using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [Header("Camera")]
    public float XSensitivity = 3000;
    public float YSensitivity = 3;

    [Header("References")]
    [SerializeField] private CinemachineFreeLook _cam;


    private void Start()
    {
        UnlockCam();
    }

    private void LockCam()
    {
        _cam.m_YAxis.m_MaxSpeed = 0;
        _cam.m_XAxis.m_MaxSpeed = 0;
        Cursor.visible = true;
    }

    private void UnlockCam()
    {
        Cursor.visible = false;
        _cam.m_YAxis.m_MaxSpeed = YSensitivity;
        _cam.m_XAxis.m_MaxSpeed = XSensitivity;
    }
}
