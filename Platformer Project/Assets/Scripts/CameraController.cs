using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject Player;
    private Vector3 Offset;
    // Start is called before the first frame update
    void Start()
    {
        Offset = this.transform.position - Player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mouseOffset = (Input.mousePosition - new Vector3(Screen.width, Screen.height, 0)).normalized;
        this.transform.position = Player.transform.position + Offset + mouseOffset;
    }
}
