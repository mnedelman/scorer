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
using System.Collections;
using System.Drawing;
using System.Windows.Forms;

namespace ScoreKeeper {
  public partial class TeamForm : Form {
    public TeamForm(Team[] teams) {
      // The InitializeComponent() call is required for Windows Forms designer support.
      InitializeComponent();
      Init(teams);
    }
    
    protected void Init(Team[] teams) {
      teams_.Items.Clear();
      if (teams.Length > 0) {
        foreach (Team team in teams)
          teams_.Items.Add(team);
        teams_.SelectedIndex = 0;
      } else {
        UpdateControls();
      }
    }
    
    protected virtual void ShowMessage(string message, string caption) {
      MessageBox.Show(this, message, caption, MessageBoxButtons.OK);
    }
    
    private void OnAdd(object sender, EventArgs e) {
      teams_.Items.Add(new Team());
      teams_.SelectedIndex = teams_.Items.Count - 1;
    }
    
    private void OnRemove(object sender, EventArgs e) {
      int sel = teams_.SelectedIndex;
      teams_.Items.RemoveAt(sel);
      if (sel < teams_.Items.Count)
        teams_.SelectedIndex = sel;
      else if (sel > 0)
        teams_.SelectedIndex = sel - 1;
      else
        UpdateControls();
    }
    
    private void OnChangeName(object sender, EventArgs e) {
      if (refreshing_)
        return;
      ((Team)teams_.SelectedItem).Name = name_.Text;
      RefreshSelection();
    }
    
    private void OnChangeNumber(object sender, EventArgs e) {
      if (refreshing_)
        return;
      ((Team)teams_.SelectedItem).Number = number_.Text;
      RefreshSelection();
    }

    private void OnChangeTeam(object sender, EventArgs e) {
      UpdateControls();
    }
    
    private void OnOk(object sender, EventArgs e) {
      foreach (Team team in teams_.Items) {
        if (!team.HasString()) {
          teams_.SelectedItem = team;
          ShowMessage("All teams must have a number of name.",
                      "Missing Team Name");
          return;
        }
      }
      ArrayList sorted_teams = new ArrayList(teams_.Items);
      sorted_teams.Sort(new TeamNameComparer());
      Teams = (Team[])sorted_teams.ToArray(typeof(Team));
    	DialogResult = DialogResult.OK;
    }
    
    private void RefreshSelection() {
      refreshing_ = true;
      teams_.Items[teams_.SelectedIndex] = teams_.SelectedItem;
      refreshing_ = false;
    }
    
    private void UpdateControls() {
      if (refreshing_)
        return;
      Team team = (Team)teams_.SelectedItem;
      bool selected = team != null;
      remove_.Enabled = selected;
      input_panel_.Enabled = selected;
      
      refreshing_ = true;
      name_.Text = selected ? team.Name : "";
      number_.Text = selected ? team.Number : "";
      number_.Focus();
      refreshing_ = false;
    }
    
    public Team[] Teams;
    private bool refreshing_;
  }
}
