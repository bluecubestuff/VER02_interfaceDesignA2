using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonMovement : MonoBehaviour {

    public float boundaryX;
    public float speed;
    public GameObject gameController;

    private bool move;
    private int ID;

    private void Start()
    {
        move = true;
    }

    private void Update()
    {
        Vector3 newPostion = gameObject.GetComponent<RectTransform>().position;
        if (newPostion.x <= boundaryX)
        {
            if (move)
            {
                newPostion.x += speed * Time.deltaTime;
                gameObject.GetComponent<RectTransform>().position = newPostion;
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        move = false;
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        move = true;
    }

    public void Clicked()
    {
        Debug.Log("Clicked!");
        gameController.GetComponent<GameController>().PopTiles(gameObject);
    }

    public int GetID() { return ID; }
    public void SetID(int _id) { ID = _id; }
}
