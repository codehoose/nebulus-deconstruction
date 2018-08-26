using UnityEngine;

public class TowerRotation : MonoBehaviour {

    const string DetailAlbedoMap = "_DetailAlbedoMap";
    const string HorizontalAxis = "Horizontal";

    Material _material;

    float _speed = 0.5f;
    float _xOff = 0f;
    float _yOff = 0f;

    private void Awake()
    {
        _material = GetComponent<MeshRenderer>().material;
        
    }

    private void Update()
    {
        _material.SetTextureScale(DetailAlbedoMap, new Vector2(1, transform.localScale.z));
        _xOff = Time.deltaTime * _speed * -Input.GetAxis(HorizontalAxis) + _xOff;
        if (_xOff > 1f)
            _xOff -= 1f;
        else if (_xOff < -1f)
            _xOff += 1f;

        _material.SetTextureOffset(DetailAlbedoMap, new Vector2(_xOff, _yOff));
    }
}
