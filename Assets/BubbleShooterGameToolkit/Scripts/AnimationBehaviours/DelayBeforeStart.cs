// // ©2015 - 2024 Candy Smith
// // All rights reserved
// // Redistribution of this software is strictly not allowed.
// // Copy of this software can be obtained from unity asset store only.
// // THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// // IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// // FITNESS FOR A PARTICULAR PURPOSE AND NON-INFRINGEMENT. IN NO EVENT SHALL THE
// // AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// // LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// // OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// // THE SOFTWARE.

using UnityEngine;
using UnityEngine.Serialization;

namespace BubbleShooterGameToolkit.Scripts.AnimationBehaviours
{
    public class DelayBeforeStart : StateMachineBehaviour
    {
        private float delay;
        private bool hasStartedOnce = false;
        [FormerlySerializedAs("randomMax")]
        [SerializeField]
        private float delayMax;

        public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {
            if (!hasStartedOnce)
            {
                delay = delayMax;
                animator.speed = 0;
            }
            else
            {
                animator.speed = 1;
            }
        }

        public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {
            if (!hasStartedOnce)
            {
                delay -= Time.deltaTime;

                if (delay <= 0)
                {
                    animator.speed = 1;
                    hasStartedOnce = true;
                }
            }
        }
    }
}