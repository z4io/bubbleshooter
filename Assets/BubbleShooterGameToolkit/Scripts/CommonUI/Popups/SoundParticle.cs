﻿// // ©2015 - 2024 Candy Smith
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

using BubbleShooterGameToolkit.Scripts.Audio;
using UnityEngine;

namespace BubbleShooterGameToolkit.Scripts.CommonUI.Popups
{
	public class SoundParticle : MonoBehaviour {

		// Use this for initialization
		void Start () {
	
		}
	
		// Update is called once per frame
		public void Stop () {
			SoundBase.instance.GetComponent<AudioSource>().PlayOneShot( SoundBase.instance.swish[0] );
		}
		public void Hit()
		{
			SoundBase.instance.GetComponent<AudioSource>().PlayOneShot( SoundBase.instance.hit );
		}

	}
}
