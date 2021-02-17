using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Schema;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    // [SerializeField] private InputAction movement;
    [Header("General settings")]
    public ParticleSystem[] guns;
    
    
    
    private PlayerControls controls;
    private float vertical, horizontal;
    // [Header("Movement settings")]
    public float xmin, xmax, ymin, ymax;
    
    [Range(1, 10)] public float translationSensitivity = 5, rotationSensitivity = 3;
    
    
    private void Awake()
    {
        controls = new PlayerControls();
    }

    private void Start()
    {
        controls.PlaneControl.Steer.performed += SteerPerformed;
        controls.PlaneControl.Steer.canceled += context =>
        {
            vertical = 0;
            horizontal = 0;
        };
        controls.PlaneControl.Fire.performed += Fired;
        controls.PlaneControl.Fire.canceled += CancelFired;
    }

    private void CancelFired(InputAction.CallbackContext obj)
    {
        foreach (ParticleSystem gun in guns)
        {
            gun.Stop();
        }
    }

    private void Fired(InputAction.CallbackContext obj)
    {
        float fireRate = obj.ReadValue<float>();
        foreach (ParticleSystem gun in guns)
        {
            gun.Play();
        }
    }


    private void Update()
    {
        UpdateRotation();
        UpdateTranslation();
    }

    private void UpdateRotation()
    {
        Quaternion currentRotation = transform.localRotation;
        float pitch, yaw, roll;
        roll = -horizontal * 30;
        pitch = -vertical * 30;
        Quaternion targetRotaion = Quaternion.Euler(pitch, 0, roll);
        transform.localRotation = Quaternion.Lerp(currentRotation, targetRotaion, Time.deltaTime * 3f);
    }

    private void UpdateTranslation()
    {
        Vector3 currentPosition = transform.localPosition;
        currentPosition.x += horizontal * Time.deltaTime * translationSensitivity;
        currentPosition.y += vertical * Time.deltaTime * translationSensitivity;

        currentPosition.x = Mathf.Clamp(currentPosition.x, xmin, xmax);
        currentPosition.y = Mathf.Clamp(currentPosition.y, ymin, ymax);

        transform.localPosition = currentPosition;
    }

    private void SteerPerformed(InputAction.CallbackContext obj)
    {
        Vector2 steer = obj.ReadValue<Vector2>();
        vertical = steer.y;
        horizontal = steer.x;
    }

    private void OnEnable()
    {
        controls.Enable();
    }

    private void OnDisable()
    {
        controls.Disable();
    }
}

struct ScreenLimits
{
    
}