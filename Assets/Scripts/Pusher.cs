using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class Pusher : MonoBehaviour
{
    int num = 0;
    public GameObject gameObject = default;

    // Start is called before the first frame update
    void Start()
    {
        num = 1 + 1;
        UnityEngine.Debug.Log(num);
    }

    // Update is called once per frame
    void Update()
    {
        // Zè„ÇÃílÇâ¡éZÇ∑ÇÈ
        gameObject.transform.position = gameObject.transform.position + new Vector3(0, 0, -1);
    }
}
