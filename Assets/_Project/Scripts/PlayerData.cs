using UnityEngine;

public class PlayerData : MonoBehaviour
{
    public static PlayerData Instance;

    public float cash = 1000f;
    public float netWorth = 1000f;
    public int currentMonth = 1;
    public string career = "Estudiante";

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(this);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
