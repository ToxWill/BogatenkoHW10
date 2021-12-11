using Assets.Scripts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float BounceSpeed;
    public Rigidbody Rigidbody;
    public Platform CurrentPlatform;

    public void Bouce()
    {
        Rigidbody.velocity = new Vector3(0, BounceSpeed, 0);
    }
}
