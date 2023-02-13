using System.Collections.Generic;
using UnityEngine;

//spone?sponsor?

public class GameScene : BaseScene
{
    int monsterIndex = 0;           
    int maxMonsterNum;             

    [SerializeField]

    List<GameObject> monsters = new List<GameObject>();  


    [SerializeField]
    GameObject backGround;

    int GetMaxMonsterNum() { return maxMonsterNum; }
    void SetMaxMonsterNum() { maxMonsterNum = monsters.Count; }

    public override void Clear()
    {
        Managers.Timing.Clear();
        monsters.Clear();
        monsterIndex = 0;      
    }

    protected override void Init()
    {
        base.Init();            
        SetMaxMonsterNum();
        Managers.Game.SetMonsterCount(maxMonsterNum);
        SoundBgmPlay();        
        SponeBackGround();
        //SponeNoteBar();
        SponePlayer();
        SponeField();

        Managers.Item.Init();
        Managers.Resource.Instantiate("Items/ItemBoxes/@GridBaseSpawn");
    }
    public void Update()
    {
        Managers.Timing.UpdatePerBit();         //�� ��Ʈ���� ���� �ൿ ����Ʈ
        Managers.Game.CheckLeftMonster();       //��� ���Ͱ� ����ϴ��� Ȯ��
    }
    private void SponeMonster()                 //Ư�(monsterIndex) �ε��� ��° ���� ��
    {
        if (monsters.Count == 0) return;
        GameObject go = Instantiate(monsters[monsterIndex]) as GameObject;
    }
    private void SponeBackGround()              //
    {
        GameObject go = Instantiate(backGround) as GameObject;      //
        //go = Instantiate<GameObject>(go) as GameObject;     //?????
    }
    private void SponeNoteBar()
    {
        GameObject go = Managers.Resource.Load<GameObject>("Prefabs/NoteBar/NoteBar");
        go = Instantiate(go) as GameObject;
    }
    private void SponePlayer()
    {
        GameObject go = Managers.Resource.Load<GameObject>("Prefabs/Players/Player");
        go = Instantiate<GameObject>(go) as GameObject;
        Managers.Player.SetPlayer(go.GetComponent<Player_Parent>());
        Managers.Game.CurrentPlayer = go;
    }
    private void SponeField()
    {
        GameObject go = Managers.Resource.Load<GameObject>("Prefabs/Fields/RoundField1");
        go = Instantiate<GameObject>(go) as GameObject;
        Managers.Field.SetField(go.GetComponent<RoundField>());
        Managers.Field.Init();
    }
    public void NextMonsterIndex()                          //��� ���� ��
    {
        if (monsterIndex < maxMonsterNum - 1)
        {
            monsterIndex++;
            SponeMonster();
        }
    }
}
