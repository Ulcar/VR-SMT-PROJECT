using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;


public class State : ScriptableObject
{

    public virtual void Enter() { }

    public virtual void Excecute() { }
    public virtual void Exit() { }


    public void Update()
    {
        Excecute();
    }
}
