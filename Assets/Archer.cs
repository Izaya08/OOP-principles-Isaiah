using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Archer : PlayerStats, DmgSystem 
{
    private void Start()
    {
        DmgSystem(Bowman.Attack);
        Hatdog();
    }

    protected override void Hatdog()
    {
        Debug.Log("Bowman got hit");
    }

    public void DmgSystem(int dmg)
    {
        Debug.Log("Bowman Current HP: " + Health);
        Health -= dmg;
        Debug.Log("Bowman HP: " + Health);
    }
    [SerializeField] private Archer Bowman;
}
