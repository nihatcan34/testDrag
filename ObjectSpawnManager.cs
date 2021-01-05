using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawnManager : MonoBehaviour
{
    //örneği oluştur
    private static ObjectSpawnManager _instance;
    public static ObjectSpawnManager instance
    {
        //örneğin boş olup olmadığını kontrol edin
        get
        {
            if (_instance == null)
            {
                if (_instance == null)
                    Debug.LogError("The GameManager is null");
            }


            return _instance;
        }
    }

    //örneği ata
    public void Awake()
    {
        _instance = this;
    }

    [SerializeField]
    private GameObject _koltukPrefab;
    [SerializeField]
    private GameObject _tablePrefab;
    [SerializeField]
    private GameObject _DoorPrefab;
    [SerializeField]
    private GameObject _WindowPrefab;
    [SerializeField]
    private GameObject _picturePrefab;
    [SerializeField]
    private GameObject _sofaPrefab;

    //Metotu oluştur
    public void StartSpawning()
    {
        Debug.Log("Spawn started");
        Instantiate(_koltukPrefab);
    }
    public void AddTable()
    {
        Instantiate(_tablePrefab);
    }
    public void AddDoor()
    {
        Instantiate(_DoorPrefab);
    }
    public void AddWindows()
    {
        Instantiate(_WindowPrefab);
    }
    public void AddPicture()
    {
        Instantiate(_picturePrefab);
    }
    public void AddSofa()
    {
        Instantiate(_sofaPrefab);
    }
}
