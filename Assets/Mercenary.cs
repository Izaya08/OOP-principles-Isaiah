using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mercenary : NPCstats, DmgSystem
{
    private void Start()
    {
        DmgSystem(Merc.Attack);
        Hatdog();
    }

    protected override void Hatdog()
    {
        Debug.Log("Mercenary got hit");
    }

    public void DmgSystem(int dmg)
    {
        Debug.Log("Mercenary Current HP: " + Health);
        Health -= dmg;
        Debug.Log("Mercenary HP: " + Health);
    }
    [SerializeField] private Mercenary Merc;
}
