using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * This component destroys its object whenever it triggers a 2D collider with the given tag.
 */
public class DestroyOnTrigger2D : MonoBehaviour
{
    [Tooltip("Every object tagged with this tag will trigger the destruction of this object")]
    [SerializeField] string dmgTag;
    [SerializeField] string hpTag;
    [SerializeField] NumberField lifeField;
    [SerializeField] int lifeScaler;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == dmgTag && lifeField != null && enabled)
        {
            if (lifeField.GetNumber() > 1)
            {
                lifeField.SubNumber(lifeScaler);
                Destroy(other.gameObject);
            }
            else
            {
                lifeField.SetNumber(0);
                Destroy(this.gameObject);
                Destroy(other.gameObject);
            }
        }
        if(other.tag == hpTag && lifeField != null)
        {
            lifeField.AddNumber(lifeScaler);
            Destroy(other.gameObject);
        }
    }

    public void SetLifeField(NumberField newTextField)
    {
        this.lifeField = newTextField;
    }
}