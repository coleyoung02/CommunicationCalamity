using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GemUI : MonoBehaviour
{
    public static GemUI Instance;
    private int gems;
    private int gemsThisLevel;
    [SerializeField] private TextMeshProUGUI textMesh;


    void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    public void OnDeath()
    {
        gems -= gemsThisLevel;
        gemsThisLevel = 0;
        textMesh.text = gems.ToString();
    }

    public void OnLevelClear()
    {
        gemsThisLevel = 0;
    }

    public void OnGemPickup()
    {
        gems += 1;
        textMesh.text = gems.ToString();
    }
}
