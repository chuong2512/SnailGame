using System.Collections;
using System.Collections.Generic;
using ChuongCustom;
using UnityEngine;

namespace _Game.ChuongScripts.Scripts.Runtime
{
    public class Player : Singleton<Player>
    {
        [SerializeField] private SpriteRenderer _spriteRenderer;
        [SerializeField] private float startYPos;
        [SerializeField] private List<float> roadXPos;
        [SerializeField] private float timeMove = 0.25f;
        private EnemyCar _enemyCar;
        private int index = 1;
        private bool isMoving;

        private void OnEnable()
        {
#if UNITY_EDITOR
            if(SkinDataManager.Instance != null) _spriteRenderer.sprite = SkinDataManager.Instance.CurrentSkin;
#else
            _spriteRenderer.sprite = SkinDataManager.Instance.CurrentSkin;
#endif
            index = 1;
            transform.position = new Vector3(roadXPos[index], startYPos);
        }

        private void OnCollisionEnter2D(Collision2D col)
        {
            if (!col.collider.tag.Equals("car")) return;
            _enemyCar = col.collider.GetComponent<EnemyCar>();
            InGameManager.Instance.OnLose();
        }

        public void DestroyEnemyCar()
        {
            if (_enemyCar == null) return;
            Destroy(_enemyCar.gameObject);
        }
        
        public void MoveLeft()
        {
            _spriteRenderer.flipX = false;
            
            if (isMoving) return;
            if (index <= 0)
            {
                index = 0;
                return;
            }
            index--;
            StartCoroutine(IEMove(roadXPos[index])); 
        }
        
        

        public void MoveRight()
        {
            _spriteRenderer.flipX = true;
            
            if (isMoving) return;
            if (index + 1 >= roadXPos.Count)
            {
                index = roadXPos.Count - 1;
                return;
            }
            index++;
            StartCoroutine(IEMove(roadXPos[index])); 
        }

        public IEnumerator IEMove(float targetX)
        {
            isMoving = true;
            Vector2 startPosition = transform.position;
            Vector2 targetPosition = new Vector2(targetX, startYPos);
            
            float elapsedTime = 0;

            while (elapsedTime < timeMove)
            {
                transform.position = Vector2.Lerp(startPosition, targetPosition, elapsedTime / timeMove);
                elapsedTime += Time.deltaTime;
                yield return null;
            }

            transform.position = targetPosition;
            isMoving = false;
        }
    }
}