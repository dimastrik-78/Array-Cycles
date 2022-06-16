using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyChanger : MonoBehaviour
{
    public Enemy[] enemyChangerList;
    public InputField InputText;
    public void IndisibleHeal()
    {
        int Num = int.Parse(InputText.text);
        for (int i = 0; i < enemyChangerList.Length; i++)
        {
            if (enemyChangerList[i].Heal < Num)
            {
                enemyChangerList[i].GO.SetActive(false);
            }
        }
    }
    public void IndisibleLevel()
    {
        int Num = int.Parse(InputText.text);
        for (int i = 0; i < enemyChangerList.Length; i++)
        {
            if (enemyChangerList[i].Level != Num)
            {
                enemyChangerList[i].GO.SetActive(false);
            }
        }

    }
    public void CreateBoss()
    {
        for (int i = 0; i < enemyChangerList.Length; i++)
        {
            if (enemyChangerList[i].NameText.text == InputText.text)
            {
                enemyChangerList[i].NameText.text = "Boss";
                enemyChangerList[i].HealText.text = $"{enemyChangerList[i].Heal * 3}/{enemyChangerList[i].MaxHeal * 3}";
                enemyChangerList[i].LevelText.text = $"Level: {++enemyChangerList[i].Level}";
            }
        }
    }
    public void BackAll()
    {
        for (int i = 0; i < enemyChangerList.Length; i++)
        {
            enemyChangerList[i].GO.SetActive(true);
            enemyChangerList[i].Start();
        }
    }
}
