using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlacingCupcakeTowerScript : MonoBehaviour
{
    private GameManagerScript gameManager;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = FindObjectOfType<GameManagerScript>();
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.mousePosition.x;
        float y = Input.mousePosition.y;

        transform.position = Camera.main.ScreenToWorldPoint(new Vector3(x, y, 7));

        if(Input.GetMouseButtonDown(0) && gameManager.isPointerOnAllowedArea())
        {
            GetComponent<CupcakeTowerScript>().enabled = true;
            gameObject.AddComponent<BoxCollider2D>();
            Destroy(this);
        }
    }
}
