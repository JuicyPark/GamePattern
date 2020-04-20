using UnityEngine;
using System;
using System.Collections;

public abstract class Weapon : MonoBehaviour
{
    public Action<Weapon> WeaponPicked;

    void OnTriggerEnter2D(Collider2D collision)
    {
        WeaponPicked?.Invoke(this);
    }

    public abstract void Fire();

}
