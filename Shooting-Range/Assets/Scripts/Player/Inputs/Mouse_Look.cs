using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse_Look : MonoBehaviour
{
    [SerializeField]
    float sensitivity = 5f; // Чувствительность мыши

    private void Update()
    {
        MouseLook();        
    }

    /// <summary>
    /// СМОТРЕТЬ по сторонам
    /// </summary>
    private void MouseLook()
    {
        float x = Input.GetAxis("Mouse Y"); // Получение данных для вращения по X
        float y = Input.GetAxis("Mouse X"); // Получение данных для вращения по Y
        float yRotation = -y;
        yRotation = Mathf.Clamp(yRotation, -90f, 90f); // Ограничение для вращения по оси Y

        Vector3 rotateValue = new Vector3(x * sensitivity, yRotation * sensitivity, 0); // Преобразование дааных для вращения
        transform.eulerAngles = transform.eulerAngles - rotateValue; // Поворот камеры
    }
}
