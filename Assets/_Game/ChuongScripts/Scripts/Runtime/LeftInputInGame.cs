using UnityEngine;
using UnityEngine.EventSystems;

namespace _Game.ChuongScripts.Scripts.Runtime
{
    public class LeftInputInGame : MonoBehaviour, IPointerClickHandler
    {
        public void OnPointerClick(PointerEventData eventData)
        {
            Player.Instance.MoveLeft();
        }
    }
}