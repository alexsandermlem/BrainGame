using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Level : MonoBehaviour
{
    public Text Title;

    private void Start()
    {
        Title.text = (Data.IndexLevelCurrent + 1).ToString();
    }
}
