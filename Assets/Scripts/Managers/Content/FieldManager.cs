using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FieldManager
{
    private RoundField roundField;

    public void SetField(RoundField roundField) { this.roundField = roundField; }
    public RoundField GetField() { return this.roundField; }
    public List<List<FieldInfo>> GetGridArray() { return roundField.GetGridArray(); }
    public FieldInfo GetFieldInfo(int x, int y){return roundField.GetFieldInfo(x,y);}
    public GameObject GetGrid(int x, int y) { return roundField.GetGrid(x,y); }
    public void ChangeGrid(int x, int y, Define.GridState state) { roundField.ChangeGrid(x,y,state); }
    public void ScaleByRatio(GameObject go, int x, int y) { roundField.ScaleByRatio(go, x, y); }
    public int GetHeight() { return roundField.GetHeight(); }
    public int GetWidth() { return roundField.GetWidth(); }
    public void Init() { roundField.Init(); }
}
