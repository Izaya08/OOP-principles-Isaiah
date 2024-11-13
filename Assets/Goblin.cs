using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goblin : NPCstats, DmgSystem
{
    private void Start()
    {
        DmgSystem(Gobbler.Attack);
        Hatdog();
    }

    protected override void Hatdog()
    {
        Debug.Log("Goblin got hit");
    }

    public void DmgSystem(int dmg)
    {
        Debug.Log("Goblin Current HP: " + Health);
        Health -= dmg;
        Debug.Log("Goblin HP: " + Health);
    }
    [SerializeField] private Goblin Gobbler;
}
