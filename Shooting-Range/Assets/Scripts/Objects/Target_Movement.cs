using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target_Movement : MonoBehaviour
{
    Vector3 target; // Цель для передвижения
    float timeToChangeTarget = 2f; // Время получения новой цели
    [SerializeField]
    float speed = 10f; // Скоросьть передвижения
    float step; // Шаг для передвижения
    [SerializeField]
    Transform player; // Положение игрока 

    private void Start()
    {
        GetRandomTarget(); 
        StartCoroutine(ChangeTargetPosition());
    }

    void Update()
    {
        Move();
    }

    /// <summary>
    /// ПЕРЕДВИЖЕНИЕ
    /// </summary>
    void Move()
    {
        step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, target, step);
        transform.LookAt(player);
    }

    /// <summary>
    /// ПОЛУЧЕНИЕ рандомной цели для передвижения
    /// </summary>
    void GetRandomTarget()
    {
        target = new Vector3(Random.Range(-50, 50), Random.Range(1, 10), transform.position.z);
    }

    /// <summary>
    /// ПОЛУЧЕНИЕ новой рандомной цели
    /// </summary>
    /// <returns>Новая рандомная цели</returns>
    IEnumerator ChangeTargetPosition()
    {
        yield return new WaitForSeconds(timeToChangeTarget);
        GetRandomTarget();
        StartCoroutine(ChangeTargetPosition());

    }


}
