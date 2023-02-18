using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStat : Stat
{
    void Start()
    {
        MaxHP = 10;
        CurrentHP = 10;

        //GetComponent<HpBarUpdater>().GetSliderComponent().maxValue = MaxHP;

    }
}
