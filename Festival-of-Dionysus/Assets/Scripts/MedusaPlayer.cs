using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MedusaPlayer : MonoBehaviour
{
    [SerializeField]
    private Vector2 StartPos;
    private RectTransform UIplace;

    private void Awake()
    {
        //assighs transform and resets to start position
        UIplace = GetComponent<RectTransform>();
        ResetPos();
    }

    void Update()
    {
        
    }
    public void ResetPos()
    {
        //Puts Players in their start position
        UIplace.localPosition = StartPos;
    }
}
