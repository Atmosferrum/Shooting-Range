using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    GameObject obstacles; // Объект хранящий препятствия 
    [SerializeField]
    GameObject hoomanz; // Объект хранящий ложные мишени

    private void Awake()
    {
        Time.timeScale = 1;
    }

    private void Start()
    {
        // Включение препятствий
        if (Options.Difficulty >= 0)
            obstacles.SetActive(true);
        else
            obstacles.SetActive(false);

        // Включение ложных мишеней
        if (Options.Difficulty == 1)
            hoomanz.SetActive(true);
        else
            hoomanz.SetActive(false);
    }

}
