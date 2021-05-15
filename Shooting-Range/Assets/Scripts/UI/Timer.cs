using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class Timer : MonoBehaviour
{
    [SerializeField]
    float time = 60; // Время до завершения Уровня
    [SerializeField]
    float timeCtrl = 1; // Контроль скоростии таймера
    TextMeshProUGUI timerTxt; // Поле таймера
    TimeSpan countDown; // Таймер
    bool stop = false;
    [SerializeField]
    GameObject endScreen;

 
    void Start()
    {
        timerTxt = GetComponent<TextMeshProUGUI>(); // Получение компонента Текста для Таймера
        countDown = TimeSpan.FromSeconds(time); // Инициализация Таймера
    }

    void Update()
    {
        countDown = countDown.Subtract(TimeSpan.FromSeconds(timeCtrl * Time.deltaTime)); // Сокращение таймера
        string timeText = string.Format("{0:D2}:{1:D2}", countDown.Minutes, countDown.Seconds); // Форматирование времени
        timerTxt.text = $"{timeText}"; // Вывод времени

        // Если Таймер равен 0 заверщить игру
        if (!stop && countDown <= TimeSpan.Zero)
        {
            endScreen.SetActive(true);
            stop = true;
        }
    }
}
