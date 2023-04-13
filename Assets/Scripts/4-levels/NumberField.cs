using TMPro;
using UnityEngine;

/**
 * This component should be attached to a TextMeshPro object.
 * It allows to feed an integer number to the text field.
 */
[RequireComponent(typeof(TextMeshPro))]
public class NumberField : MonoBehaviour {
    [SerializeField] int number;
    [SerializeField] string text;

    public void Start()
    {
        GetComponent<TextMeshPro>().text = text + this.number.ToString();
    }

    public int GetNumber() {
        return this.number;
    }

    public void SetNumber(int newNumber) {
        this.number = newNumber;
        GetComponent<TextMeshPro>().text = text + newNumber.ToString();
    }

    public void AddNumber(int toAdd) {
        SetNumber(this.number + toAdd);
    }
    public void SubNumber(int toSub)
    {
        SetNumber(this.number - toSub);
    }
}
