using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(SpriteRenderer))]
public class Tile : MonoBehaviour
{
    int value;

    SpriteRenderer spriteRenderer;
    [SerializeField]Sprite[] sprites;

    public Tile(int _value) {
        this.value = _value;
    }

    public void setValue(int _value) {
        value = _value;
    }

    public int getValue() {
        return value;
    }

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = sprites[value];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
