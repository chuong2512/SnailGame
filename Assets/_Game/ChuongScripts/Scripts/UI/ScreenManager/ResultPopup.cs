using UnityEngine;

namespace ChuongCustom
{
    public class ResultPopup : BasePopup
    {
        public override ScreenType GetID() => ScreenType.Result;
    }

    public class ResultModel
    {
        public bool isWin;
    }
}