using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swordsman : PlayerStats, DmgSystem
{
    private void Start()
    {
        DmgSystem(Knight.Attack);
        Hatdog();
    }

    protected override void Hatdog()
    {
        Debug.Log("Swordsman got hit");
    }

    public void DmgSystem(int dmg)
    {
        Debug.Log("Swordsman Current HP: " + Health);
        Health -= dmg;
        Debug.Log("Swordsman HP: " + Health);
    }
    [SerializeField] private Swordsman Knight;
}
