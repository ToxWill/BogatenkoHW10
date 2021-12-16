using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sector : MonoBehaviour
{
    public bool isGood = true;
    public Material GoodMaterial;
    public Material BadMaterial;
    public AudioSource SoundBounce;

    private void Awake()
    {
        UpdateMaterial();
    }

    private void UpdateMaterial()
    {
        Renderer sectorRenderer = GetComponent<Renderer>();
        sectorRenderer.sharedMaterial = isGood ? GoodMaterial : BadMaterial;
    }

    private void OnCollisionEnter(Collision collision)
    {

        if (!collision.collider.TryGetComponent(out Player player)) return;

        Vector3 normal = -collision.contacts[0].normal.normalized;
        float dot = Vector3.Dot(normal, Vector3.up);
        if (dot < 0.5) return;

        if (isGood)
        {
            player.Bouce();
            SoundBounce.Play();
        }
        else
            player.Die();
    }

    private void OnValidate()
    {
        UpdateMaterial();
    }
}
