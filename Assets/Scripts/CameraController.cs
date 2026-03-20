using UnityEngine;

public class CameraController : MonoBehaviour
{
    Transform playerPos;
    PlayerController player;
    [SerializeField] private Vector3 offset = new Vector3(0, 1, -5);

    void Start()
    {
        player = FindFirstObjectByType<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        playerPos = player.transform;
        transform.position = playerPos.position + offset;
    }
}
