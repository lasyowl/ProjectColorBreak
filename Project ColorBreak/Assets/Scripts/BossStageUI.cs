﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BossStageUI : MonoBehaviour
{
    public GameObject       go_BossStageUI;
    public Text             bossHp_Text;
    public Text             damage_Text;
    public Image            bossHpSlider;
    

    private float ratio;
    private float minPositionX = -365f;
    private float maxPositionX = 365f;

    public void UpdateBossHpText(int _currentBossHp)
    {
        bossHp_Text.text = StageManager.instance.currentBossStageSlot.maxHp.ToString() + " / " +  _currentBossHp.ToString();
    }

    public void UpdateDamageText(int _currentDamage)
    {
        damage_Text.text = "Damage : " + _currentDamage.ToString();                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                          
    }

    public IEnumerator UpdateBossHpSliderCoroutine(int _currentBossHp)
    {
        while (bossHpSlider.fillAmount > StageManager.instance.currentBossStageSlot.currentHp / (float)StageManager.instance.currentBossStageSlot.maxHp)
        {
            bossHpSlider.fillAmount -= Time.deltaTime;

            yield return null;
        }
    }
}