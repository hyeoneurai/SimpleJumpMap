using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]

public class PlayerAnimationData
{
    [SerializeField] private string groundParName = "@Ground";
    [SerializeField] private string idleParName = "Idle";
    [SerializeField] private string walkParName = "Walk";
    [SerializeField] private string runParName = "Run";

    [SerializeField] private string airParName = "@Air";
    [SerializeField] private string jumpParName = "Jump";
    [SerializeField] private string fallParName = "Fall";

    public int GroundParHash { get; private set; }
    public int IdleParHash { get; private set; }
    public int WalkParHash { get; private set; }
    public int RunParHash { get; private set; }

    public int AirParHash { get; private set; }
    public int JumpParHash { get; private  set; }
    public int FallParHash { get; private set ; }

    public void Initialize()
    {
        GroundParHash = Animator.StringToHash(groundParName);
        IdleParHash = Animator.StringToHash(idleParName);
        WalkParHash = Animator.StringToHash(walkParName);
        RunParHash = Animator.StringToHash(runParName);

        AirParHash = Animator.StringToHash(airParName);
        JumpParHash = Animator.StringToHash(jumpParName);
        FallParHash = Animator.StringToHash(fallParName);
    }
}
