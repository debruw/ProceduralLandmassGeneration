using System;
using UnityEngine;

namespace DefaultNamespace
{
    public class HideOnPlay : MonoBehaviour
    {
        private void Start()
        {
            gameObject.SetActive(false);
        }
    }
}