using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform playerTr;
    public Camera camera;
    public float cameraDistance = 10f;
    Vector3 cameraPosition;
    // Start is called before the first frame update
    void Start()
    {
        cameraPosition = new Vector3(playerTr.position.x,playerTr.position.y,-cameraDistance);
        camera = gameObject.GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        cameraPosition = new Vector3(playerTr.position.x, playerTr.position.y, -cameraDistance);
        transform.position = cameraPosition;
    }
}
