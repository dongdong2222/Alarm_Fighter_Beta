using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMonster : Character
{
    Define.State nextBehavior = Define.State.SPAWN;                     

    [SerializeField] List<GameObject> horizontalMons = new List<GameObject>();      //���� ���� ���Ϳ�
    [SerializeField] GameObject verticalMon;                                        //���� ���� ���Ϳ�
    [SerializeField] GameObject randomMon;                                          //���� ���� ���Ϳ�
    
    //[SerializeField] List<GameObject> verticalMons = new List<GameObject>();       
    //[SerializeField] List<GameObject> randomMons = new List<GameObject>();

    void Start()
    {
        Managers.Timing.BehaveAction -= BitBehave;      //������ ��Ʈ ���� ������ BitBehave ����
        Managers.Timing.BehaveAction += BitBehave;
    }

    void BitBehave()
    {
        switch (nextBehavior)
        {
            case Define.State.SPAWN:

                //���� ���� ���� ����
                if (Managers.Game.CurrentVMons.Count < 2) //�ʵ忡 2�� �̻� ��������� ����
                {
                    //SpawnVerticalMonster(verticalMon);
                }

                //���� ���� ���� ����
                if (Managers.Game.CurrentHMons.Count < 1) //�ʵ忡 1�� �̻� ��������� ����
                {
                    //SpawnHorizontalMonster();
                }

                //���� ���� ���� ����
                if (Managers.Game.CurrentRMons.Count < 1) //�ʵ忡 1�� �̻� ��������� ����
                {
                    SpawnRandomMonster(randomMon);
                }

                nextBehavior = Define.State.NOTSPAWN;
                break;


            case Define.State.NOTSPAWN:

                nextBehavior = Define.State.SPAWN;
                break;

        }
    }

    private void SpawnVerticalMonster(GameObject prefab)        
    {
        GameObject go = Instantiate<GameObject>(prefab);
        Managers.Game.CurrentVMons.Add(go);
    }

    private void SpawnHorizontalMonster()
    {
        int rand = UnityEngine.Random.Range(0, horizontalMons.Count);
        GameObject go = Instantiate<GameObject>(horizontalMons[rand]);
        Managers.Game.CurrentHMons.Add(go);
    }

    private void SpawnRandomMonster(GameObject prefab)
    {
        GameObject go = Instantiate<GameObject>(prefab);
        Managers.Game.CurrentRMons.Add(go);
    }


 
    private void OnTriggerEnter2D(Collider2D collision)                 //Player�� �������� ���ؼ� ���Ͱ� Ȱ��ȭ�� grid�� ���� ���
    {

    }

}