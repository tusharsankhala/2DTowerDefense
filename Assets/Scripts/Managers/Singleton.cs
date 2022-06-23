using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SubsystemsImplementation;

namespace TowerDefense.Singleton
{
    public class Singleton<T> : MonoBehaviour 
    where T : Component
    {
        private static T _mInstance;

        public static T instance
        {
            get
            {
                if (ReferenceEquals(_mInstance, null))
                {
                    _mInstance = FindObjectOfType<T>();
                }

                if (ReferenceEquals(_mInstance, null))
                {
                    GameObject obj = new GameObject();
                    obj.name = typeof(T).Name;
                    _mInstance = obj.GetComponent<T>();
                }
                
                return _mInstance;
            }
        }
        
        public virtual void Awake()
        {
            if(ReferenceEquals(_mInstance, null))
            {
                _mInstance = this as T;
                DontDestroyOnLoad(gameObject);
            }
            else
            {
                Destroy(gameObject);
            }
        }
    }
}