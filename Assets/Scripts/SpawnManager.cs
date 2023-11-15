using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] GameObject objectPrefab;
    [SerializeField] float _spawnRate = 1;
    [SerializeField] int _numberOfObjectsToSpawn = 10;

    void Start()
    {
        StartCoroutine("Spawn"); //Tambien se puede escribir asi StartCoroutine(Spawn());

        //StopCoroutine("Spawn"); o StartCoroutine(Spawn());

        //StopAllCoroutines(); para parar todas las corutinas

    }

    
    void Update()
    {

    }

    IEnumerator Spawn() //Las corrutinas al contrario que las funciones se pueden parar
    {
        for (int i = 0; i < _numberOfObjectsToSpawn; i++)
        {
            Instantiate(objectPrefab, transform.position, transform.rotation); //Para generar el spawn de la moneda
            yield return new WaitForSeconds(_spawnRate); //Para que la co-rutina espere la cantidad de tiempo especificada
        }
    }
}
