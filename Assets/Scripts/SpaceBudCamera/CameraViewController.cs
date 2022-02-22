//Copyright © 2022 Alex Reid (R.M.P.)

//This file is part of Space Bud.

//Space Bud is free software: you can redistribute it and/or modify it
//under the terms of the GNU General Public License as published by
//the Free Software Foundation, either version 3 of the License,
//or (at your option) any later version.

//Space Bud is distributed in the hope that it will be useful,
//but WITHOUT ANY WARRANTY; without even the implied warranty
//of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
//See the GNU General Public License for more details.

//You should have received a copy of the GNU General Public
//License along with Space Bud. If not, see <https://www.gnu.org/licenses/>.

using Cinemachine;
using UnityEngine;
using SpaceBudCore;

namespace SpaceBudCamera
{
    public class CameraViewController : MonoBehaviour
    {
        private CinemachineFreeLook freeLook;
        private GameplayInputController controls;
        private Vector2 inputVector;
        
        [SerializeField] private float speed = 5;

        private void Awake()
        {
            freeLook = GetComponent<CinemachineFreeLook>();

        }

        private void Start()
        {
            controls = InputSystemController.controls;

            controls.Gameplay.CameraMove.performed += ctx => inputVector = ctx.ReadValue<Vector2>();
            controls.Gameplay.CameraMove.canceled += ctx => inputVector = Vector2.zero;

        }

        private void Update()
        {
            float factor = speed * Time.deltaTime;
            freeLook.m_XAxis.Value += inputVector.x * 20;
            freeLook.m_YAxis.Value += inputVector.y * factor;

        }


    }
}


