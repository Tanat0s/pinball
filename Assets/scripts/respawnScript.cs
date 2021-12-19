using UnityEngine;

public class respawnScript : MonoBehaviour
{
    private const float respawnValue = 4;
    [SerializeField] private Transform respawnPosition;
    private Transform _ball;

    // Start is called before the first frame update
    void Start()
    {
        _ball = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_ball.transform.position.y < respawnValue)
            _ball.transform.position = respawnPosition.position;
    }
}
