﻿using UnityEngine;
using System.Collections;

public class SubmarineLabSceneController : SceneController
{
    public SubmarineLabSceneState State;

    public override void EnterScene()
    {
        base.EnterScene();
        State = FindObjectOfType<SubmarineLabSceneState>();
        DestroyConsumedObjectNames(State);
    }
}
