using UnityEngine;

public class SetOST : MonoBehaviour
{
    /// <summary>
    /// ВЫБОР саундтрэка игры и ЗАГРУЗКА уровня
    /// </summary>
    /// <param name="choice">Выбор игрока</param>
    public void SetGameOST(int choice) => Options.OST = choice; 
}
