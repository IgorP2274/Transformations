using UnityEngine;

public class Enlager : MonoBehaviour
{
    [SerializeField] private float _speed = 0.1f;
    [SerializeField] private float _endScale = 3;

    private Vector3 _scaleChange;

    private void Start() =>
        _scaleChange = new Vector3(_speed, _speed, _speed);

    private void Update()
    {
        if (transform.localScale.y < _endScale) 
            transform.localScale += _scaleChange * Time.deltaTime;
    }
}
