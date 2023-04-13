using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * This component destroys its object whenever it triggers a 2D collider with the given tag.
 */
public class DestroyOnTrigger2D : MonoBehaviour
{
    [Tooltip("Every object tagged with this tag will trigger the destruction of this object")]
    [SerializeField] string triggeringTag;
    [SerializeField] NumberField lifeField;
    [SerializeField] int subLife;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == triggeringTag && lifeField != null && enabled)
        {
            if (lifeField.GetNumber() > 1)
            {
                lifeField.SubNumber(subLife);
                Destroy(other.gameObject);
            }
            else
            {
                Destroy(this.gameObject);
                Destroy(other.gameObject);
            }
        }
    }

    public void SetLifeField(NumberField newTextField)
    {
        this.lifeField = newTextField;
    }
}