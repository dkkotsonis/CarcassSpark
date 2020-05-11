﻿namespace Cultist_Simulator_Modding_Toolkit
{
    partial class ModViewer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModViewer));
            this.aspectsListBox = new System.Windows.Forms.ListBox();
            this.aspectsLabel = new System.Windows.Forms.Label();
            this.elementsLabel = new System.Windows.Forms.Label();
            this.elementsListBox = new System.Windows.Forms.ListBox();
            this.recipesLabel = new System.Windows.Forms.Label();
            this.recipesListBox = new System.Windows.Forms.ListBox();
            this.decksLabel = new System.Windows.Forms.Label();
            this.decksListBox = new System.Windows.Forms.ListBox();
            this.legaciesLabel = new System.Windows.Forms.Label();
            this.legaciesListBox = new System.Windows.Forms.ListBox();
            this.endingsListBox = new System.Windows.Forms.ListBox();
            this.endingsLabel = new System.Windows.Forms.Label();
            this.verbsListBox = new System.Windows.Forms.ListBox();
            this.verbsLabel = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.fileToolStripDropDownButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aspectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.elementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recipeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deckToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.legacyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.endingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verbToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editManifestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reloadContentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveModToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.summonGeneratorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editModeCheckBox = new System.Windows.Forms.CheckBox();
            this.aspetsSearchTextBox = new System.Windows.Forms.TextBox();
            this.elementsSearchTextBox = new System.Windows.Forms.TextBox();
            this.recipesSearchTextBox = new System.Windows.Forms.TextBox();
            this.decksSearchTextBox = new System.Windows.Forms.TextBox();
            this.legaciesSearchTextBox = new System.Windows.Forms.TextBox();
            this.endingsSearchTextBox = new System.Windows.Forms.TextBox();
            this.verbsSearchTextBox = new System.Windows.Forms.TextBox();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // aspectsListBox
            // 
            this.aspectsListBox.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.aspectsListBox.Location = new System.Drawing.Point(12, 41);
            this.aspectsListBox.Name = "aspectsListBox";
            this.aspectsListBox.ScrollAlwaysVisible = true;
            this.aspectsListBox.Size = new System.Drawing.Size(125, 290);
            this.aspectsListBox.Sorted = true;
            this.aspectsListBox.TabIndex = 1;
            this.aspectsListBox.DoubleClick += new System.EventHandler(this.aspectListBox_DoubleClick);
            // 
            // aspectsLabel
            // 
            this.aspectsLabel.AutoSize = true;
            this.aspectsLabel.Location = new System.Drawing.Point(42, 25);
            this.aspectsLabel.Name = "aspectsLabel";
            this.aspectsLabel.Size = new System.Drawing.Size(45, 13);
            this.aspectsLabel.TabIndex = 2;
            this.aspectsLabel.Text = "Aspects";
            // 
            // elementsLabel
            // 
            this.elementsLabel.AutoSize = true;
            this.elementsLabel.Location = new System.Drawing.Point(175, 25);
            this.elementsLabel.Name = "elementsLabel";
            this.elementsLabel.Size = new System.Drawing.Size(50, 13);
            this.elementsLabel.TabIndex = 3;
            this.elementsLabel.Text = "Elements";
            // 
            // elementsListBox
            // 
            this.elementsListBox.FormattingEnabled = true;
            this.elementsListBox.Location = new System.Drawing.Point(143, 41);
            this.elementsListBox.Name = "elementsListBox";
            this.elementsListBox.ScrollAlwaysVisible = true;
            this.elementsListBox.Size = new System.Drawing.Size(125, 290);
            this.elementsListBox.Sorted = true;
            this.elementsListBox.TabIndex = 4;
            this.elementsListBox.DoubleClick += new System.EventHandler(this.elementsListBox_DoubleClick);
            // 
            // recipesLabel
            // 
            this.recipesLabel.AutoSize = true;
            this.recipesLabel.Location = new System.Drawing.Point(303, 25);
            this.recipesLabel.Name = "recipesLabel";
            this.recipesLabel.Size = new System.Drawing.Size(46, 13);
            this.recipesLabel.TabIndex = 5;
            this.recipesLabel.Text = "Recipes";
            // 
            // recipesListBox
            // 
            this.recipesListBox.FormattingEnabled = true;
            this.recipesListBox.Location = new System.Drawing.Point(274, 41);
            this.recipesListBox.Name = "recipesListBox";
            this.recipesListBox.ScrollAlwaysVisible = true;
            this.recipesListBox.Size = new System.Drawing.Size(125, 290);
            this.recipesListBox.Sorted = true;
            this.recipesListBox.TabIndex = 6;
            this.recipesListBox.DoubleClick += new System.EventHandler(this.recipesListBox_DoubleClick);
            // 
            // decksLabel
            // 
            this.decksLabel.AutoSize = true;
            this.decksLabel.Location = new System.Drawing.Point(439, 25);
            this.decksLabel.Name = "decksLabel";
            this.decksLabel.Size = new System.Drawing.Size(38, 13);
            this.decksLabel.TabIndex = 7;
            this.decksLabel.Text = "Decks";
            // 
            // decksListBox
            // 
            this.decksListBox.FormattingEnabled = true;
            this.decksListBox.Location = new System.Drawing.Point(405, 41);
            this.decksListBox.Name = "decksListBox";
            this.decksListBox.ScrollAlwaysVisible = true;
            this.decksListBox.Size = new System.Drawing.Size(125, 290);
            this.decksListBox.Sorted = true;
            this.decksListBox.TabIndex = 8;
            this.decksListBox.DoubleClick += new System.EventHandler(this.decksListBox_DoubleClick);
            // 
            // legaciesLabel
            // 
            this.legaciesLabel.AutoSize = true;
            this.legaciesLabel.Location = new System.Drawing.Point(566, 25);
            this.legaciesLabel.Name = "legaciesLabel";
            this.legaciesLabel.Size = new System.Drawing.Size(50, 13);
            this.legaciesLabel.TabIndex = 9;
            this.legaciesLabel.Text = "Legacies";
            // 
            // legaciesListBox
            // 
            this.legaciesListBox.FormattingEnabled = true;
            this.legaciesListBox.Location = new System.Drawing.Point(536, 41);
            this.legaciesListBox.Name = "legaciesListBox";
            this.legaciesListBox.ScrollAlwaysVisible = true;
            this.legaciesListBox.Size = new System.Drawing.Size(125, 290);
            this.legaciesListBox.Sorted = true;
            this.legaciesListBox.TabIndex = 10;
            this.legaciesListBox.DoubleClick += new System.EventHandler(this.legaciesListBox_DoubleClick);
            // 
            // endingsListBox
            // 
            this.endingsListBox.FormattingEnabled = true;
            this.endingsListBox.Location = new System.Drawing.Point(667, 41);
            this.endingsListBox.Name = "endingsListBox";
            this.endingsListBox.ScrollAlwaysVisible = true;
            this.endingsListBox.Size = new System.Drawing.Size(125, 290);
            this.endingsListBox.Sorted = true;
            this.endingsListBox.TabIndex = 11;
            this.endingsListBox.DoubleClick += new System.EventHandler(this.endingsListBox_DoubleClick);
            // 
            // endingsLabel
            // 
            this.endingsLabel.AutoSize = true;
            this.endingsLabel.Location = new System.Drawing.Point(701, 25);
            this.endingsLabel.Name = "endingsLabel";
            this.endingsLabel.Size = new System.Drawing.Size(45, 13);
            this.endingsLabel.TabIndex = 12;
            this.endingsLabel.Text = "Endings";
            // 
            // verbsListBox
            // 
            this.verbsListBox.FormattingEnabled = true;
            this.verbsListBox.Location = new System.Drawing.Point(798, 41);
            this.verbsListBox.Name = "verbsListBox";
            this.verbsListBox.ScrollAlwaysVisible = true;
            this.verbsListBox.Size = new System.Drawing.Size(120, 290);
            this.verbsListBox.Sorted = true;
            this.verbsListBox.TabIndex = 13;
            this.verbsListBox.DoubleClick += new System.EventHandler(this.verbsListBox_DoubleClick);
            // 
            // verbsLabel
            // 
            this.verbsLabel.AutoSize = true;
            this.verbsLabel.Location = new System.Drawing.Point(842, 25);
            this.verbsLabel.Name = "verbsLabel";
            this.verbsLabel.Size = new System.Drawing.Size(34, 13);
            this.verbsLabel.TabIndex = 14;
            this.verbsLabel.Text = "Verbs";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripDropDownButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(930, 25);
            this.toolStrip1.TabIndex = 15;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // fileToolStripDropDownButton
            // 
            this.fileToolStripDropDownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fileToolStripDropDownButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.editManifestToolStripMenuItem,
            this.reloadContentToolStripMenuItem,
            this.saveModToolStripMenuItem,
            this.toolsToolStripMenuItem});
            this.fileToolStripDropDownButton.Image = ((System.Drawing.Image)(resources.GetObject("fileToolStripDropDownButton.Image")));
            this.fileToolStripDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.fileToolStripDropDownButton.Name = "fileToolStripDropDownButton";
            this.fileToolStripDropDownButton.Size = new System.Drawing.Size(38, 22);
            this.fileToolStripDropDownButton.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aspectToolStripMenuItem,
            this.elementToolStripMenuItem,
            this.recipeToolStripMenuItem,
            this.deckToolStripMenuItem,
            this.legacyToolStripMenuItem,
            this.endingToolStripMenuItem,
            this.verbToolStripMenuItem});
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.newToolStripMenuItem.Text = "New...";
            // 
            // aspectToolStripMenuItem
            // 
            this.aspectToolStripMenuItem.Name = "aspectToolStripMenuItem";
            this.aspectToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.aspectToolStripMenuItem.Text = "Aspect";
            this.aspectToolStripMenuItem.Click += new System.EventHandler(this.aspectToolStripMenuItem_Click);
            // 
            // elementToolStripMenuItem
            // 
            this.elementToolStripMenuItem.Name = "elementToolStripMenuItem";
            this.elementToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.elementToolStripMenuItem.Text = "Element";
            this.elementToolStripMenuItem.Click += new System.EventHandler(this.elementToolStripMenuItem_Click);
            // 
            // recipeToolStripMenuItem
            // 
            this.recipeToolStripMenuItem.Name = "recipeToolStripMenuItem";
            this.recipeToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.recipeToolStripMenuItem.Text = "Recipe";
            this.recipeToolStripMenuItem.Click += new System.EventHandler(this.recipeToolStripMenuItem_Click);
            // 
            // deckToolStripMenuItem
            // 
            this.deckToolStripMenuItem.Name = "deckToolStripMenuItem";
            this.deckToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.deckToolStripMenuItem.Text = "Deck";
            this.deckToolStripMenuItem.Click += new System.EventHandler(this.deckToolStripMenuItem_Click);
            // 
            // legacyToolStripMenuItem
            // 
            this.legacyToolStripMenuItem.Name = "legacyToolStripMenuItem";
            this.legacyToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.legacyToolStripMenuItem.Text = "Legacy";
            this.legacyToolStripMenuItem.Click += new System.EventHandler(this.legacyToolStripMenuItem_Click);
            // 
            // endingToolStripMenuItem
            // 
            this.endingToolStripMenuItem.Name = "endingToolStripMenuItem";
            this.endingToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.endingToolStripMenuItem.Text = "Ending";
            this.endingToolStripMenuItem.Click += new System.EventHandler(this.endingToolStripMenuItem_Click);
            // 
            // verbToolStripMenuItem
            // 
            this.verbToolStripMenuItem.Name = "verbToolStripMenuItem";
            this.verbToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.verbToolStripMenuItem.Text = "Verb";
            this.verbToolStripMenuItem.Click += new System.EventHandler(this.verbToolStripMenuItem_Click);
            // 
            // editManifestToolStripMenuItem
            // 
            this.editManifestToolStripMenuItem.Name = "editManifestToolStripMenuItem";
            this.editManifestToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.editManifestToolStripMenuItem.Text = "Edit Manifest";
            this.editManifestToolStripMenuItem.Click += new System.EventHandler(this.editManifestToolStripMenuItem_Click);
            // 
            // reloadContentToolStripMenuItem
            // 
            this.reloadContentToolStripMenuItem.Name = "reloadContentToolStripMenuItem";
            this.reloadContentToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.reloadContentToolStripMenuItem.Text = "Reload Content";
            this.reloadContentToolStripMenuItem.Click += new System.EventHandler(this.reloadContentToolStripMenuItem_Click);
            // 
            // saveModToolStripMenuItem
            // 
            this.saveModToolStripMenuItem.Name = "saveModToolStripMenuItem";
            this.saveModToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.saveModToolStripMenuItem.Text = "Save Mod";
            this.saveModToolStripMenuItem.Click += new System.EventHandler(this.saveModToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.summonGeneratorToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // summonGeneratorToolStripMenuItem
            // 
            this.summonGeneratorToolStripMenuItem.Name = "summonGeneratorToolStripMenuItem";
            this.summonGeneratorToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.summonGeneratorToolStripMenuItem.Text = "Summon Generator";
            this.summonGeneratorToolStripMenuItem.Click += new System.EventHandler(this.summonGeneratorToolStripMenuItem_Click);
            // 
            // editModeCheckBox
            // 
            this.editModeCheckBox.AutoSize = true;
            this.editModeCheckBox.Location = new System.Drawing.Point(844, 8);
            this.editModeCheckBox.Name = "editModeCheckBox";
            this.editModeCheckBox.Size = new System.Drawing.Size(74, 17);
            this.editModeCheckBox.TabIndex = 16;
            this.editModeCheckBox.Text = "Edit Mode";
            this.editModeCheckBox.UseVisualStyleBackColor = true;
            this.editModeCheckBox.CheckedChanged += new System.EventHandler(this.editModeCheckBox_CheckedChanged);
            // 
            // aspetsSearchTextBox
            // 
            this.aspetsSearchTextBox.Location = new System.Drawing.Point(12, 337);
            this.aspetsSearchTextBox.Name = "aspetsSearchTextBox";
            this.aspetsSearchTextBox.Size = new System.Drawing.Size(125, 20);
            this.aspetsSearchTextBox.TabIndex = 17;
            this.aspetsSearchTextBox.TextChanged += new System.EventHandler(this.aspetsSearchTextBox_TextChanged);
            // 
            // searchElementsTextBox
            // 
            this.elementsSearchTextBox.Location = new System.Drawing.Point(143, 337);
            this.elementsSearchTextBox.Name = "searchElementsTextBox";
            this.elementsSearchTextBox.Size = new System.Drawing.Size(125, 20);
            this.elementsSearchTextBox.TabIndex = 18;
            this.elementsSearchTextBox.TextChanged += new System.EventHandler(this.elementsSearchTextBox_TextChanged);
            // 
            // searchRecipesTextBox
            // 
            this.recipesSearchTextBox.Location = new System.Drawing.Point(274, 337);
            this.recipesSearchTextBox.Name = "searchRecipesTextBox";
            this.recipesSearchTextBox.Size = new System.Drawing.Size(125, 20);
            this.recipesSearchTextBox.TabIndex = 19;
            this.recipesSearchTextBox.TextChanged += new System.EventHandler(this.recipesSearchTextBox_TextChanged);
            // 
            // decksSearchTextBox
            // 
            this.decksSearchTextBox.Location = new System.Drawing.Point(405, 337);
            this.decksSearchTextBox.Name = "decksSearchTextBox";
            this.decksSearchTextBox.Size = new System.Drawing.Size(125, 20);
            this.decksSearchTextBox.TabIndex = 20;
            this.decksSearchTextBox.TextChanged += new System.EventHandler(this.decksSearchTextBox_TextChanged);
            // 
            // legaciesSearchTextBox
            // 
            this.legaciesSearchTextBox.Location = new System.Drawing.Point(536, 337);
            this.legaciesSearchTextBox.Name = "legaciesSearchTextBox";
            this.legaciesSearchTextBox.Size = new System.Drawing.Size(125, 20);
            this.legaciesSearchTextBox.TabIndex = 21;
            this.legaciesSearchTextBox.TextChanged += new System.EventHandler(this.legaciesSearchTextBox_TextChanged);
            // 
            // endingsSearchTextBox
            // 
            this.endingsSearchTextBox.Location = new System.Drawing.Point(667, 337);
            this.endingsSearchTextBox.Name = "endingsSearchTextBox";
            this.endingsSearchTextBox.Size = new System.Drawing.Size(125, 20);
            this.endingsSearchTextBox.TabIndex = 22;
            this.endingsSearchTextBox.TextChanged += new System.EventHandler(this.endingsSearchTextBox_TextChanged);
            // 
            // verbsSearchTextBox
            // 
            this.verbsSearchTextBox.Location = new System.Drawing.Point(798, 337);
            this.verbsSearchTextBox.Name = "verbsSearchTextBox";
            this.verbsSearchTextBox.Size = new System.Drawing.Size(120, 20);
            this.verbsSearchTextBox.TabIndex = 23;
            this.verbsSearchTextBox.TextChanged += new System.EventHandler(this.verbsSearchTextBox_TextChanged);
            // 
            // ModViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 369);
            this.Controls.Add(this.verbsSearchTextBox);
            this.Controls.Add(this.endingsSearchTextBox);
            this.Controls.Add(this.legaciesSearchTextBox);
            this.Controls.Add(this.decksSearchTextBox);
            this.Controls.Add(this.recipesSearchTextBox);
            this.Controls.Add(this.elementsSearchTextBox);
            this.Controls.Add(this.aspetsSearchTextBox);
            this.Controls.Add(this.editModeCheckBox);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.verbsLabel);
            this.Controls.Add(this.verbsListBox);
            this.Controls.Add(this.endingsLabel);
            this.Controls.Add(this.endingsListBox);
            this.Controls.Add(this.legaciesListBox);
            this.Controls.Add(this.legaciesLabel);
            this.Controls.Add(this.decksListBox);
            this.Controls.Add(this.decksLabel);
            this.Controls.Add(this.recipesListBox);
            this.Controls.Add(this.recipesLabel);
            this.Controls.Add(this.elementsListBox);
            this.Controls.Add(this.elementsLabel);
            this.Controls.Add(this.aspectsLabel);
            this.Controls.Add(this.aspectsListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ModViewer";
            this.Text = "Cultist Simulator Modding Toolkit";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ModViewer_FormClosed);
            this.Shown += new System.EventHandler(this.ModViewer_Shown);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox aspectsListBox;
        private System.Windows.Forms.Label aspectsLabel;
        private System.Windows.Forms.Label elementsLabel;
        private System.Windows.Forms.ListBox elementsListBox;
        private System.Windows.Forms.Label recipesLabel;
        private System.Windows.Forms.ListBox recipesListBox;
        private System.Windows.Forms.Label decksLabel;
        private System.Windows.Forms.ListBox decksListBox;
        private System.Windows.Forms.Label legaciesLabel;
        private System.Windows.Forms.ListBox legaciesListBox;
        private System.Windows.Forms.ListBox endingsListBox;
        private System.Windows.Forms.Label endingsLabel;
        private System.Windows.Forms.ListBox verbsListBox;
        private System.Windows.Forms.Label verbsLabel;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton fileToolStripDropDownButton;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aspectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem elementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recipeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deckToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem legacyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem endingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verbToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editManifestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveModToolStripMenuItem;
        private System.Windows.Forms.CheckBox editModeCheckBox;
        private System.Windows.Forms.ToolStripMenuItem reloadContentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem summonGeneratorToolStripMenuItem;
        private System.Windows.Forms.TextBox aspetsSearchTextBox;
        private System.Windows.Forms.TextBox elementsSearchTextBox;
        private System.Windows.Forms.TextBox recipesSearchTextBox;
        private System.Windows.Forms.TextBox decksSearchTextBox;
        private System.Windows.Forms.TextBox legaciesSearchTextBox;
        private System.Windows.Forms.TextBox endingsSearchTextBox;
        private System.Windows.Forms.TextBox verbsSearchTextBox;
    }
}

