﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "Hologram/Item", order = 100)]
public class HologramItemData : ScriptableObject
{
    public float localPosX;
    public float localPosY;
    public float localPosZ;

    public float localRotx;
    public float localRoty;
    public float localRotz;

}
