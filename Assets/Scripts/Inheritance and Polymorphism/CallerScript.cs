using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CallerScript : MonoBehaviour
{
    [SerializeField] private Chest Chest;
    [SerializeField] private Switch newSwitch;

    private void Start()
    {
        Chest.Interacted();
        newSwitch.Interacted();
    }

}
