﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class Quest : ScriptableObject
{
    public TypesOfQuests typeofquest;
    public GameObject target;

    public Quest(GameObject target)
    {
        this.target = target;
        
    }

    public enum TypesOfQuests
    {

        KillorDestroy
    }
}
