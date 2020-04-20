using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    WeaponManager weaponManager;
    Controller controller;

    [SerializeField]
    Player playerPrefab;
    Player player;

    void Start()
    {
        weaponManager = GetComponent<WeaponManager>();
        controller = gameObject.AddComponent<KeyboardController>();
        player = Instantiate(playerPrefab);
        BindEvents();
    }

    void OnDestroy()
    {
        UnBindEvents();
    }

    void BindEvents()
    {
        controller.ActionKeyPressed += weaponManager.Fire;
        controller.DirectionKeyPressed += player.MoveToDirection;
    }

    void UnBindEvents()
    {
        controller.ActionKeyPressed -= weaponManager.Fire;
        controller.DirectionKeyPressed -= player.MoveToDirection;
    }
}
