using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : Interaction
{
    public void Interacted()
    {
        if (isInteracted)
        {
            //Move a Platform
            //Change Tooltips details
            isInteracted = false;
        }
        else
        {
            //Move a Platform
            //Change Tooltips details
            isInteracted = true;
        }
    }
}
