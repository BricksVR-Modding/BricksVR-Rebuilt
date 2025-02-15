﻿// Whenever we migrate away from this Oculus SDK and take a multi-platform support aprroach, make sure to add the vigente component from the xr interaction toolkit.

//using Sigtrap.VrTunnellingPro;
using UnityEngine;
using System;

public class MovementVignette : MonoBehaviour
{
    //public Tunnelling tunnelling;
    private bool _vignetteEnabled;

    private float _originalVelocityMin;
    private float _originalVelocityMax;

    private void Start()
    {
        _vignetteEnabled = false;
        //tunnelling.enabled = _vignetteEnabled;
        //_originalVelocityMin = tunnelling.velocityMin;
        //_originalVelocityMax = tunnelling.velocityMax;
    }

    public void VignetteStrengthUpdated(float strength)
    {
        if (strength == 0)
        {
            //tunnelling.angularVelocityStrength = 0;
            //tunnelling.velocityStrength = 0;
        }
        else
        {
            //tunnelling.angularVelocityStrength = strength + 0.4f;
            //tunnelling.velocityStrength = strength + 0.6f;
        }
    }

    public void WithVignetteDisabled(Action action)
    {
        //tunnelling.enabled = false;

        action.Invoke();

        //tunnelling.enabled = _vignetteEnabled;
    }

    public void SetPlayerScale(float scale)
    {
        //tunnelling.velocityMin = _originalVelocityMin * scale;
        //tunnelling.velocityMax = _originalVelocityMax * scale;
    }
}
