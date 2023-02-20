using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HpBar : MonoBehaviour
{
    Slider slider;

    public float maxValue;
    private void Start()
    {
        slider = GetComponent<Slider>();
    }
    public void updateValue(float currentHP, float maxHP)      //Slider 컴포넌트 초기화
    {
        slider.value = currentHP / maxHP;
    }
}
