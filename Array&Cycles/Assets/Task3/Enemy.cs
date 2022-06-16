using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    public Text NameText, LevelText, HealText;
    public Slider SliderHeal;
    public string Name;
    public int Heal;
    public int Level;
    [HideInInspector] public int MaxHeal = 100;
    public GameObject GO;
    public void Start()
    {
        NameText.text = Name;
        LevelText.text = $"Level: {Level}";
        HealText.text = $"{Heal}/{MaxHeal}";
        SliderHeal.value = Heal;
    }
}