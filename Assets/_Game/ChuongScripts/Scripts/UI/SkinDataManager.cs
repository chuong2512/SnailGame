using System;
using System.Collections.Generic;
using UnityEngine;

namespace ChuongCustom
{
    public class SkinDataManager : PersistentSingleton<SkinDataManager>
    {
        [SerializeField] private List<SkinData> skins;

        public List<SkinData> Skins => skins;

        public Sprite CurrentSkin => skins[Data.Player.currentCar].carImage;
    }

    [Serializable]
    public class SkinData
    {
        public int price;
        public Sprite carImage;
    }
}