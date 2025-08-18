using System;
using System.Collections.Generic;
using Unity.VisualScripting;
namespace InventoryCanvasHandler
{
    public sealed class InventoryModel
    {
        private static InventoryModel Instance= null;
        private static readonly object padlock = new object();
        InventoryModel() { 
        }

        public static InventoryModel GetInstance()
        {
            if (Instance == null)
            {
                lock (padlock)
                {
                    if (Instance == null)
                    {
                        Instance = new InventoryModel();
                    }
                }
            }
            return Instance;
        }

        Dictionary<InventoryEnum, float> inventoryParis= new Dictionary<InventoryEnum, float>();

        public void SetupModel()
        {
            inventoryParis.Clear();
            InitalizeDictionary();
        }
        public void InitalizeDictionary()
        {
            inventoryParis[InventoryEnum.Ak47] = 30;
            inventoryParis[InventoryEnum.Pistol] = 6;
            inventoryParis[InventoryEnum.Sniper] = 10f;
            inventoryParis[InventoryEnum.Knife] = 1;
            inventoryParis[InventoryEnum.TearGas] = 3;
            inventoryParis[InventoryEnum.Grenade] = 3;
            inventoryParis[InventoryEnum.HealthBooster] = 2;
            inventoryParis[InventoryEnum.Armor] = 2;
        }
    }
}
