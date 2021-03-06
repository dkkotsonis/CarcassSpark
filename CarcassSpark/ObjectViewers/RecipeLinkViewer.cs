﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarcassSpark.ObjectTypes;
using CarcassSpark.ObjectViewers;

namespace CarcassSpark.ObjectViewers
{
    public partial class RecipeLinkViewer : Form
    {
        public RecipeLink displayedRecipeLink;
        bool editing;

        public RecipeLinkViewer(RecipeLink recipeLink, bool? editing)
        {
            InitializeComponent();
            displayedRecipeLink = recipeLink;
            fillValues(recipeLink);
            if (editing.HasValue) setEditingMode(editing.Value);
            else setEditingMode(false);
        }

        void fillValues(RecipeLink recipeLink)
        {
            idTextBox.Text = recipeLink.id;
            if (recipeLink.chance.HasValue) chanceNumericUpDown.Value = recipeLink.chance.Value;
            if (recipeLink.additional.HasValue) additionalCheckBox.Checked = recipeLink.additional.Value;
            if (recipeLink.challenges != null)
            {
                foreach (KeyValuePair<string, string> kvp in recipeLink.challenges)
                {
                    challengesDataGridView.Rows.Add(kvp.Key, kvp.Value);
                }
            }
            if (recipeLink.expulsion != null)
            {
                foreach (KeyValuePair<string, int> kvp in recipeLink.expulsion.filter)
                {
                    expulsionDataGridView.Rows.Add(kvp.Key, kvp.Value);
                }
            }
        }
        
        void setEditingMode(bool editing)
        {
            this.editing = editing;
            idTextBox.ReadOnly = !editing;
            chanceNumericUpDown.Enabled = editing;
            additionalCheckBox.Enabled = editing;
            challengesDataGridView.ReadOnly = !editing;
            challengesDataGridView.AllowUserToAddRows = editing;
            challengesDataGridView.AllowUserToDeleteRows = editing;
            expulsionDataGridView.ReadOnly = !editing;
            expulsionDataGridView.AllowUserToAddRows = editing;
            expulsionDataGridView.AllowUserToDeleteRows = editing;
            okButton.Visible = editing;
            cancelButton.Text = editing ? "Cancel" : "Close";
        }

        private void openRecipeButton_Click(object sender, EventArgs e)
        {
            RecipeViewer rv = new RecipeViewer(Utilities.getRecipe(idTextBox.Text), null);
            rv.Show();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (challengesDataGridView.RowCount > 1)
            {
                displayedRecipeLink.challenges = new Dictionary<string, string>();
                foreach (DataGridViewRow row in challengesDataGridView.Rows)
                {
                    if (row.Cells[0].Value != null && row.Cells[1].Value != null)
                    {
                        displayedRecipeLink.challenges.Add(row.Cells[0].Value.ToString(), row.Cells[1].Value.ToString());
                    }
                }
            }
            if (expulsionDataGridView.RowCount > 1)
            {
                displayedRecipeLink.expulsion = new Expulsion(Convert.ToInt32(totalExpulsionLimitNumericUpDown.Value) > 0 ? Convert.ToInt32(totalExpulsionLimitNumericUpDown.Value) : 1);
                foreach (DataGridViewRow row in expulsionDataGridView.Rows)
                {
                    if (row.Cells[0].Value != null && row.Cells[1].Value != null)
                    {
                        displayedRecipeLink.expulsion.filter.Add(row.Cells[0].Value.ToString(), Convert.ToInt32(row.Cells[1].Value));
                    }
                }
            }
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void idTextBox_TextChanged(object sender, EventArgs e)
        {
            displayedRecipeLink.id = idTextBox.Text;
            if (displayedRecipeLink.id == "")
            {
                displayedRecipeLink.id = null;
            }
        }

        private void chanceNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            displayedRecipeLink.chance = Convert.ToInt32(chanceNumericUpDown.Value);
            if (displayedRecipeLink.chance == 0)
            {
                displayedRecipeLink.chance = null;
            }
        }

        private void additionalCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            displayedRecipeLink.additional = additionalCheckBox.Checked;
            if (!displayedRecipeLink.additional.Value)
            {
                displayedRecipeLink.additional = null;
            }
        }

        private void challengesDataGridView_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            if (displayedRecipeLink.challenges.ContainsKey(e.Row.Cells[0].Value.ToString())) displayedRecipeLink.challenges.Remove(e.Row.Cells[0].Value.ToString());
            if (displayedRecipeLink.challenges.Count == 0) displayedRecipeLink.challenges = null;
        }

        private void expulsionsDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = expulsionDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            switch (Utilities.getIdType(id))
            {
                case "aspect":
                    AspectViewer av = new AspectViewer(Utilities.getAspect(id), null);
                    av.Show();
                    break;

                case "element":
                    ElementViewer ev = new ElementViewer(Utilities.getElement(id), null);
                    ev.Show();
                    break;
                default:
                    break;
            }
        }

        private void expulsionDataGridView_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            if (displayedRecipeLink.expulsion.filter.ContainsKey(e.Row.Cells[0].Value.ToString())) displayedRecipeLink.expulsion.filter.Remove(e.Row.Cells[0].Value.ToString());
            if (displayedRecipeLink.expulsion.filter.Count == 0) displayedRecipeLink.expulsion = null;
        }
        
        private void challengesDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            AspectViewer av = new AspectViewer(Utilities.getAspect(challengesDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString()), null);
            av.Show();
        }

        private void totalExpulsionLimitNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (displayedRecipeLink.expulsion != null) displayedRecipeLink.expulsion.limit = Convert.ToInt32(totalExpulsionLimitNumericUpDown.Value);
        }
    }
}
