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
using NUnit.Framework;

namespace ScoreKeeper {
  [TestFixture]
  public class Score2011Test {
    [Test]
    public void TestClone() {
      Score2011 score = new Score2011();
      
      score.BallsTouchingMat = 1;                        //  4
      score.AnyCornInBase = YesNo.Yes;                   //  9
      score.AnyCornTouchingMat = YesNo.No;               //  0
      score.BabyFishTouchingMark = YesNo.Yes;            // N/A
      score.BigFishInBase = 1;                           //  3
      score.TrailerLocation = TrailerLocationEnum.Dock;  // 20
      score.TrailerGermFree = YesNo.Yes;                 // N/A
      score.TrailerFish = 1;                             //  6
      score.PizzaInBase = YesNo.Yes;                     //  7
      score.IceCreamInBase = YesNo.No;                   //  0
      score.YellowFarmTruckInBase = YesNo.Yes;           //  9
      score.RobotTouchingEastWall = YesNo.No;            //  0
      score.WhitePointerInRedZone = YesNo.Yes;           // 14
      score.ThermometerSpindleFullyDropped = YesNo.No;   //  0
      score.RatsInBase = 1;                              // 15
      score.TableOnlySupportingGroceries = YesNo.Yes;    // N/A
      score.GroceriesOnTable = 4;                        //  8
      score.EmptyDispensers = 2;                         // 48
      score.BacteriaTouchingMat = YesNo.No;              // N/A
      score.BacteriaInSink = 14;                         // 42
      score.GermsInSink = GermsInSinkEnum.NinePlus;      // 13
      score.YellowBacteriaInBase = 5;                    // 30
      
      Score2011 clone = score.Clone();
      Assert.AreEqual(score.BallsTouchingMat, clone.BallsTouchingMat);
      Assert.AreEqual(score.AnyCornInBase, clone.AnyCornInBase);
      Assert.AreEqual(score.AnyCornTouchingMat, clone.AnyCornTouchingMat);
      Assert.AreEqual(score.BabyFishTouchingMark, clone.BabyFishTouchingMark);
      Assert.AreEqual(score.BigFishInBase, clone.BigFishInBase);
      Assert.AreEqual(score.TrailerLocation, clone.TrailerLocation);
      Assert.AreEqual(score.TrailerGermFree, clone.TrailerGermFree);
      Assert.AreEqual(score.TrailerFish, clone.TrailerFish);
      Assert.AreEqual(score.PizzaInBase, clone.PizzaInBase);
      Assert.AreEqual(score.IceCreamInBase, clone.IceCreamInBase);
      Assert.AreEqual(score.YellowFarmTruckInBase, clone.YellowFarmTruckInBase);
      Assert.AreEqual(score.RobotTouchingEastWall, clone.RobotTouchingEastWall);
      Assert.AreEqual(score.WhitePointerInRedZone, clone.WhitePointerInRedZone);
      Assert.AreEqual(score.ThermometerSpindleFullyDropped, clone.ThermometerSpindleFullyDropped);
      Assert.AreEqual(score.RatsInBase, clone.RatsInBase);
      Assert.AreEqual(score.TableOnlySupportingGroceries, clone.TableOnlySupportingGroceries);
      Assert.AreEqual(score.GroceriesOnTable, clone.GroceriesOnTable);
      Assert.AreEqual(score.EmptyDispensers, clone.EmptyDispensers);
      Assert.AreEqual(score.BacteriaTouchingMat, clone.BacteriaTouchingMat);
      Assert.AreEqual(score.BacteriaInSink, clone.BacteriaInSink);
      Assert.AreEqual(score.GermsInSink, clone.GermsInSink);
      Assert.AreEqual(score.YellowBacteriaInBase, clone.YellowBacteriaInBase);
    }
    
    [Test]
    public void TestScore() {
      Score2011 score = new Score2011();
      ScoreInfo info;
      
      info = score.Score();
      Assert.False(info.IsValid());

      score.Zero();
      info = score.Score();
      Assert.True(info.IsValid());
      Assert.AreEqual(0, info.Points);

      score.BallsTouchingMat = 2;
      info = score.Score();
      Assert.True(info.IsValid());
      Assert.AreEqual(8, info.Points);

      score.AnyCornTouchingMat = YesNo.Yes;
      info = score.Score();
      Assert.True(info.IsValid());
      Assert.AreEqual(13, info.Points);

      score.AnyCornInBase = YesNo.Yes;
      info = score.Score();
      Assert.True(info.IsValid());
      Assert.AreEqual(17, info.Points);

      score.BabyFishTouchingMark = YesNo.Yes;
      info = score.Score();
      Assert.True(info.IsValid());
      Assert.AreEqual(17, info.Points);

      score.BigFishInBase = 3;
      info = score.Score();
      Assert.True(info.IsValid());
      Assert.AreEqual(26, info.Points);

      score.BigFishInBase = 0;
      score.TrailerLocation = TrailerLocationEnum.Base;
      info = score.Score();
      Assert.True(info.IsValid());
      Assert.AreEqual(29, info.Points);

      score.TrailerLocation = TrailerLocationEnum.Dock;
      info = score.Score();
      Assert.True(info.IsValid());
      Assert.AreEqual(37, info.Points);
      
      score.TrailerFish = 3;
      info = score.Score();
      Assert.True(info.IsValid());
      Assert.AreEqual(37, info.Points);

      score.TrailerGermFree = YesNo.Yes;
      info = score.Score();
      Assert.True(info.IsValid());
      Assert.AreEqual(55, info.Points);

      score.PizzaInBase = YesNo.Yes;
      info = score.Score();
      Assert.True(info.IsValid());
      Assert.AreEqual(62, info.Points);

      score.IceCreamInBase = YesNo.Yes;
      info = score.Score();
      Assert.True(info.IsValid());
      Assert.AreEqual(69, info.Points);

      score.YellowFarmTruckInBase = YesNo.Yes;
      info = score.Score();
      Assert.True(info.IsValid());
      Assert.AreEqual(78, info.Points);

      score.RobotTouchingEastWall = YesNo.Yes;
      info = score.Score();
      Assert.True(info.IsValid());
      Assert.AreEqual(87, info.Points);

      score.WhitePointerInRedZone = YesNo.Yes;
      info = score.Score();
      Assert.True(info.IsValid());
      Assert.AreEqual(101, info.Points);

      score.ThermometerSpindleFullyDropped = YesNo.Yes;
      info = score.Score();
      Assert.True(info.IsValid());
      Assert.AreEqual(121, info.Points);

      score.RatsInBase = 2;
      info = score.Score();
      Assert.True(info.IsValid());
      Assert.AreEqual(151, info.Points);

      score.GroceriesOnTable = 12;
      info = score.Score();
      Assert.True(info.IsValid());
      Assert.AreEqual(151, info.Points);

      score.TableOnlySupportingGroceries = YesNo.Yes;
      info = score.Score();
      Assert.True(info.IsValid());
      Assert.AreEqual(175, info.Points);

      score.EmptyDispensers = 4;
      score.BacteriaTouchingMat = YesNo.Yes;
      info = score.Score();
      Assert.True(info.IsValid());
      Assert.AreEqual(203, info.Points);

      score.BacteriaTouchingMat = YesNo.No;
      info = score.Score();
      Assert.True(info.IsValid());
      Assert.AreEqual(223, info.Points);

      score.BacteriaInSink = 48;
      info = score.Score();
      Assert.True(info.IsValid());
      Assert.AreEqual(367, info.Points);
      
      score.BacteriaInSink = 36;
      info = score.Score();
      Assert.True(info.IsValid());
      Assert.AreEqual(331, info.Points);

      score.GermsInSink = GermsInSinkEnum.OneToEight;
      info = score.Score();
      Assert.True(info.IsValid());
      Assert.AreEqual(337, info.Points);

      score.GermsInSink = GermsInSinkEnum.NinePlus;
      info = score.Score();
      Assert.True(info.IsValid());
      Assert.AreEqual(344, info.Points);

      score.YellowBacteriaInBase = 12;
      info = score.Score();
      Assert.True(info.IsValid());
      Assert.AreEqual(416, info.Points);
      
      score.BallsTouchingMat = 1;                        //  4
      score.AnyCornInBase = YesNo.Yes;                   //  9
      score.AnyCornTouchingMat = YesNo.No;               //  0
      score.BabyFishTouchingMark = YesNo.Yes;            // N/A
      score.BigFishInBase = 1;                           //  3
      score.TrailerLocation = TrailerLocationEnum.Dock;  // 20
      score.TrailerGermFree = YesNo.Yes;                 // N/A
      score.TrailerFish = 1;                             //  6
      score.PizzaInBase = YesNo.Yes;                     //  7
      score.IceCreamInBase = YesNo.No;                   //  0
      score.YellowFarmTruckInBase = YesNo.Yes;           //  9
      score.RobotTouchingEastWall = YesNo.No;            //  0
      score.WhitePointerInRedZone = YesNo.Yes;           // 14
      score.ThermometerSpindleFullyDropped = YesNo.No;   //  0
      score.RatsInBase = 1;                              // 15
      score.TableOnlySupportingGroceries = YesNo.Yes;    // N/A
      score.GroceriesOnTable = 4;                        //  8
      score.EmptyDispensers = 2;                         // 24
      score.BacteriaTouchingMat = YesNo.No;              // N/A
      score.BacteriaInSink = 14;                         // 42
      score.GermsInSink = GermsInSinkEnum.NinePlus;      // 13
      score.YellowBacteriaInBase = 5;                    // 30
      info = score.Score();
      Assert.True(info.IsValid());
      Assert.AreEqual(204, info.Points);
    }
  }
}
