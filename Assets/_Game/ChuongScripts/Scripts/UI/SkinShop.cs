using System;
using UnityEngine;

namespace ChuongCustom
{
    public class SkinShop : MonoBehaviour
    {
        [SerializeField] private CarItem carItemPrefabs;
        [SerializeField] private Transform container;

        private void Awake()
        {
            for (int i = 0; i < SkinDataManager.Instance.Skins.Count; i++)
            {
                var item = Instantiate(carItemPrefabs, container);
                item.Setup(i);
            }
        }
    }
}