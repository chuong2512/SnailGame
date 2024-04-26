using System;
using UnityEngine;

namespace _Game.ChuongScripts.Scripts.Runtime
{
    public class EnemyCar : MonoBehaviour
    {
        [SerializeField] private int speed;

        private void Update()
        {
            transform.position += new Vector3(0, speed * Time.deltaTime);
        }

        private void OnCollisionEnter2D(Collision2D col)
        {
            if (col.collider.tag.Equals("destroy"))
            {
                Destroy(gameObject);
            }
        }
    }
}