using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class NPCstats : MonoBehaviour
{
    [SerializeField] protected int Health;
    [SerializeField] protected int Defense;
    [SerializeField] protected int Speed;
    public int Attack;
    protected abstract void Hatdog();
}
