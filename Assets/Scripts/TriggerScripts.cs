using UnityEngine;

public class TriggerScripts : MonoBehaviour
{   
    private int trigNum;
    void Start()
    {
        trigNum = int.Parse(gameObject.name.Split("_")[1]);
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (TriggerManager.Instance.trigger1.activeSelf)
            {
                switch (trigNum)
                {
                    case 1:
                        TriggerManager.Instance.trigger2.SetActive(true);
                        break;
                    case 2:
                        TriggerManager.Instance.trigger3.SetActive(true);
                        TriggerManager.Instance.trigger2.SetActive(false);
                        break;
                    case 3:
                        TriggerManager.Instance.trigger3.SetActive(false);
                        TriggerManager.Instance.teleport1.SetActive(true);
                        //Unlock Teleport1
                        break;
                    case 4:
                        TriggerManager.Instance.teleport2.SetActive(true);
                        break;
                    case 5:
                        TriggerManager.Instance.UIscreen.SetActive(true);
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
