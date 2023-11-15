using UnityEngine;

public class Rotator: MonoBehaviour
{
    [SerializeField] private float _speed = 100f;

    private float _angle = 0;

    void Update()
    {
        _angle += _speed * Time.deltaTime;
        transform.rotation = Quaternion.Euler(0, _angle, 0);
    }
}
