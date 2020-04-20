using UnityEngine;
using System;
using System.Collections;

public class WeaponGun : Weapon
{
    public override void Fire()
    {
        Debug.Log("총알발사");
    }
}
