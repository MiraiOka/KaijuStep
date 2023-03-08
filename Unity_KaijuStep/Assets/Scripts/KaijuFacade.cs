using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class KaijuFacade : MonoBehaviour
{
    [SerializeField] VisualEffect[] kaijuVFXs;

    [SerializeField] int[] numOfBursts;

    void Start()
    {

    }

    void Update()
    {
        for (int i = 0; i < kaijuVFXs.Length; i++)
        {
            kaijuVFXs[i].SetInt("BurstRate", numOfBursts[i]);
        }
    }
}
