using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse_Shoot : MonoBehaviour
{
    AudioSource gunAS; // Компонент Звука оружия    
    Animator gunAnim; // Аниматор оружия 
    const string shootAnimName = "Shoot"; // Название Анимации выстрела
    bool canShoot = true; // Блокировка стрельбы
    [SerializeField]
    float shootCDTime = 0.25f; // Время между выстрелами

    private void Start()
    {
        gunAS = GetComponent<AudioSource>(); // Получение компонента Звука
        gunAnim = GetComponent<Animator>(); // Получение компонента Аниматора
        Cursor.lockState = CursorLockMode.Locked; // Блокировка Курсора мыши
    }

    void Update()
    {
        // Если нажали ЛКМ и КД откатился то Стреляем
        if (Input.GetMouseButtonDown(0))
            if (canShoot)
                Shoot();
    }

    /// <summary>
    /// СТРЕЛЬБА
    /// </summary>
    void Shoot()
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition); // "Луч" для получения объекта поподания
        if (Physics.Raycast(ray, out hit))
        {
            // Если у объектиа есть интерфейс Цели тогда наносим урон
            if (hit.transform.gameObject.GetComponent<ITarget>() != null)
                hit.transform.gameObject.GetComponent<ITarget>().GetHit();
        }

        gunAS.Play(); // Воспроизвести звук стрельбы
        gunAnim.SetTrigger(shootAnimName); // Воспроизвести анимацию стрельбы
        canShoot = false; // Блокировка стрельбы
        StartCoroutine(ShootCD()); // Запуск "охлаждения" оружия
    }

    /// <summary>
    /// ЗАДЕРЖКА выстрелов
    /// </summary>
    /// <returns>Разрешение стрелять</returns>
    IEnumerator ShootCD()
    {
        yield return new WaitForSeconds(shootCDTime);
        canShoot = true;
    }
}
