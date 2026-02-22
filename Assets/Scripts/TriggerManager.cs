using UnityEngine;

public class TriggerManager : MonoBehaviour
{
    public static TriggerManager Instance {get;private set;}
    public GameObject trigger1;
    public GameObject trigger2;
    public GameObject trigger3;
    public GameObject teleport1;
    public GameObject teleport2;
    public GameObject UIscreen;

    void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
    void Start()
    {
        trigger1.SetActive(true);
        trigger2.SetActive(false);
        trigger3.SetActive(false);
        teleport1.SetActive(false);
        teleport2.SetActive(false);
        UIscreen.SetActive(false);
    }
}
