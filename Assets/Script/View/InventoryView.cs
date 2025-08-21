using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
namespace InventoryCanvasHandler
{
    public class InventoryView : MonoBehaviour
    {
        [SerializeField]
        private List<GameObject> _inventoryComponenet = new List<GameObject>();

        private static Action onSelectInventoryComponent;
        private static Action onDe_SelectPrevious;

        public static int currentIndex { get; private set; }
        public static int previousIndex { get; private set; }
        Image _inventory_Component_img;
        public void SelectAk47(int inventoryIndex)=> currentIndex = inventoryIndex;
        public void SelectPistol(int inventoryIndex)=> currentIndex = inventoryIndex;
        public void SelectSniper(int inventoryIndex) => currentIndex = inventoryIndex;
        public void SelectKnife(int inventoryIndex) => currentIndex = inventoryIndex;
        public void SelectMachineGun(int inventoryIndex) => currentIndex = inventoryIndex;
        public void SelectGrenad(int inventoryIndex) => currentIndex = inventoryIndex;
        public void SelectHealthBooster(int inventoryIndex) => currentIndex = inventoryIndex;
        public void SelectArmor(int inventoryIndex) => currentIndex = inventoryIndex;

        private void Start()
        {
            previousIndex = currentIndex = 0;
            onSelectInventoryComponent?.Invoke();
        }
        private void OnEnable()
        {
            onSelectInventoryComponent += SelectInventoryComponent;
            onDe_SelectPrevious += De_SelectPrevious;
        }
        private void OnDisable()
        {
            onSelectInventoryComponent -= SelectInventoryComponent;
            onDe_SelectPrevious -= De_SelectPrevious;
        }
        public void InventoryHoverOver()
        {
            if (currentIndex.Equals(previousIndex)) return;
            InventeryComponenetSelector(106, 79, 79, 36, currentIndex);
        }
        private void InventeryComponenetSelector(byte r, byte g, byte b, byte a, int selector)
        {
            _inventory_Component_img = _inventoryComponenet[selector].GetComponent<Image>();
            _inventory_Component_img.color = new Color32(r, g, b, a);
        }
        public void SelectInventoryComponent()
        {
            onDe_SelectPrevious?.Invoke();
            InventeryComponenetSelector(140, 29, 29, 136, currentIndex);
        }
        public void InventoryHoverExit(int deselectIndex)
        {
            if (currentIndex.Equals(previousIndex)) return;
            InventeryComponenetSelector(63, 59, 59, 136, deselectIndex);
        }

        #region
        private void De_SelectPrevious()
        {
            InventoryHoverExit(previousIndex);
            previousIndex = currentIndex;
        }
        #endregion
    }
}
