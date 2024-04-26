using UnityEngine;
using UnityEngine.EventSystems;

namespace _Game.ChuongScripts.Scripts.Runtime
{
    public class Input : MonoBehaviour, IPointerClickHandler
    {
        public void OnPointerClick(PointerEventData eventData)
        {
            var pos = Camera.main.ScreenToWorldPoint(UnityEngine.Input.mousePosition);
            if (pos.x <= Player.Instance.transform.position.x)
            {
                Player.Instance.MoveLeft();
            }
            else
            {
                Player.Instance.MoveRight();
            }
            
        }
    }
}