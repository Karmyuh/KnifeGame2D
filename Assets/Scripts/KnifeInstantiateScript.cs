using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnifeInstantiateScript : MonoBehaviour
{
    [SerializeField] Transform _knifeSpawner;
    [SerializeField] GameObject _knife;

    public void KnifeLeftInstantiate() 
    {
        Instantiate(_knife, _knifeSpawner, _knifeSpawner);
    }
    public void KnifeRightInstantiate() 
    {
        
    }
}
