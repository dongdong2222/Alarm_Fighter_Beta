using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    protected int current_X, current_Y;
    protected int move_X, move_Y;
    protected float speed;

    // Charater�� ���� X�� Y Index ��ȯ
    public int GetCharacterInd_X()
    {
        return current_X;
    }
    public int GetCharacterInd_Y()
    {
        return current_Y;
    }

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
    // ���ٰ��� ����� ���� ���ؼ��� ������ �ٲٸ� �� (2.11 ���� �߰�)
    //protected void ChangeSize(int current_Y)
    //{
    //    // fieldmanager���� �����ͼ� �����ϱ�
    //    Vector3 size = new Vector3((float)(current_Y + 1) * 0.16f, (float)(current_Y + 1) * 0.16f, (float)(current_Y + 1) * 0.16f);
    //    this.transform.localScale = size;
    //}

    protected void Attack()
    {

    }
}
