using UnityEngine;

namespace MonishCreate.AnimationPack
{
    public class GameManager : MonoBehaviour
    {
        private Animator anim;

        private void Awake()
        {
            anim = GetComponent<Animator>();
        }

        public void PlayEnemyAnim()
        {
            anim.SetTrigger("Enemy");
        }
    }
}
