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

        Dictionary<InventoryEnum, int> inventoryParis= new Dictionary<InventoryEnum, int>();

        public void SetupModel()
        {
            inventoryParis.Clear();
            InitalizeInventorryDictionary();
        }
        public void InitalizeInventorryDictionary()
        {
            inventoryParis[InventoryEnum.Ak47] = 30;
            inventoryParis[InventoryEnum.Pistol] = 6;
            inventoryParis[InventoryEnum.Sniper] = 10;
            inventoryParis[InventoryEnum.Knife] = 1;
            inventoryParis[InventoryEnum.TearGas] = 3;
            inventoryParis[InventoryEnum.Grenade] = 3;
            inventoryParis[InventoryEnum.HealthBooster] = 2;
            inventoryParis[InventoryEnum.Armor] = 2;
        }
        public void UpdateInventoryDictionaryData(InventoryEnum inventoryEnum , Action<int> callback) => callback?.Invoke(inventoryParis[inventoryEnum]);
  

    }
}
