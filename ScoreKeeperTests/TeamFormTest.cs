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

namespace ScoreKeeper {
  [TestFixture]
  public class TeamFormTest : TeamForm {
    public TeamFormTest() : base(new Team[0]) {
    }
    
    [Test]
    public void TestConstructorNoTeams() {
      Init(new Team[0]);
      Assert.AreEqual(0, teams_.Items.Count);
      
      Assert.IsFalse(remove_.Enabled);
      Assert.IsFalse(input_panel_.Enabled);
      Assert.AreEqual(string.Empty, number_.Text);
      Assert.AreEqual(string.Empty, name_.Text);
    }
    
    [Test]
    public void TestConstructorWithTeams() {
      Team team1 = new Team("foo", "bar");
      Team team2 = new Team(string.Empty, "baz");
      Init(new Team[] { team1, team2 });
      Assert.AreEqual(2, teams_.Items.Count);
      Assert.AreEqual(team1, teams_.Items[0]);
      Assert.AreEqual(team2, teams_.Items[1]);
      
      Assert.IsTrue(remove_.Enabled);
      Assert.IsTrue(input_panel_.Enabled);
      Assert.AreEqual("foo", number_.Text);
      Assert.AreEqual("bar", name_.Text);
    }

    [Test]
    public void TestAddRemove() {
      Init(new Team[0]);
      Assert.AreEqual(0, teams_.Items.Count);

      Assert.AreEqual(-1, teams_.SelectedIndex);
      Assert.IsFalse(remove_.Enabled);
      Assert.IsFalse(input_panel_.Enabled);
      
      ControlHelper.FireEvent(add_, "Click");
      Assert.AreEqual(1, teams_.Items.Count);

      Assert.AreEqual(0, teams_.SelectedIndex);
      Assert.IsTrue(remove_.Enabled);
      Assert.IsTrue(input_panel_.Enabled);
      
      ControlHelper.FireEvent(remove_, "Click");
      Assert.AreEqual(0, teams_.Items.Count);

      Assert.AreEqual(-1, teams_.SelectedIndex);
      Assert.IsFalse(remove_.Enabled);
      Assert.IsFalse(input_panel_.Enabled);
    }
    
    [Test]
    public void TestRemove() {
      Init(new Team[] { new Team(), new Team(), new Team() });
      teams_.SelectedIndex = 1;
      
      ControlHelper.FireEvent(remove_, "Click");
      Assert.AreEqual(1, teams_.SelectedIndex);
      
      ControlHelper.FireEvent(remove_, "Click");
      Assert.AreEqual(0, teams_.SelectedIndex);
      
      ControlHelper.FireEvent(remove_, "Click");
      Assert.AreEqual(-1, teams_.SelectedIndex);
    }

    [Test]
    public void TestChangeTeam() {
      Team team = new Team("foo", "bar");
      Init(new Team[] { team });
      number_.Text = "7";
      name_.Text = "hoopla";
      
      Assert.AreEqual(0, teams_.SelectedIndex);
      Assert.AreEqual("7", team.Number);
      Assert.AreEqual("hoopla", team.Name);
    }
    
    [Test]
    public void TestCancel() {
      DialogResult = DialogResult.None;
      ControlHelper.FireEvent(cancel_, "Click");
      Assert.AreEqual(DialogResult.Cancel, DialogResult);
    }
    
    [Test]
    public void TestOk0() {
      DialogResult = DialogResult.None;
      Init(new Team[0]);
      ControlHelper.FireEvent(ok_, "Click");
      Assert.AreEqual(DialogResult.OK, DialogResult);
      Assert.AreEqual(0, Teams.Length);
    }
    
    [Test]
    public void TestOk3() {
      DialogResult = DialogResult.None;
      Init(new Team[0]);
      ControlHelper.FireEvent(add_, "Click");
      name_.Text = "foo";
      
      ControlHelper.FireEvent(add_, "Click");
      
      ControlHelper.FireEvent(add_, "Click");
      name_.Text = "bar";
      
      Assert.AreEqual(2, teams_.SelectedIndex);
      ControlHelper.FireEvent(ok_, "Click");
      Assert.AreEqual(DialogResult.None, DialogResult);
      Assert.AreEqual(1, teams_.SelectedIndex);
      
      name_.Text = "baz";
      ControlHelper.FireEvent(ok_, "Click");
      Assert.AreEqual(DialogResult.OK, DialogResult);
      
      Assert.AreEqual(3, Teams.Length);
      Assert.AreEqual("bar", Teams[0].Name);
      Assert.AreEqual("baz", Teams[1].Name);
      Assert.AreEqual("foo", Teams[2].Name);
    }
    
    protected override void ShowMessage(string message, string caption) {
      // Prevent the message box from popping up.
    }
  }
}
