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
            inventoryParis[(InventoryEnum)0] = 0;
            inventoryParis[(InventoryEnum)1] = 30;
            inventoryParis[(InventoryEnum)2] = 5;
            inventoryParis[(InventoryEnum)3] = 30;
            inventoryParis[(InventoryEnum)4] = 5;
            inventoryParis[(InventoryEnum)5] = 32;
            inventoryParis[(InventoryEnum)6] = 25;
            inventoryParis[(InventoryEnum)7] = 15;
        }
        public void UpdateInventoryDictionaryData(InventoryEnum inventoryEnum , Action<int> callback) => callback?.Invoke(inventoryParis[inventoryEnum]);  

    }
}
