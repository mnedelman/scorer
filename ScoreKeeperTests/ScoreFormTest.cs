/* Copyright (c) 2008, Jonathan Perkins
 * All rights reserved.
 *
 * Redistribution and use in source and binary forms, with or without
 * modification, are permitted provided that the following conditions are met:
 *     * Redistributions of source code must retain the above copyright
 *       notice, this list of conditions and the following disclaimer.
 *     * Redistributions in binary form must reproduce the above copyright
 *       notice, this list of conditions and the following disclaimer in the
 *       documentation and/or other materials provided with the distribution.
 *     * Neither the name of the Scorer nor the
 *       names of its contributors may be used to endorse or promote products
 *       derived from this software without specific prior written permission.
 *
 * THIS SOFTWARE IS PROVIDED BY JONATHAN PERKINS ''AS IS'' AND ANY
 * EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED
 * WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE
 * DISCLAIMED. IN NO EVENT SHALL JONATHAN PERKINS BE LIABLE FOR ANY
 * DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES
 * (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES;
 * LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND
 * ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT
 * (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS
 * SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
 */

using System;
using System.Windows.Forms;
using NUnit.Framework;

namespace ScoreKeeper
{
  [TestFixture]
  public class ScoreFormTest : ScoreForm {
    [Test]
    public void TestFontSize() {
      Assert.AreEqual(20, scoreboard_.FontSize);
      Assert.IsTrue(font20_.Checked);
      Assert.IsFalse(font24_.Checked);
      
      ControlHelper.FireEvent(font24_, "Click");
      Assert.AreEqual(24, scoreboard_.FontSize);
      Assert.IsFalse(font20_.Checked);
      Assert.IsTrue(font24_.Checked);
      
      ControlHelper.FireEvent(font28_, "Click");
      Assert.AreEqual(28, scoreboard_.FontSize);
      Assert.IsTrue(font28_.Checked);
      
      ControlHelper.FireEvent(font32_, "Click");
      Assert.AreEqual(32, scoreboard_.FontSize);
      Assert.IsTrue(font32_.Checked);
      
      ControlHelper.FireEvent(font36_, "Click");
      Assert.AreEqual(36, scoreboard_.FontSize);
      Assert.IsTrue(font36_.Checked);
      
      ControlHelper.FireEvent(font40_, "Click");
      Assert.AreEqual(40, scoreboard_.FontSize);
      Assert.IsTrue(font40_.Checked);
      
      ControlHelper.FireEvent(font48_, "Click");
      Assert.AreEqual(48, scoreboard_.FontSize);
      Assert.IsTrue(font48_.Checked);
      
      ControlHelper.FireEvent(font56_, "Click");
      Assert.AreEqual(56, scoreboard_.FontSize);
      Assert.IsTrue(font56_.Checked);
      
      ControlHelper.FireEvent(font64_, "Click");
      Assert.AreEqual(64, scoreboard_.FontSize);
      Assert.IsTrue(font64_.Checked);

      ControlHelper.FireEvent(font20_, "Click");
      Assert.AreEqual(20, scoreboard_.FontSize);
      Assert.IsTrue(font20_.Checked);
      Assert.IsFalse(font24_.Checked);
      Assert.IsFalse(font28_.Checked);
      Assert.IsFalse(font32_.Checked);
      Assert.IsFalse(font36_.Checked);
      Assert.IsFalse(font40_.Checked);
      Assert.IsFalse(font48_.Checked);
      Assert.IsFalse(font56_.Checked);
      Assert.IsFalse(font64_.Checked);
    }
    
    [Test]
    public void TestCycle() {
      Assert.IsTrue(cycle_slow_.Checked);
      
      ControlHelper.FireEvent(cycle_stop_, "Click");
      Assert.IsTrue(cycle_stop_.Checked);
      
      ControlHelper.FireEvent(cycle_medium_, "Click");
      Assert.IsTrue(cycle_medium_.Checked);
    }
    
    [Test]
    public void TestFullScreen() {
      Assert.IsFalse(full_screen_.Checked);
      Assert.AreEqual(FormBorderStyle.Sizable, FormBorderStyle);
      
      ControlHelper.FireEvent(full_screen_, "Click");
      Assert.IsTrue(full_screen_.Checked);
      Assert.AreEqual(FormBorderStyle.None, FormBorderStyle);

      ControlHelper.FireEvent(full_screen_, "Click");
      Assert.IsFalse(full_screen_.Checked);
      Assert.AreEqual(FormBorderStyle.Sizable, FormBorderStyle);
    }
    
    [Test]
    public void TestLogo() {
      Assert.AreNotEqual(null, fll_logo1_.Image);
      Assert.IsTrue(toggle_logo_.Checked);
      
      ControlHelper.FireEvent(toggle_logo_, "Click");
      Assert.AreEqual(null, fll_logo1_.Image);
      Assert.IsFalse(toggle_logo_.Checked);
      
      ControlHelper.FireEvent(toggle_logo_, "Click");
      Assert.AreNotEqual(null, fll_logo1_.Image);
      Assert.IsTrue(toggle_logo_.Checked);
    }
    
    [Test]
    public void TestLogoSize() {
      Assert.AreEqual(150, fll_logo1_.Size.Width);
      Assert.AreEqual(150, fll_logo1_.Size.Height);
      Assert.IsTrue(logo150_.Checked);
      Assert.IsFalse(logo200_.Checked);
      Assert.IsFalse(logo250_.Checked);
      Assert.IsFalse(logo300_.Checked);
      
      ControlHelper.FireEvent(logo200_, "Click");
      Assert.AreEqual(200, fll_logo1_.Size.Width);
      Assert.AreEqual(200, fll_logo1_.Size.Height);
      Assert.IsFalse(logo150_.Checked);
      Assert.IsTrue(logo200_.Checked);
      Assert.IsFalse(logo250_.Checked);
      Assert.IsFalse(logo300_.Checked);
      
      ControlHelper.FireEvent(logo250_, "Click");
      Assert.AreEqual(250, fll_logo1_.Size.Width);
      Assert.AreEqual(250, fll_logo1_.Size.Height);
      Assert.IsTrue(logo250_.Checked);
      
      ControlHelper.FireEvent(logo300_, "Click");
      Assert.AreEqual(300, fll_logo1_.Size.Width);
      Assert.AreEqual(300, fll_logo1_.Size.Height);
      Assert.IsFalse(logo250_.Checked);
      
      ControlHelper.FireEvent(logo150_, "Click");
      Assert.AreEqual(150, fll_logo1_.Size.Width);
      Assert.AreEqual(150, fll_logo1_.Size.Height);
      Assert.IsTrue(logo150_.Checked);
      Assert.IsFalse(logo200_.Checked);
      Assert.IsFalse(logo250_.Checked);
      Assert.IsFalse(logo300_.Checked);
    }
    
    [Test]
    public void TestShowStatus() {
      // Because the form's not visible, ShowStatus can't be checked.
      Assert.IsFalse(show_status_.Checked);
      
      ControlHelper.FireEvent(show_status_, "Click");
      Assert.IsTrue(show_status_.Checked);
      
      ControlHelper.FireEvent(show_status_, "Click");
      Assert.IsFalse(show_status_.Checked);
    }
  }
}
