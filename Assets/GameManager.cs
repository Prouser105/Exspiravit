using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject playerPrefab;
    public Transform spawnPoint;
    


    private void Start()
    {
        SpawnPlayer();
        playerPrefab.TryGetComponent(out FadeCamera fadeCamera);
        fadeCamera.gameStart = true;




    }

    public void SpawnPlayer()
    {
        Instantiate(playerPrefab, spawnPoint.position, Quaternion.identity);
        

        // Получить компонент камеры игрока
        Camera playerCamera = playerPrefab.GetComponentInChildren<Camera>();

        // Изменить вращение камеры
        playerCamera.transform.rotation = Quaternion.Euler(90f, 0f, 0f); // Смотреть в сторону оси Z
    }
}

