using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton<T> : MonoBehaviour where T: MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private static T _instance;
    public static T Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = FindObjectOfType(typeof(T)) as T;
                if (_instance == null)
                {
                    GameObject obj = new GameObject();
                    //obj.hideFlags = HideFlags.DontSave;
                    obj.hideFlags = HideFlags.HideAndDontSave;
                    _instance = (T)obj.AddComponent(typeof(T));
                }
            }
            return _instance;
        }
    }
    public virtual void Awake()//所有继承此类的单例脚本在场景变换后依然存在
    {
        DontDestroyOnLoad(this.gameObject);
        if (_instance == null)
        {
            _instance = this as T;
        }
        else
        {
            Destroy(gameObject);
        }

    }
}
