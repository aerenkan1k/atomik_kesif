using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public List<GameObject> gameObjects = new List<GameObject>();

    void Start()
    {
        PlaceObjectsRandomly();
    }

    void PlaceObjectsRandomly()
    {
        foreach (var obj in gameObjects)
        {
            Vector2 randomPosition = new Vector2(Random.Range(-7.5f, 7.5f), Random.Range(-4f, 4f));
            obj.transform.localScale = new Vector3(3f, 3f, 3f);
            Instantiate(obj, randomPosition, Quaternion.identity);
        }
    }
}
