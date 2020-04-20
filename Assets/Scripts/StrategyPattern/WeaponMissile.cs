using UnityEngine;
using System;
using System.Collections;

public class WeaponMissile : Weapon
{
    public override void Fire()
    {
        Debug.Log("미사일발사");
    }
}
