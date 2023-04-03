using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Unity.FPS.Gameplay
{
    public class ToyCamera : MonoBehaviour
    {
        public PlayerInputHandler player;
        public Camera mainCamera;
        void Start()
        {
            mainCamera.focalLength = 10.0f;

        }

        void Update()
        {
            if (player.GetSprintInputHeld())
            {
                mainCamera.focalLength = 1.0f;
            }
        }
    }

}

