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
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace ScoreKeeper {
  public enum TrailerLocationEnum {
    Base,
    Dock,
    Other,
    Unknown,
  }
  public enum GermsInSinkEnum {
    None,
    OneToEight,
    NinePlus,
    Unknown,
  }
  
  /// <summary>
  /// Scoring setup for the 2008 FLL event.
  /// </summary>
  [Serializable]
  [XmlRoot("Score")]
  public class Score2011 {
    public Score2011() {
    }
    
    public Score2011 Clone() {
      using (MemoryStream stream = new MemoryStream()) {
        BinaryFormatter formatter = new BinaryFormatter();
        formatter.Serialize(stream, this);
        stream.Position = 0;
        Score2011 value = (Score2011)formatter.Deserialize(stream);
        return value;
      }
    }
    
    /// <summary>
    /// Zeroes out the current score.
    /// </summary>
    public void Zero() {
      ZeroPollutionReversal();
      ZeroCornHarvest();
      ZeroFishing();
      ZeroPizzaAndIceCream();
      ZeroFarmFreshProduce();
      ZeroDistantTravel();
      ZeroCookingTime();
      ZeroStorageTemperature();
      ZeroPestRemoval();
      ZeroGroceries();
      ZeroDisinfect();
      ZeroHandWashBacterial();
      ZeroHandWashViral();
      ZeroGoodBacteria();
    }
    
    /// <summary>
    /// Scores all missions.
    /// </summary>
    /// <description>
    /// If multiple errors occur, returns the first error.
    /// </description>
    /// <returns>The aggregate score.</returns>
    public ScoreInfo Score() {
      ScoreDelegate[] calls = {ScorePollutionReversal,
                               ScoreCornHarvest,
                               ScoreFishing,
                               ScorePizzaAndIceCream,
                               ScoreFarmFreshProduce,
                               ScoreDistantTravel,
                               ScoreCookingTime,
                               ScoreStorageTemperature,
                               ScorePestRemoval,
                               ScoreGroceries,
                               ScoreDisinfect,
                               ScoreHandWashBacterial,
                               ScoreHandWashViral,
                               ScoreGoodBacteria,
                              };
      ScoreInfo score = new ScoreInfo();
      foreach (ScoreDelegate call in calls)
        score.Add(call());
      return score;
    }

    /// <summary>
    /// MISSION: POLLUTION REVERSAL — No matter where pollution originates, it
    /// usually finds its way into water. And of course, all plants and animals
    /// take in water. Since we depend on plants and animals for our food,
    /// pollution is a source of contamination, not just in what we breathe and
    /// drink – but also in what we eat. The yellow and blue balls represent
    /// pesticides on the farm and heavy metals in the water. While on their
    /// rings, they're off the mat.
    /// SCORING CONDITION(S):  balls touching the mat are worth 4 POINTS EACH.
    /// </summary>
    public ScoreInfo ScorePollutionReversal() {
      if (BallsTouchingMat == -1)
        return new ScoreInfo("Needs answer: # blue/yellow balls touching mat?");
      return new ScoreInfo(4 * BallsTouchingMat);
    }
    private void ZeroPollutionReversal() {
      BallsTouchingMat = 0;
    }
    public int BallsTouchingMat = -1;

    /// <summary>
    /// MISSION: CORN HARVEST — A harvester (combine) is just one of the many
    /// huge pieces of machinery that handle massive amounts of food at once.
    /// Equipment like this runs on gasoline, and has oil. You can also find
    /// hydraulic fluid, nuts & bolts, screens, gaskets, set screws, bearings,
    /// sealant, paint chips, and bugs on it – any of these materials and
    /// substances could find their way into the food.
    /// SCORING CONDITION(S): Get points for one of these only:
    /// ---ANY piece of corn touching the mat is worth 5 POINTS (additional
    /// pieces do not add to your score).
    /// -----------oR----------- 
    /// ---ANY piece of corn in base is worth 9 POINTS (additional pieces do not
    /// add to your score).
    /// </summary>
    public ScoreInfo ScoreCornHarvest() {
      if (AnyCornInBase == YesNo.Unknown)
        return new ScoreInfo("Needs answer: Any corn in base?");
      if (AnyCornTouchingMat == YesNo.Unknown)
        return new ScoreInfo("Needs answer: Any corn touching mat?");
      if (AnyCornInBase == YesNo.Yes) return new ScoreInfo(9);
      if (AnyCornTouchingMat == YesNo.Yes) return new ScoreInfo(5);
      return new ScoreInfo(0);
    }
    private void ZeroCornHarvest() {
      AnyCornInBase = YesNo.No;
      AnyCornTouchingMat = YesNo.No;
    }
    public YesNo AnyCornInBase = YesNo.Unknown;
    public YesNo AnyCornTouchingMat = YesNo.Unknown;
    
    /// <summary>
    /// MISSION: FISHING – Fish must be eaten or frozen immediately after being
    /// caught. The number of germs that depend on fish is much, much higher
    /// than the number of people who do!
    /// SCORING CONDITION(S):  big fish in base are worth 3 POINTS EACH, if the
    /// baby fish is still touching its mark.
    ///
    /// MISSION: REFRIGERATED GROUND TRANSPORT – In shipping, cases of frozen
    /// and refrigerated foods are often thrown onto pallets, spilled, torn, and
    /// crushed by forklifts, and each other, as they are warehoused and loaded
    /// onto trucks bound for the marketplace. Then the cases go on bumpy rides
    /// for hours in the sun. Amazingly, only a tiny percentage of the food gets
    /// contaminated during all this. The problem is, this tiny percentage
    /// totals tens of thousands of tons a year! And while most of that is
    /// discovered and thrown away, "some" is not.
    /// SCORING CONDITION(S): Get points for one of these only...
    /// ---The trailer in base is worth 12 POINTS.
    /// -----------oR-----------
    /// ---The trailer with meat inside, and no germs inside, with any of its
    /// wheels touching the port dock north of the white line is worth 20
    /// POINTS, and 6 ADDITIONAL POINTS for each big fish inside. For fish
    /// points, the baby fish must still be touching its mark.
    /// </summary>
    public ScoreInfo ScoreFishing() {
      if (BabyFishTouchingMark == YesNo.Unknown)
        return new ScoreInfo("Needs answer: Baby fish touching mark?");
      if (BigFishInBase == -1)
        return new ScoreInfo("Needs answer: How many big fish are in base?");
      if (TrailerLocation == TrailerLocationEnum.Unknown)
        return new ScoreInfo("Needs answer: Where is the trailer?");
      if (TrailerGermFree == YesNo.Unknown)
        return new ScoreInfo("Needs answer: Is the trailer germ-free?");
      if (TrailerFish == -1)
        return new ScoreInfo(
            "Needs answer: How many big fish are in the trailer?");
      if (BigFishInBase + TrailerFish > 3)
        return new ScoreInfo("Over 3 fish are in base or the trailer.");

      int score = 0;
      if (BabyFishTouchingMark == YesNo.Yes) {
        score += 3 * BigFishInBase;
        if (TrailerGermFree == YesNo.Yes &&
            TrailerLocation == TrailerLocationEnum.Dock)
          score += 6 * TrailerFish;

      }
      if (TrailerLocation == TrailerLocationEnum.Base) score += 12;
      if (TrailerLocation == TrailerLocationEnum.Dock) score += 20;
      return new ScoreInfo(score);
    }
    private void ZeroFishing() {
      BabyFishTouchingMark = YesNo.No;
      BigFishInBase = 0;
      TrailerLocation = TrailerLocationEnum.Other;
      TrailerGermFree = YesNo.No;
      TrailerFish = 0;
    }
    public YesNo BabyFishTouchingMark = YesNo.Unknown;
    public int BigFishInBase = -1;  // 3
    public TrailerLocationEnum TrailerLocation = TrailerLocationEnum.Unknown; 
    public YesNo TrailerGermFree = YesNo.Unknown;
    public int TrailerFish = -1;  // 3
    
    /// <summary>
    /// MISSION: PIZZA AND ICE CREAM – When you go out in public to eat, you
    /// place a lot of trust in the people preparing your food. Do they wash
    /// their hands or wear fresh gloves? In what direction do they sneeze? How
    /// clean are their storage and preparation areas? At what temperatures are
    /// the foods stored and cooked? How old are the ingredients? How are pests
    /// controlled?
    /// SCORING CONDITION(S):  Pizza and ice cream in base are worth 7 POINTS
    /// EACH.
    /// </summary>
    public ScoreInfo ScorePizzaAndIceCream() {
      if (PizzaInBase == YesNo.Unknown)
        return new ScoreInfo("Needs answer: Pizza in base?");
      if (IceCreamInBase == YesNo.Unknown)
        return new ScoreInfo("Needs answer: Ice cream in base?");
      int score = 0;
      if (PizzaInBase == YesNo.Yes) score += 7;
      if (IceCreamInBase == YesNo.Yes) score += 7;
      return new ScoreInfo(score);
    }
    private void ZeroPizzaAndIceCream() {
      PizzaInBase = YesNo.No;
      IceCreamInBase = YesNo.No;
    }
    public YesNo PizzaInBase = YesNo.Unknown;
    public YesNo IceCreamInBase = YesNo.Unknown;
    
    /// <summary>
    /// MISSION: FARM FRESH PRODUCE – In general, the fresher your food is and
    /// the fewer ingredients there are in it, the less chance it has had to
    /// become contaminated. Small farms and fisheries close to where you live
    /// are a good source of fresh food, but many small farms don't get the same
    /// level of inspection as large ones do.
    /// SCORING CONDITION(S):  The yellow farm truck in base is worth 9 POINTS.
    /// </summary>
    public ScoreInfo ScoreFarmFreshProduce() {
      if (YellowFarmTruckInBase == YesNo.Unknown)
        return new ScoreInfo("Needs answer: Yellow farm truck in base?");
      if (YellowFarmTruckInBase == YesNo.Yes) return new ScoreInfo(9);
      return new ScoreInfo(0);
    }
    private void ZeroFarmFreshProduce() {
      YellowFarmTruckInBase = YesNo.No;
    }
    public YesNo YellowFarmTruckInBase = YesNo.Unknown;

    /// <summary>
    /// MISSION: DISTANT TRAVEL – Your body suppresses and eliminates the vast
    /// majority of chemicals and germs you eat, and it's especially good at
    /// getting rid of stuff it's been exposed to before – stuff it's used to.
    /// But when you eat in a city or country that's very far from home, your
    /// body's defenses can be caught off guard by contaminants it's never
    /// processed before. It's common for travellers to get quite sick after
    /// eating certain foods, while other people who ate the same foods right
    /// next to them have no problems.
    /// SCORING CONDITION(S):  The robot touching the east wall is worth 9
    /// POINTS. Remember Rule 23.
    /// </summary>
    public ScoreInfo ScoreDistantTravel() {
      if (RobotTouchingEastWall == YesNo.Unknown)
        return new ScoreInfo("Needs answer: Robot touching east wall?");
      if (RobotTouchingEastWall == YesNo.Yes) return new ScoreInfo(9);
      return new ScoreInfo(0);
    }
    private void ZeroDistantTravel() {
      RobotTouchingEastWall = YesNo.No;
    }
    public YesNo RobotTouchingEastWall = YesNo.Unknown;

    /// <summary>
    /// MISSION: COOKING TIME – Before cooking, some foods have more germs, or
    /// tougher germs than others. If you're supposed to cook a food for 40
    /// minutes, but you think "it should be okay" after 35 – think again!
    /// SCORING CONDITION(S):  The white pointer in the red zone is worth 14
    /// POINTS.
    /// </summary>
    public ScoreInfo ScoreCookingTime() {
      if (WhitePointerInRedZone == YesNo.Unknown)
        return new ScoreInfo("Needs answer: White pointer in red zone?");
      if (WhitePointerInRedZone == YesNo.Yes) return new ScoreInfo(14);
      return new ScoreInfo(0);
    }
    private void ZeroCookingTime() {
      WhitePointerInRedZone = YesNo.No;
    }
    public YesNo WhitePointerInRedZone = YesNo.Unknown;

    /// <summary>
    /// MISSION: STORAGE TEMPERATURE – Germs grow fast. If your refrigerator is
    /// set even a few degrees higher than it's supposed to be, the "shelf life"
    /// of many of the foods is cut in half, or even further. If you go to play
    /// ball instead of helping to put the picnic food back in the cooler –
    /// that's bad! If you ever hear the phrase "it's only been out for a few
    /// hours" –make some noise!
    /// SCORING CONDITION(S):  The thermometer spindle clicked/dropped fully
    /// showing the low red temperature is worth 20 POINTS (the spindle needs to
    /// drop all the way).
    /// </summary>
    public ScoreInfo ScoreStorageTemperature() {
      if (ThermometerSpindleFullyDropped == YesNo.Unknown)
        return new ScoreInfo(
            "Needs answer: Thermometer spindle clicked/fully dropped?");
      if (ThermometerSpindleFullyDropped == YesNo.Yes) return new ScoreInfo(20);
      return new ScoreInfo(0);
    }
    private void ZeroStorageTemperature() {
      ThermometerSpindleFullyDropped = YesNo.No;
    }
    public YesNo ThermometerSpindleFullyDropped = YesNo.Unknown;

    /// <summary>
    /// MISSION: PEST REMOVAL – Some animals carry many, many germs that don't
    /// bother them, but which are really bad for us. And some animals have
    /// extremely unclean habits (enough said about that!). These animals have
    /// become very good at infesting population centers and especially food
    /// storage, shipping, and preparation areas, living in the shadows,
    /// climbing and nesting in the tiniest unseen places. Convince them to live
    /// somewhere else! Keep all food well-sealed, and all food areas clean.  At
    /// the first sign of these pests, it's usually too late!
    /// SCORING CONDITION(S):  Rats in your base are worth 15 POINTS EACH (to
    /// you only).
    /// </summary>
    public ScoreInfo ScorePestRemoval() {
      if (RatsInBase == -1)
        return new ScoreInfo("Needs answer: # rats in base?");
      return new ScoreInfo(15 * RatsInBase);
    }
    private void ZeroPestRemoval() {
      RatsInBase = 0;
    }
    public int RatsInBase = -1;

    /// <summary>
    /// MISSION: GROCERIES – Here's your chance to buy undamaged goods, as fresh
    /// as possible, with the fewest ingredients possible, from trustable
    /// places, and get your cold stuff home and put away as soon as possible!
    /// SCORING CONDITION(S):  EACH grocery unit is worth 2 POINTS if the table
    /// is supporting all of its weight, and no weight other than grocery units
    /// (the flower centerpiece can be there too).
    /// </summary>
    public ScoreInfo ScoreGroceries() {
      if (TableOnlySupportingGroceries == YesNo.Unknown)
        return new ScoreInfo(
          "Needs answer: Table only supporting groceries or flowers?");
      if (GroceriesOnTable == -1)
        return new ScoreInfo("Needs answer: # groceries supported by table?");
      if (TableOnlySupportingGroceries == YesNo.No) return new ScoreInfo(0);
      return new ScoreInfo(2 * GroceriesOnTable);
    }
    private void ZeroGroceries() {
      TableOnlySupportingGroceries = YesNo.No;
      GroceriesOnTable = 0;
    }
    public YesNo TableOnlySupportingGroceries = YesNo.Unknown;
    public int GroceriesOnTable = -1;

    /// <summary>
    /// MISSION: DISINFECT – It would be very tough to eliminate food
    /// contamination from all sources, but you can probably do more than you
    /// think, and if you can at least avoid making it worse, that would be a
    /// great start.
    /// SCORING CONDITION(S): Empty dispensers are worth
    /// ---12 POINTS EACH, if no bacteria is touching the mat outside base.
    /// -----------oR-----------
    /// ---7 POINTS EACH, if ANY bacteria is touching the mat outside base.
    /// </summary>
    public ScoreInfo ScoreDisinfect() {
      if (EmptyDispensers == -1)
        return new ScoreInfo("Needs answer: # empty dispensers?");
      if (BacteriaTouchingMat == YesNo.Unknown)
        return new ScoreInfo("Needs answer: Any bacteria touching mat?");
      int each = (BacteriaTouchingMat == YesNo.Yes) ? 7 : 12;
      return new ScoreInfo(each * EmptyDispensers);
    }
    private void ZeroDisinfect() {
      EmptyDispensers = 0;
      BacteriaTouchingMat = YesNo.No;
    }
    public int EmptyDispensers = -1;
    public YesNo BacteriaTouchingMat = YesNo.Unknown;

    /// <summary>
    /// MISSION: HAND WASH/BACTERIAL – Innovative ideas in the future may help
    /// us reduce germs, chemicals, and particles, in natural, farming,
    /// processing, and public food settings, but studies have shown that one of
    /// the biggest source of contamination to your food is your own hands. So
    /// wash them! Front and back, with soap, in hot water, for three times
    /// longer than you do now! As this mission should show, you can never wash
    /// your hands enough.
    /// SCORING CONDITION(S):  bacteria in or on the sink are worth 3 POINTS,
    /// only if all of these are true:
    /// ---All were in base at some time prior to being in the sink.
    /// ---While between base and the sink, each was the only one in motion.
    /// ---All equipment involved with each bacterium's trip to the sink was
    /// --completely in base at the beginning of the trip.
    /// --completely out of base at the end of the trip.
    /// ---The sink is supporting all the weight of every germ, and not
    /// supporting any weight except germs.
    /// bacteria getting to the sink any other way are given back to the team in
    /// base by the referee (the "ref").
    /// </summary>
    public ScoreInfo ScoreHandWashBacterial() {
      if (BacteriaInSink == -1)
        return new ScoreInfo("Needs answer: # bacteria in or on sink?");
      return new ScoreInfo(3 * BacteriaInSink);
    }
    private void ZeroHandWashBacterial() {
      BacteriaInSink = 0;
    }
    public int BacteriaInSink = -1;  // 48

    /// <summary>
    /// MISSION: HAND WASH/VIRAL – Viruses almost always need a "host" (another
    /// living thing) to live on. They are almost always bad, and they're also
    /// somewhat harder to deal with than bacterial germs. Alcohol sanitizer,
    /// bleach sanitizer, and high heat are the better weapons against viral
    /// germs, but hand washing is also helpful.
    /// SCORING CONDITION(S): Get points for one of these only...
    /// ---one to eight viral germs in the sink are worth exactly 6 POINTS only.
    /// -----------oR-----------
    /// ---nine or more viral germs in the sink are worth exactly 13 POINTS
    /// only.
    /// </summary>
    public ScoreInfo ScoreHandWashViral() {
      if (GermsInSink == GermsInSinkEnum.Unknown)
        return new ScoreInfo("Needs answer: # germs in sink?");
      if (GermsInSink == GermsInSinkEnum.None) return new ScoreInfo(0);
      if (GermsInSink == GermsInSinkEnum.OneToEight) return new ScoreInfo(6);
      return new ScoreInfo(13);
    }
    private void ZeroHandWashViral() {
      GermsInSink = GermsInSinkEnum.None;
    }
    public GermsInSinkEnum GermsInSink = GermsInSinkEnum.Unknown;

    /// <summary>
    /// MISSION: GOOD BACTERIA – Not all bacteria are bad. There are about a
    /// thousand types of good bacteria living on/in your body, which total in
    /// the tens of trillions! Bacteria do all sorts of good work for you, and
    /// help process your food, both before and after you eat it. How do we get
    /// rid of bad bacteria without upsetting the good bacteria? Bacteria are
    /// this year's "touch penalty objects" as described in the Rules. When you
    /// cause a touch penalty, the ref takes one yellow bacterium.
    /// SCORING CONDITION(S): Yellow bacteria are worth 6 POINTS EACH in base
    /// only.
    /// </summary>
    public ScoreInfo ScoreGoodBacteria() {
      if (YellowBacteriaInBase == -1)
        return new ScoreInfo("Needs answer: # yellow bacteria in base?");
      return new ScoreInfo(6 * YellowBacteriaInBase);
    }
    private void ZeroGoodBacteria() {
      YellowBacteriaInBase = 0;
    }
    public int YellowBacteriaInBase = -1;  // 12
  }
}
