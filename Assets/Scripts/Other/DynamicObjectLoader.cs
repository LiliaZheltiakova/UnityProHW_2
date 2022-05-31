using GameElements;
using UnityEngine;

namespace Other
{
    public class DynamicObjectLoader : MonoBehaviour,
        IGameReferenceElement
    {
        public IGameSystem GameSystem { private get; set; }
        [SerializeField] private DynamicObject dynamicObjectPrefab;

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.L))
            {
                LoadObject();
            }
        }
        
        private void LoadObject()
        {
            var dynamicObject = Instantiate(this.dynamicObjectPrefab);
            GameSystem.AddElement(dynamicObject);
        }
    }
}