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
using System.Drawing;
using System.Windows.Forms;
using NUnit.Framework;
using NUnit.Framework.SyntaxHelpers;

namespace ScoreKeeper {
  [TestFixture]
  public class SelectionControlTest : SelectionControl {
    [TestFixtureSetUp]
    public void FixtureSetUp() {
      Change += new EventHandler(TestChange);
    }
    
    [SetUp]
    public void SetUp() {
      changed_ = false;
      Labels = new String[0];
    }
    
    [Test]
    public void TestLabels() {
      Assert.AreEqual(new string[0] {}, Labels);
      Assert.IsFalse(YesNoMode);
      Assert.AreEqual(0, Controls.Count);
      
      YesNoMode = true;
      Assert.AreEqual(new string[2] { "Yes", "No" }, Labels);
      Assert.IsTrue(YesNoMode);
      Assert.AreEqual(2, Controls.Count);
      
      string[] three = new string[3] { "1", "2", "3" };
      Labels = three;
      Assert.AreEqual(three, Labels);
      Assert.IsFalse(YesNoMode);
      Assert.AreEqual(3, Controls.Count);
    }
    
    [Test]
    public void TestSize() {
      Size orig_size = Size;
      Size = new Size(orig_size.Width + 100, orig_size.Height + 100);
      Assert.AreEqual(orig_size.Width, Width);
      Assert.AreEqual(orig_size.Height, Height);
    }
    
    [Test]
    public void TestValueGet() {
      Assert.AreEqual(null, Value);
      
      YesNoMode = true;
      Assert.IsFalse(changed_);
      Assert.AreEqual(null, Value);

      ControlHelper.FireEvent(Controls[0], "Click");
      Assert.IsTrue(changed_);
      Assert.AreEqual("Yes", Value);
      changed_ = false;
      
      ControlHelper.FireEvent(Controls[1], "Click");
      Assert.IsTrue(changed_);
      Assert.AreEqual("No", Value);
      changed_ = false;
      
      ControlHelper.FireEvent(Controls[1], "Click");
      Assert.IsFalse(changed_);
      Assert.AreEqual("No", Value);
    }
    
    [Test]
    public void TestValueSet() {
      Assert.AreEqual(Value, null);
      
      YesNoMode = true;
      Assert.IsFalse(changed_);
      Assert.AreEqual(null, Value);

      Value = "Yes";
      Assert.IsTrue(changed_);
      Assert.AreEqual("Yes", Value);
      changed_ = false;
      
      Value = "No";
      Assert.IsTrue(changed_);
      Assert.AreEqual("No", Value);
      changed_ = false;
      
      Value = "No";
      Assert.IsFalse(changed_);
      Assert.AreEqual("No", Value);
      
      Value = null;
      Assert.IsTrue(changed_);
      Assert.AreEqual(null, Value);
    }
    
    [Test]
    [ExpectedException(typeof(ArgumentException))]
    public void TestValueSetInvalid() {
      Value = "foo";
    }
    
    [Test]
    public void TestValueIntGet() {
      Labels = new string[] { "2", "0", "1" };
      
      Assert.IsFalse(changed_);
      Assert.AreEqual(-1, ValueInt);

      ControlHelper.FireEvent(Controls[0], "Click");
      Assert.IsTrue(changed_);
      Assert.AreEqual(2, ValueInt);
      changed_ = false;

      ControlHelper.FireEvent(Controls[1], "Click");
      Assert.IsTrue(changed_);
      Assert.AreEqual(0, ValueInt);
      changed_ = false;
      
      ControlHelper.FireEvent(Controls[2], "Click");
      Assert.IsTrue(changed_);
      Assert.AreEqual(1, ValueInt);
      changed_ = false;
    }
    
    [Test]
    public void TestValueIntSet() {
      Labels = new string[] { "2", "0", "1" };
      
      Assert.IsFalse(changed_);
      Assert.AreEqual(-1, ValueInt);
      
      ValueInt = 2;
      Assert.IsTrue(changed_);
      Assert.AreEqual(2, ValueInt);
      changed_ = false;
      
      ValueInt = 0;
      Assert.IsTrue(changed_);
      Assert.AreEqual(0, ValueInt);
      changed_ = false;
      
      ValueInt = 1;
      Assert.IsTrue(changed_);
      Assert.AreEqual(1, ValueInt);
      
      ValueInt = -1;
      Assert.IsTrue(changed_);
      Assert.AreEqual(-1, ValueInt);
      changed_ = false;
    }
    
    [Test]
    public void TestValueYesNoGet() {
      YesNoMode = true;
      
      Assert.IsFalse(changed_);
      Assert.AreEqual(YesNo.Unknown, ValueYesNo);
      
      ControlHelper.FireEvent(Controls[0], "Click");
      Assert.IsTrue(changed_);
      Assert.AreEqual(YesNo.Yes, ValueYesNo);
      changed_ = false;
      
      ControlHelper.FireEvent(Controls[1], "Click");
      Assert.IsTrue(changed_);
      Assert.AreEqual(YesNo.No, ValueYesNo);
      changed_ = false;
    }
    
    [Test]
    public void TestValueYesNoSet() {
      YesNoMode = true;
      
      Assert.IsFalse(changed_);
      Assert.AreEqual(YesNo.Unknown, ValueYesNo);
      
      ValueYesNo = YesNo.Yes;
      Assert.IsTrue(changed_);
      Assert.AreEqual(YesNo.Yes, ValueYesNo);
      changed_ = false;
      
      ValueYesNo = YesNo.No;
      Assert.IsTrue(changed_);
      Assert.AreEqual(YesNo.No, ValueYesNo);
      changed_ = false;
      
      ValueYesNo = YesNo.Unknown;
      Assert.IsTrue(changed_);
      Assert.AreEqual(YesNo.Unknown, ValueYesNo);
      changed_ = false;
    }
    
    [Test]
    [ExpectedException(typeof(ArgumentException))]
    public void TestValueYesNoException() {
      YesNo val = ValueYesNo;
    }
    
    private void TestChange(object sender, EventArgs e) {
      changed_ = true;
    }
    
    private bool changed_ = false;
  }
}
