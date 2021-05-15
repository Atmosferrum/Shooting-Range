using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Difficulty : MonoBehaviour
{
    /// <summary>
    /// ВЫБОР сложности игры
    /// </summary>
    /// <param name="choice">Выбор игрока</param>
    public void SetDifficulty(int choice) => Options.Difficulty = choice;
}
