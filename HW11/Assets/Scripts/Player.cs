using Assets.Scripts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int ThisPlatform;
    public float BounceSpeed;
    public Rigidbody Rigidbody;
    public Platform CurrentPlatform;
    public Game Game;

    public void ReachFinish()
    {
        Game.OnPlayerReachedFinish();
        Rigidbody.velocity = Vector3.zero;
    }
    
    public void Bouce()
    {
        Rigidbody.velocity = new Vector3(0, BounceSpeed, 0);
    }

    public void Die()
    {
        Game.OnPlayerDied();
        Rigidbody.velocity = Vector3.zero;
    }
}
