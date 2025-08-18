using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
namespace InventoryCanvasHandler
{
    public class InventoryController : MonoBehaviour
    {
        InventoryModel inventoryModel;
        private void Awake()
        {
            InventoryModel.GetInstance().SetupModel();
        }
    }
}

