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

using BubbleShooterGameToolkit.Scripts.CommonUI;
using UnityEngine;

namespace BubbleShooterGameToolkit.Scripts.Services.GDPR
{
    public class GDPRPopupManager : MonoBehaviour
    {
        private void Awake()
        {
            Invoke(nameof(ShowGDPR), 2);
        }

        private void ShowGDPR()
        {
            if (PlayerPrefs.GetInt("npa", -1) == -1)
            {
                MenuManager.instance.ShowPopup<CommonUI.Popups.GDPR>();
            }
        }
    }
}