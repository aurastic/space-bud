using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace BudShopArt
{
    public class ObjectColorManager : MonoBehaviour
    {
        [SerializeField] GameObject patientMesh;

        private void OnEnable()
        {
            patientMesh.GetComponent<Renderer>().material.color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
        }
    }
}

