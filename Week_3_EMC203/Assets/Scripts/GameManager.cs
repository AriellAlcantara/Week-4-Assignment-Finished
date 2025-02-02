using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    public TextMeshProUGUI hpText;
    public int playerHP = 10;
    public int gold = 0;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void AddGold(int amount)
    {
        gold += amount;
        Debug.Log("Gold: " + gold);
    }

    void Start()
    {
        UpdateHPUI();
    }

    public void DecreaseHP()
    {
        playerHP--;
        UpdateHPUI();

        if (playerHP <= 0)
        {
            ShowGameOverScreen();
        }
    }

    private void UpdateHPUI()
    {
        if (hpText != null)
        {
            hpText.text = "HP: " + playerHP;
        }
    }

    private void ShowGameOverScreen()
    {
        Debug.Log("Game Over!");
        // Implement UI logic for failure screen
    }
}
