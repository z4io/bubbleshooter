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

using BubbleShooterGameToolkit.Scripts.System;
using UnityEngine;
using UnityEngine.Audio;

namespace BubbleShooterGameToolkit.Scripts.Audio
{
    [RequireComponent(typeof(AudioSource))]
    public class MusicBase : SingletonBehaviour<MusicBase>
    {
        [SerializeField]
        private AudioMixer mixer;
        [SerializeField]
        private string musicParameter = "musicVolume";

        private void Start()
        {
            mixer.SetFloat(musicParameter, PlayerPrefs.GetInt("Music", 1) == 0 ? -80 : 0);
        }
    }
}