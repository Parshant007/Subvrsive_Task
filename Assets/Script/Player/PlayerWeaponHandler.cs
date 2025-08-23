using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;
using System;
public class PlayerWeaponHandler : MonoBehaviour
{
    [SerializeField]
    List<GameObject> playerWeapon = new List<GameObject>();
    public static Action<int> onShowCurrentSelectedWeapon;
    int previousWeapon= 0;
    private void OnEnable()
    {
        onShowCurrentSelectedWeapon += ShowCurrentSelectedWeapon;
    }
    private void OnDisable()
    {
        onShowCurrentSelectedWeapon -= ShowCurrentSelectedWeapon;
    }
    private void ShowCurrentSelectedWeapon(int weapons)
    {
        playerWeapon[weapons].SetActive(true);
        playerWeapon[previousWeapon].SetActive(false);
        previousWeapon = weapons;
    }
}
