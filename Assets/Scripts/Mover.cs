using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private Vector3 _endPoint;
    [SerializeField] private float _speed = 1f;

    private void Update() =>
        transform.position = Vector3.MoveTowards(transform.position, _endPoint, _speed * Time.deltaTime);
}
