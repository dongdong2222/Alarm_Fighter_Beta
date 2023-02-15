using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniMonster_Parent : MonoBehaviour
{
    protected int maxHp = 1;
    protected int currentHp;

        
    protected Define.State nextBehavior = Define.State.ATTACKREADY;
    protected Define.PlayerMove nextDirection;

    protected int current_X, current_Y;
    protected int move_X, move_Y;
    protected int towardPlayer_X, towardPlayer_Y;
    
    protected float speed;

    protected int a = 0, b = 0;


    //maygo�� ������ Attack()�� ȣ��
    //maygo�� moveGridInd�� �ٲٸ� �ű�� RMons1�� �ٷ� �̵�
    protected void mayGo(Define.PlayerMove direction)
    {
        move_X = current_X;
        move_Y = current_Y;

        // ������ �� �ִ� �ε������� �˻�
        if (direction == Define.PlayerMove.Up)
        {
            move_Y -= 1;
            if (move_Y < 0)
                move_Y = current_Y;
        }
        else if (direction == Define.PlayerMove.Down)
        {
            move_Y += 1;
            if (move_Y > Managers.Field.GetHeight() - 1)
                move_Y = current_Y;
        }
        else if (direction == Define.PlayerMove.Left)
        {
            move_X -= 1;
            if (move_X < 0)
                move_X = current_X;
        }
        else if (direction == Define.PlayerMove.Right)
        {
            move_X += 1;
            if (move_X > Managers.Field.GetWidth() - 1)
                move_X = current_X;
        }
    }

    public void ChooseLeftOrRight()
    {
        if (Math.Sign(towardPlayer_X) == -1)
        {
            nextDirection = Define.PlayerMove.Left;
            a = -1; b = 0;
        }
        else
        {
            nextDirection = Define.PlayerMove.Right;
            a = 1; b = 0;
        }
    }

    public void ChooseUpOrDown()
    {
        if (Math.Sign(towardPlayer_Y) == -1)
        {
            nextDirection = Define.PlayerMove.Up;
            a = 0; b = -1;
        }
        else
        {
            nextDirection = Define.PlayerMove.Down;
            a = 0; b = 1;
        }
    }

    IEnumerator ActiveDamageField(GameObject go)            //�ڷ�ƾ�� ������ ���� ����˴ϴ�.
    {
        Debug.Log("Grid tile Collider Activatied");
        PolygonCollider2D poly = go.GetComponent<PolygonCollider2D>();
        poly.enabled = true;                                //Damage���� collider Ȱ��ȭ(���)
        yield return new WaitForFixedUpdate();              //yield ��ȯ ������ ������ �Ͻ� �����ǰ� ���� �����ӿ��� �ٽ� ���۵Ǵ� ����
        poly.enabled = false;
    }

    protected virtual void AutoBitBehave() { }

    //�������̵� �Ǿ�� �� �Լ�
    //MyPlayer�� ��ġ�� ����������� ���� ���� ����
    protected virtual void SelectNextDirection() { }

    protected virtual void AutoWarningAttack(Define.PlayerMove nextDirection) { }

    protected virtual void AutoAttack(Define.PlayerMove nextDirection) { }
    
    protected virtual void Die() { }
}
