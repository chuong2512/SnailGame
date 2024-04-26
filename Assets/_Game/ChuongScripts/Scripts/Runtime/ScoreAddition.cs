using System;
using ChuongCustom;
using UnityEngine;

namespace _Game.ChuongScripts.Scripts.Runtime
{
    public class ScoreAddition : MonoBehaviour
    {
        [SerializeField] private int speed = -5;
        private void Update()
        {
            transform.position += new Vector3(0, speed * Time.deltaTime);
        }

        private void OnTriggerEnter2D(Collider2D col)
        {
            if (col.tag.Equals("player"))
            {
                ScoreManager.Score += 100;
                Destroy(gameObject);
                return;
            }
            if (col.tag.Equals("destroy"))
            {
                Destroy(gameObject);
            }
        }
    }
}