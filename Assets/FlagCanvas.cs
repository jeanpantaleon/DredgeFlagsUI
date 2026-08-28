using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlagCanvas : MonoBehaviour
{
    public List<Sprite> flagList = new List<Sprite>();

    public GameObject FlagCellPrefab;

    public GameObject CellsContainer;

    void Start()
    {
        RefreshFlags();
    }

    public void RefreshFlags()
    {
        ClearFlags();
        InstantiateGridElements();
    }

    public void InstantiateGridElements()
    {
        foreach (Sprite flag in flagList)
        {
            GameObject gridElement = Instantiate(FlagCellPrefab, this.CellsContainer.transform);
            gridElement.GetComponent<FlagCell>().UpdateTexture(flag);
        }
    }

    public void ClearFlags()
    {
        foreach (Transform child in CellsContainer.transform)
        {
            DestroyImmediate(child.gameObject);
        }
    }
}
