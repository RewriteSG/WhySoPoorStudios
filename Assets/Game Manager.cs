using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private static GameManager m_instance;

    [SerializeField]
    private PlayerStat playerStat;

    public int quota;
    public int day = 1;

    private void Awake()
    {
        if (m_instance != null)
        {
            Destroy(gameObject);
            m_instance.playerStat = FindAnyObjectByType<PlayerStat>();
            return;
        }
        else
        {
            m_instance = this;
            DontDestroyOnLoad(gameObject);
            playerStat = FindAnyObjectByType<PlayerStat>();
        }
    }

    public void Update()
    {
        if(playerStat.GetCurrency() >= quota)
        {
            Debug.Log("You win");
            //Show win menu
            if (Input.GetKeyDown(KeyCode.Space))
            {
                day++;
                quota = quota + quota / 2;
                SceneManager.LoadScene(0);
            }
        }
    }
}
