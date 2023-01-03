using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class StopCommandCommandCreator : CommandCreatorBase<IStopCommand>
{
    protected override void ClassSpecificCommandCreation(Action<IStopCommand> creationCallback)
    {
       
    }
}
