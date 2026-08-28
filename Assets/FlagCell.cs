using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FlagCell : MonoBehaviour
{
    public Sprite flagSprite;

    void Start()
    {
        SetUpTexture();
    }

    /// <summary>
    /// Updates the texture on this object.
    /// </summary>
    /// <param name="newSprite">The new sprite to be set.</param>
    public void UpdateTexture(Sprite newSprite)
    {
        this.flagSprite = newSprite;
        SetUpTexture();
    }

    /// <summary>
    /// Sets the sprite of the GameObject to be the one of the object.
    /// </summary>
    void SetUpTexture()
    {
        this.transform.GetChild(0).GetComponent<Image>().sprite = flagSprite;
    }
}
