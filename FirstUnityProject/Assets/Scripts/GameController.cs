using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

    public int maxCount;
    public float spawnRate;
    public Vector3 spawnPosition;
    public Vector2 minAnchor, maxAnchor;
    public List<GameObject> listOfTiles;
    public GameObject canvas;

    private float spawnTime;
    private int count;
    private GameObject newTile;

    private void Start()
    {
        spawnTime = spawnRate;
        count = 0;
    }

    private void Update()
    {
        if (spawnTime >= spawnRate)
        {
            if (count <= maxCount)
            {
                //spawn a random tile
                newTile = Instantiate(listOfTiles[Random.Range(0, listOfTiles.Count)]);
                newTile.GetComponent<RectTransform>().position = new Vector3(spawnPosition.x, spawnPosition.y + canvas.GetComponent<RectTransform>().position.y, spawnPosition.z);
                newTile.GetComponent<RectTransform>().anchorMax = maxAnchor;
                newTile.GetComponent<RectTransform>().anchorMin = minAnchor;
                newTile.transform.SetParent(canvas.GetComponent<Transform>());
                spawnTime = 0;
                count++;
            }
        }
        spawnTime += Time.deltaTime;
    }

    public void PopTiles(GameObject clicked)
    {
        Destroy(clicked);
        --count;
    }
}
