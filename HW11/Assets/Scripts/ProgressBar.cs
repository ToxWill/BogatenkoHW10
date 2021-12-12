using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgressBar : MonoBehaviour
{
    public Player Player;
    public Transform FinishTransform;
    public Slider Slider;

    public float AcceptableFinishPlayerDistance = 1f;

    private float _startY;
    private float _minimumReachedY;

    private void Start()
    {
        _startY = Player.transform.position.y;
    }

    private void Update()
    {
        _minimumReachedY = Mathf.Min(_minimumReachedY, Player.transform.position.y);
        float finishY = FinishTransform.position.y;
        float t = Mathf.InverseLerp(_startY, finishY + AcceptableFinishPlayerDistance, _minimumReachedY);
        Slider.value = t;
    }
}
