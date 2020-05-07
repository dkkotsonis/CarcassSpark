﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cultist_Simulator_Modding_Toolkit
{
    public partial class VerbViewer : Form
    {
        Verb displayedVerb;

        Dictionary<string, Slot> slots = new Dictionary<string, Slot>();

        public VerbViewer(Verb verb, bool? editing)
        {
            InitializeComponent();
            displayedVerb = verb;
            idTextBox.Text = verb.id;
            labelTextBox.Text = verb.label;
            atStartCheckBox.Checked = verb.atStart;
            descriptionTextBox.Text = verb.description;
            if (verb.slots != null)
            {
                foreach (Slot slot in verb.slots)
                {
                    slotsListBox.Items.Add(slot.id);
                    slots.Add(slot.id, slot);
                }
            }
            if (editing.HasValue) setEditingMode(editing.Value);
            else setEditingMode(false);
        }

        void setEditingMode(bool editing)
        {
            idTextBox.Enabled = editing;
            labelTextBox.Enabled = editing;
            atStartCheckBox.Enabled = editing;
            descriptionTextBox.Enabled = editing;
        }

        private void slotsListBox_DoubleClick(object sender, EventArgs e)
        {
            if (slotsListBox.SelectedItem == null) return;
            SlotViewer sv = new SlotViewer(slots[slotsListBox.SelectedItem.ToString()], false);
            sv.ShowDialog();
        }
    }
}