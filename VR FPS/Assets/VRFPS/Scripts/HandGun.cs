using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK.Examples;
public class HandGun : GunShoot
{
    public Animator anim;
    public AudioClip shootSound;
    protected override void FireProjectile()
    {
        base.FireProjectile();

        anim.SetTrigger("Fire");
        AudioSource.PlayClipAtPoint(shootSound, transform.position);

        //Debug.Log("Handgun Shot");
    }
}
