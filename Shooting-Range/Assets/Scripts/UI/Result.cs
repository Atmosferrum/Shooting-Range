using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Result : MonoBehaviour
{
    TextMeshProUGUI resultTxt; // Получение компонента Текса для вывода Результатов
    public int result = 0; // Результат

    void Start()
    {        
        resultTxt = GetComponent<TextMeshProUGUI>();
    }

    /// <summary>
    /// ВЫВОД резултата
    /// </summary>
    /// <param name="amount"></param>
    public void UpdateScore(int amount) => resultTxt.text = $"Result : {result += amount}";
}
