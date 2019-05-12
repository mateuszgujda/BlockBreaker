using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{

    [SerializeField] float ScreenWidthInUnits = 16f;
    [SerializeField] float minX = 1f;
    [SerializeField] float maxX = 15f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float MouseXinUnits = Input.mousePosition.x / Screen.width * ScreenWidthInUnits;
        MouseXinUnits = Mathf.Clamp(MouseXinUnits, minX, maxX);
        Vector2 newPosition = new Vector2(MouseXinUnits,transform.position.y);
        transform.position = newPosition;
    }
}
