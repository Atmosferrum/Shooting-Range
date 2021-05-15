using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    AudioSource ostAS; // Компонент Звука саундтрэка
    [SerializeField]
    AudioClip chill; // Спокойная музыка
    [SerializeField]
    AudioClip retro; // Ретро музыка
    [SerializeField]
    AudioClip intense; // Интенсивная музыка
    
    void Awake()
    {
        ostAS = GetComponent<AudioSource>(); // Получение компонента звука

        // Запуск необходимого тэека
        if (Options.OST == -1)
            ostAS.clip = chill;
        else if (Options.OST == 0)
            ostAS.clip = retro;
        else if (Options.OST == 1)
            ostAS.clip = intense;

        ostAS.Play(); // Проигрывание саундтрэка
    }

}
