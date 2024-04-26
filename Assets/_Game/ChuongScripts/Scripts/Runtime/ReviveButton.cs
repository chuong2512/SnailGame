using ChuongCustom;
using UnityEngine;

namespace _Game.ChuongScripts.Scripts.Runtime
{
    public class ReviveButton : AButton
    {
        public void Revive()
        {
            if (Data.Player.Heart <= 0)
            {
                ToastManager.Instance.ShowMessageToast("Not have enough heart!!!");
            }
            else
            {
                Data.Player.Heart--;
                InGameManager.Instance.Revive();
                ScreenManager.Instance.Back();
            }
            
        }

        protected override void OnClickButton()
        {
            Revive();
        }

        protected override void OnStart()
        {
        }
    }
}