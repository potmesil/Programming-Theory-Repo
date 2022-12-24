using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(SpriteRenderer))]
public abstract class Shape : MonoBehaviour
{
    [field: SerializeField] private Text Message { get; set; }
    [field: SerializeField] protected string ColorName { get; private set; }

    private string Name { get; set; }
    private Color Color { get; set; }

    protected virtual void Start()
    {
        Name = gameObject.name;
        Color = GetColor(ColorName);
        GetComponent<SpriteRenderer>().color = Color;
    }

    private void OnMouseDown()
    {
        Message.text = DisplayText();
        Message.color = Color;
    }

    protected abstract string DisplayText();

    private Color GetColor(string colorName)
    {
        if (!ColorUtility.TryParseHtmlString(colorName, out var c))
        {
            Debug.LogError($"Bad color on {gameObject.name}");
        }

        return c;
    }
}