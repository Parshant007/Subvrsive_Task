using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace InventoryCanvasHandler
{
    public class InventoryView : MonoBehaviour
    {
        [SerializeField]
        private List<GameObject> _inventoryComponenet = new List<GameObject>();
        private const int R= 106;
        private const int G = 79;
        private const int B = 79;
        private const int A = 136;
        public static int currentIndex { get; private set; }
        Image img;
        public void SelectAk47(int inventoryIndex)=> currentIndex = inventoryIndex;
        public void SelectPistol(int inventoryIndex)=> currentIndex = inventoryIndex;
        public void SelectLaserGun(int inventoryIndex) => currentIndex = inventoryIndex;
        public void SelectKnife(int inventoryIndex) => currentIndex = inventoryIndex;
        public void SelectTearGas(int inventoryIndex) => currentIndex = inventoryIndex;
        public void SelectBomb(int inventoryIndex) => currentIndex = inventoryIndex;
        public void SelectHealthBooster(int inventoryIndex) => currentIndex = inventoryIndex;
        public void SelectArmor(int inventoryIndex) => currentIndex = inventoryIndex;
       
        public void InventeryHoverOver()
        {
            InventeryComponenetSelector(106, 79, 79, 36);
        }
        private void InventeryComponenetSelector(byte r, byte g, byte b, byte a)
        {
            img = _inventoryComponenet[currentIndex].GetComponent<Image>();
            img.color = new Color32(r, g, b, a);
        }
        public void SelectInventoryComponent()
        {
            InventeryComponenetSelector(140, 29, 29, 136);
        }
        public void RestAllComponent()
        {
            InventeryComponenetSelector(63, 59, 59, 136);
        }

    }
}
