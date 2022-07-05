using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Test_MY
{
    public class Player_test : MonoBehaviour
    {
        [SerializeField] MonoBehaviour weapon = null;

        private void Start()
        {
            if (weapon != null)
            {
                //weapon.Gun();
               if(weapon is IGun) (weapon as IGun).Gun();
               // if (weapon is Sword_test) (weapon as Sword_test).Gun();
            }
        }



    }

}