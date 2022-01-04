using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BudShopArt
{
    public class ShopAnimationMechanics : MonoBehaviour
    {

        [SerializeField] private GameObject door;
        private Animator doorAnimator;


        private void OnEnable()
        {
            doorAnimator = door.GetComponent<Animator>();

        }

        public void openDoors()
        {
            doorAnimator.Play("opening");

            doorAnimator.Play("closed");
            //otherdoorAnimator.Play("closed");
            // otherdoorAnimator.Play()

            //StartCoroutine(DoorTimer());
        }

        //IEnumerator DoorTimer()
        //{
        // int doorTime = 3;
        // while(doorTime > 0)
        //{
        // doorTime--;
        // Debug.Log(doorTime);
        // yield return new WaitForSecondsRealtime(1);
        // }

        //   leftAnimator.Play("closed");
        //  StopCoroutine(DoorTimer());

        // }

    }
}

