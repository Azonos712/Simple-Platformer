using UnityEngine;

public class Selectable : MonoBehaviour
{
    public Color SelectedColor;
    private Renderer _renderer;
    private Color _originalColor;
    void Start()
    {
        _renderer = GetComponent<Renderer>();
        _originalColor = _renderer.material.color;
    }
    public void Select()
    {
        _renderer.material.color = SelectedColor;
    }
    public void Deselect()
    {
        _renderer.material.color = _originalColor;
    }
}