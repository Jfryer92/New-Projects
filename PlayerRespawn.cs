using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerRespawn : MonoBehaviour
{
    public static Vector3 LastCheckPointPos = new Vector3(805, 100,500);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
     private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject[] sample = GameObject.FindGameObjectsWithTag("Player");
            sample[0].transform.position = LastCheckPointPos;
        }
    }

}
