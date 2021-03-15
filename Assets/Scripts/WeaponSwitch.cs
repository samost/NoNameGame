using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSwitch : MonoBehaviour
{
    public int weaponSwitch = 0;
    
    
    void Start()
    {
        //SelectWeapon();
    }

    private void Update()
    {
        SelectWeapon();
    }


    void SelectWeapon()
    {
        int i = 0;
        foreach (Transform weapon in transform)
        {
            if (i == weaponSwitch)
            {
                weapon.gameObject.SetActive(true);
                
                
            }
            else
                weapon.gameObject.SetActive(false);
            
            i++;
        }
    }
}
