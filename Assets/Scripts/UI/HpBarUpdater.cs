using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HpBarUpdater : MonoBehaviour
{
    [SerializeField]
    public GameObject hpbar;

    Stat stat;
    Slider slider;

    void Start()
    {
        stat = GetComponent<Stat>();

        GameObject hpslider = Util.FindChild(hpbar, "Slider");
        slider = hpslider.GetComponent<Slider>();
        slider.value = 1;
    }

    // Update is called once per frame
    void Update()
    {
        slider.value = (float)stat.CurrentHP / (float)stat.MaxHP;
    }

    public Slider GetSliderComponent()
    {
        GameObject hpslider = Util.FindChild(hpbar, "Slider");
        return hpslider.GetComponent<Slider>();
    }

}
