using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target_Hit : MonoBehaviour, ITarget
{
    AudioSource targetAS; // Компонент Звука
    [SerializeField]
    int amount; // Количество очков
    [SerializeField]
    Result result; // Контроллер результатов

    private void Start()
    {
        targetAS = GetComponent<AudioSource>(); // Получение компонента Звука
    }

    /// <summary>
    /// ПОЛУЧЕНИЕ урона
    /// </summary>
    public void GetHit()
    {
        targetAS.Play(); // Проигрывание звукового эффекта поподания
        result.UpdateScore(amount); // Коррекция Результата
    }
}
