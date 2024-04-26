using System;
using ChuongCustom;
using UnityEngine;

namespace _Game.ChuongScripts.Scripts.Runtime
{
    [RequireComponent(typeof(SpriteRenderer))]
    public class RoadSpeedController : Singleton<RoadSpeedController>
    {
        [SerializeField] private float speed = 5f;
        private static readonly int ScrollSpeed = Shader.PropertyToID("_ScrollSpeed");

        private void OnEnable()
        {
            SetSpeed();
        }

        public void SetSpeed(float value)
        {
            GetComponent<SpriteRenderer>().material.SetVector(ScrollSpeed, new Vector4(0, value));
        }
        
        public void SetSpeed()
        {
            SetSpeed(speed);
        }
    }
}