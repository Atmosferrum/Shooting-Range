using UnityEngine;
using UnityEngine.SceneManagement;

public class LvlLoader : MonoBehaviour
{
    /// <summary>
    /// ЗАШРУЗИТЬ нужный уровень
    /// </summary>
    /// <param name="sceneIndex">Индекс уровня</param>
    public void LoadScene(int sceneIndex) => SceneManager.LoadScene(sceneIndex);
}
