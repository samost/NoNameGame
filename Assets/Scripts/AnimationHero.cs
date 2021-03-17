using UnityEngine;
using UnityEngine.EventSystems;

public class AnimationHero : MonoBehaviour
{
    public PlayerController playerController;
    public Animator anim;
    public WeaponSwitch weaponSwitch;
    public Animator gunAnimator;
    public Animator pistolAnimator;
    


    void Update()
    {
        MoveAnimation();

        CurrentGunAnimation();
    }

    private void MoveAnimation()
    {
        if (playerController.joystick.direction != Vector2.zero)
        {
            anim.SetInteger("State", 1);
        }
        else
        {
            anim.SetInteger("State", 0);
        }
    }


    void CurrentGunAnimation()
    {
        switch (weaponSwitch.currentWeapon)
        {
            case WeaponSwitch.GunType.Pistol:
                anim.SetBool("isGun", false);
                anim.SetBool("isMeleeWeapon", false);
                anim.SetBool("isPistol", true);
                break;
            case WeaponSwitch.GunType.Gun:
                anim.SetBool("isGun", true);
                anim.SetBool("isMeleeWeapon", false);
                anim.SetBool("isPistol", false);
                break;
            case WeaponSwitch.GunType.MeleeWeapon:
                anim.SetBool("isGun", false);
                anim.SetBool("isMeleeWeapon", true);
                anim.SetBool("isPistol", false);
                break;
        }
    }
    
    public void Fire(bool state)
    {
       
        switch (weaponSwitch.currentWeapon)
        {
            case WeaponSwitch.GunType.Pistol:
                pistolAnimator.SetBool("isPistolGun", state);
                anim.SetBool("isPistolGun", state);
                break;
            case WeaponSwitch.GunType.Gun:
                gunAnimator.SetBool("isFireGun", state);
                anim.SetBool("isFireGun", state);

                break;
            case WeaponSwitch.GunType.MeleeWeapon:
                anim.SetBool("isGun", state);
                anim.SetBool("isMeleeWeapon", state);
                anim.SetBool("isPistol", state);
                break;
        }
    }
    
    
    
    
    
}