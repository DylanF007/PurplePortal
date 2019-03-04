﻿// -----------------------------------------------------------------------------
#region File Info - ParticleSystemAction.cs
// -----------------------------------------------------------------------------
// Project:     Dino Unity Toolkit
// Created:     Sarah Herzog 2019
// Purpose:     Conrtols a particle system component
// -----------------------------------------------------------------------------
#endregion
// -----------------------------------------------------------------------------


// -----------------------------------------------------------------------------
#region Libraries
// -----------------------------------------------------------------------------
using UnityEngine;
// -----------------------------------------------------------------------------
#endregion
// -----------------------------------------------------------------------------


// -----------------------------------------------------------------------------
#region Component: ParticleSystemAction
// -----------------------------------------------------------------------------
[RequireComponent(typeof(ParticleSystem))]
[HelpURL("https://github.com/CodingDino/FifeCollege-Unity-DragNDrop/wiki/ParticleSystemAction")]
public class ParticleSystemAction : MonoBehaviour
{

    // -------------------------------------------------------------------------
    #region Internal Variables
    // -------------------------------------------------------------------------
    private ParticleSystem particleObject = null;
    // -------------------------------------------------------------------------
    #endregion
    // -------------------------------------------------------------------------


    // -------------------------------------------------------------------------
    #region Unity Functions
    // -------------------------------------------------------------------------
    private void Awake()
    {
        // Store our particle system object for later use
        particleObject = GetComponent<ParticleSystem>();
    }
    // -------------------------------------------------------------------------
    #endregion
    // -------------------------------------------------------------------------


    // -------------------------------------------------------------------------
    #region Action Functions
    // -------------------------------------------------------------------------
    public void ActionPlayParticleSystem()
    {
        particleObject.Play();
    }
    // -------------------------------------------------------------------------
    public void ActionStopParticleSystem()
    {
        particleObject.Stop();
    }
    // -------------------------------------------------------------------------
    #endregion
    // -------------------------------------------------------------------------


}
// -----------------------------------------------------------------------------
#endregion
// -----------------------------------------------------------------------------