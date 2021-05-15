using System;
using System.Text;
using UnityEngine;
using TMPro;
using System.Collections.Generic;

public class EndScreen : MonoBehaviour
{
    [SerializeField]
    Result result; // Контрллер вывода Резултатов
    int[] scores = { 0, 0, 0, 0, 0}; // Рекорды
    List<int> scoresList = new List<int>();
    const string scoresSaveName = "Hi-Scores"; // Имя сохранения Рекордов
    [SerializeField]
    TextMeshProUGUI scoresTxt; // Текст для вывода Рекордов
    [SerializeField]
    GameObject player; // Объект игрока

    private void OnEnable()
    {
        player.SetActive(false); // Отключение игрока

        // Проверка на присутсвие сохранёных ранее Рекордов
        if (PlayerPrefsX.GetIntArray(scoresSaveName) != null)
            scores = PlayerPrefsX.GetIntArray(scoresSaveName, 0, 5);

        SortDescending();

        // Проверка и присвоение резульаьа если он выше чем предыдущие рекорды
        //for (int i = 0; i < scores.Length; i++)
        //{
        //    scoresList.Add(scores[i]);

        //    if (scores[i] < result.result)
        //    {
        //        scoresList.Add(result.result);
        //        break;
        //    }
        //}

        //scoresList.Sort();
        //scoresList.Reverse();
        //scoresList.RemoveAt(scoresList.Count - 1);
        //scores = scoresList.ToArray();

        PlayerPrefsX.SetIntArray(scoresSaveName, scores); // Сохранение Рекордов

        // Создание Строки Рекордов
        StringBuilder sb = new StringBuilder();
        sb.AppendLine(scoresSaveName + " : ");

        // Добавление всех Рекордов в Строку
        for (int i = 0; i < scores.Length; i++)
        {
            sb.AppendLine($"{i+1}. {scores[i]}");
        }
        
        //Вывод Рекод=рдов на экран
        scoresTxt.text = sb.ToString();

        // Осановка времени (чтобы ничего не мешало)
        Time.timeScale = 0;

        // Разблокировка Курсора
        Cursor.lockState = CursorLockMode.None;
    }

    /// <summary>
    /// СОРТИРОВКА массива Рекордов
    /// </summary>
    void SortDescending()
    {
        Array.Sort(scores); // Сортировка Рекордов
        Array.Reverse(scores); // Сортировка Рекордов по убыванию

        // Добавление всех предыдущих рекордов Лист
        for (int i = 0; i < scores.Length; i++)
            scoresList.Add(scores[i]);

        // Проверка и присвоение резульаьа если он выше чем предыдущие рекорды
        for (int i = 0; i < scores.Length; i++)
        {
            if (scores[i] < result.result)
            {
                scoresList.Add(result.result);
                break;
            }
        }

        scoresList.Sort();
        scoresList.Reverse();
        scoresList.RemoveAt(scoresList.Count - 1);
        scores = scoresList.ToArray();
    }
}
