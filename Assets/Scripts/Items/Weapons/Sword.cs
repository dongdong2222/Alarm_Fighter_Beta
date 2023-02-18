using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword : Weapon
{
    GameObject go;
    public Sword()
    {
        weaponObject = Managers.Resource.Load<GameObject>("Prefabs/Items/Weapons/Sword");
        attackEffect = "Prefabs/Effect/Weapons/Sword";

        Rank = Define.ItemRank.Normal;
    }

    public override void Attack(Transform parent)
    {
        go = Managers.Resource.Instantiate(attackEffect, parent);

    }

    //IEnumerator Destroy()
    //{
    //    yield return new WaitForSeconds(1f);
    //    Managers.Resource.Destroy(go);
    //}
    // Start is called before the first frame update
}
