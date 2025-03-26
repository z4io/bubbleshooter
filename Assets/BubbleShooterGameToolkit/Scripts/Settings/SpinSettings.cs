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

using System;
using BubbleShooterGameToolkit.Scripts.CommonUI.Reward;
using BubbleShooterGameToolkit.Scripts.Data;

// using BubbleShooterGameToolkit.Scripts.Settings.Editor;

namespace BubbleShooterGameToolkit.Scripts.Settings
{
    // [EditPrefab("Assets/BubbleShooterGameToolkit/Resources/Popups/LuckySpin.prefab")]
    public class SpinSettings: SettingsBase
    {
        public int costToSpin = 10;
        public RewardSettingSpin[] rewards = Array.Empty<RewardSettingSpin>();
    }
    
    [Serializable]
    public class RewardSettingSpin
    {
        public ResourceObject resource;
        public RewardVisual rewardVisualPrefab;
        public int count;
    }
}