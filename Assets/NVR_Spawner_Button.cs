using UnityEngine;
using System.Collections;
using NewtonVR;

namespace NewtonVR.Example
{
    public class NVR_Spawner_Button : MonoBehaviour
    {
        public NVRButton Button;

        public GameObject ToCopy;

        public Transform SpawnLocation;

        private void Update()
        {
            if (Button.ButtonDown)
            {
                GameObject newGo = GameObject.Instantiate(ToCopy);
                newGo.transform.position = SpawnLocation.position;
                newGo.transform.rotation = SpawnLocation.rotation;
                newGo.transform.localScale = ToCopy.transform.lossyScale;
            }
        }
    }
}