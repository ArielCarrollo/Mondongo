using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mondongo : MonoBehaviour
{
    private Transform _compTransform;
    private SpriteRenderer _compSpriteRenderer;
    public float speed;
    public int Direction1;
    public int Direction2;
    // Start is called before the first frame update
    private void Awake()
    {
        _compTransform = GetComponent<Transform>();
        _compSpriteRenderer = GetComponent<SpriteRenderer>();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _compTransform.position = new Vector2(_compTransform.position.x + speed *Direction1*Time.deltaTime, _compTransform.position.y + speed * Direction2 * Time.deltaTime);
        if(_compTransform.position.x > 8.75f)
        {
            Direction1 = -1;
            _compSpriteRenderer.flipX = true;
        }
        if (_compTransform.position.x < -8.75f)
        {
            Direction1 = 1;
            _compSpriteRenderer.flipX = false;
        }
        if (_compTransform.position.y > 4.88f)
        {
            Direction2 = -1;
            _compSpriteRenderer.flipY = true;
        }
        if (_compTransform.position.y < -4.88f)
        {
            Direction2 = 1;
            _compSpriteRenderer.flipY = false;
        }

    }
}
