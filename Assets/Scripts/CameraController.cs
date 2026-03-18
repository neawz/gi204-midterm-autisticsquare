using UnityEngine;

public class CameraController : MonoBehaviour
{
    Transform playerPos;
    PlayerController player;
    [SerializeField] Vector3 offset;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player = FindFirstObjectByType<PlayerController>();
        offset = new Vector3(0, 1, -5);
    }

    // Update is called once per frame
    void Update()
    {
        playerPos = player.transform;
        transform.position = playerPos.position + offset;
    }
}
