using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using System;
namespace InventoryCanvasHandler
{
    public class InventoryController : MonoBehaviour
    {
        static int amoshootData;
        int totalBulletLeft;
        public static Action onSelectedWeapon;
        private void OnEnable()
        {
            onSelectedWeapon += SelectedWeapon;
        }
        private void OnDisable()
        {
            onSelectedWeapon -= SelectedWeapon;
        }
        private void Awake()
        {
            InventoryModel.GetInstance().SetupModel();
        }
        private void SelectedWeapon()
        {
            InventoryModel.GetInstance().UpdateInventoryDictionaryData(InventoryView.inventoryEnum, (value) => {
                totalBulletLeft = value;
                PlayerWeaponHandler.onShowCurrentSelectedWeapon?.Invoke(((int)InventoryView.inventoryEnum));
            });
        }
     

    }
}

