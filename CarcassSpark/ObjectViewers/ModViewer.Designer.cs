﻿namespace CarcassSpark.ObjectViewers
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModViewer));
            this.aspectsListBox = new System.Windows.Forms.ListBox();
            this.aspectContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.elementsWithThisAspectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.elementsThatReactWithThisAspectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recipesRequiringThisAspectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recipesThatProduceThisAspectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.slotsRequiringThisAspectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteSelectedAspectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.duplicateSelectedAspectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportSelectedAspectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyAspectJSONToClipboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aspectsLabel = new System.Windows.Forms.Label();
            this.elementsLabel = new System.Windows.Forms.Label();
            this.elementsListBox = new System.Windows.Forms.ListBox();
            this.elementContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.searchToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.elementsThatDecayIntoThisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.elementsThatXtriggerIntoThisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recipesThatRequireThisElementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recipesThatProduceThisElementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.decksThatContainThisElementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.legaciesThatStartWithThisElementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.elementsWithSlotsThatRequireThisElementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteSelectedElementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.duplicateSelectedElementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportSelectedElementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyElementJSONToClipboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recipesLabel = new System.Windows.Forms.Label();
            this.recipesListBox = new System.Windows.Forms.ListBox();
            this.recipeContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.searchForToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recipesThatLinkToThisRecipeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAsFlowchartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteSelectedRecipeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.duplicateSelectedRecipeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportSelectedRecipeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyRecipeJSONToClipboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.decksLabel = new System.Windows.Forms.Label();
            this.decksListBox = new System.Windows.Forms.ListBox();
            this.deckContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.searchForToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.recipesThatDrawFromThisDeckToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteSelectedDeckToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.duplicateSelectedDeckToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportSelectedDeckToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyDeckJSONToClipboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.legaciesLabel = new System.Windows.Forms.Label();
            this.legaciesListBox = new System.Windows.Forms.ListBox();
            this.legacyContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteSelectedLegacyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.duplicateSelectedLegacyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportSelectedLegacyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copySelectedLegacyJSONToClipboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.endingsListBox = new System.Windows.Forms.ListBox();
            this.endingContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.searchForToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.recipesThatCauseThisEndingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteSelectedEndingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.duplicateSelectedEndingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportSelectedEndingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.endingsLabel = new System.Windows.Forms.Label();
            this.verbsListBox = new System.Windows.Forms.ListBox();
            this.verbContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.searchForToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.recipesThatUseThisVerbToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.elementsWithSlotsForThisVerbToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteSelectedVerbToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.duplicateSelectedVerbToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportSelectedVerbToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verbsLabel = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.fileToolStripDropDownButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.saveModToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editManifestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reloadContentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toggleAutosaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toggleEditModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newItemToolStripButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.aspectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.elementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recipeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deckToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.legacyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.endingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verbToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importToolStripButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.aspectToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.elementToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.recipeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deckToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.legacyToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.endingToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.verbToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.summonGeneratorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageImporterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aspetsSearchTextBox = new System.Windows.Forms.TextBox();
            this.elementsSearchTextBox = new System.Windows.Forms.TextBox();
            this.recipesSearchTextBox = new System.Windows.Forms.TextBox();
            this.decksSearchTextBox = new System.Windows.Forms.TextBox();
            this.legaciesSearchTextBox = new System.Windows.Forms.TextBox();
            this.endingsSearchTextBox = new System.Windows.Forms.TextBox();
            this.verbsSearchTextBox = new System.Windows.Forms.TextBox();
            this.autosaveTimer = new System.Windows.Forms.Timer(this.components);
            this.saveToFolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.ProgressBar = new System.Windows.Forms.ProgressBar();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.copySelectedEndingJSONToClipboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copySelectedVerbJSONToClipboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aspectContextMenuStrip.SuspendLayout();
            this.elementContextMenuStrip.SuspendLayout();
            this.recipeContextMenuStrip.SuspendLayout();
            this.deckContextMenuStrip.SuspendLayout();
            this.legacyContextMenuStrip.SuspendLayout();
            this.endingContextMenuStrip.SuspendLayout();
            this.verbContextMenuStrip.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // aspectsListBox
            // 
            this.aspectsListBox.ContextMenuStrip = this.aspectContextMenuStrip;
            this.aspectsListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.aspectsListBox.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.aspectsListBox.Location = new System.Drawing.Point(3, 16);
            this.aspectsListBox.Name = "aspectsListBox";
            this.aspectsListBox.ScrollAlwaysVisible = true;
            this.aspectsListBox.Size = new System.Drawing.Size(124, 287);
            this.aspectsListBox.Sorted = true;
            this.aspectsListBox.TabIndex = 1;
            this.aspectsListBox.DoubleClick += new System.EventHandler(this.aspectListBox_DoubleClick);
            this.aspectsListBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.aspectsListBox_MouseDown);
            // 
            // aspectContextMenuStrip
            // 
            this.aspectContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchToolStripMenuItem,
            this.deleteSelectedAspectToolStripMenuItem,
            this.duplicateSelectedAspectToolStripMenuItem,
            this.exportSelectedAspectToolStripMenuItem,
            this.copyAspectJSONToClipboardToolStripMenuItem});
            this.aspectContextMenuStrip.Name = "aspectContextMenuStrip";
            this.aspectContextMenuStrip.ShowImageMargin = false;
            this.aspectContextMenuStrip.Size = new System.Drawing.Size(264, 114);
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.searchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.elementsWithThisAspectToolStripMenuItem,
            this.elementsThatReactWithThisAspectToolStripMenuItem,
            this.recipesRequiringThisAspectToolStripMenuItem,
            this.recipesThatProduceThisAspectToolStripMenuItem,
            this.slotsRequiringThisAspectToolStripMenuItem});
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(263, 22);
            this.searchToolStripMenuItem.Text = "Search for...";
            // 
            // elementsWithThisAspectToolStripMenuItem
            // 
            this.elementsWithThisAspectToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.elementsWithThisAspectToolStripMenuItem.Name = "elementsWithThisAspectToolStripMenuItem";
            this.elementsWithThisAspectToolStripMenuItem.Size = new System.Drawing.Size(286, 22);
            this.elementsWithThisAspectToolStripMenuItem.Text = "Elements with this aspect";
            this.elementsWithThisAspectToolStripMenuItem.Click += new System.EventHandler(this.elementsWithThisAspectToolStripMenuItem_Click);
            // 
            // elementsThatReactWithThisAspectToolStripMenuItem
            // 
            this.elementsThatReactWithThisAspectToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.elementsThatReactWithThisAspectToolStripMenuItem.Name = "elementsThatReactWithThisAspectToolStripMenuItem";
            this.elementsThatReactWithThisAspectToolStripMenuItem.Size = new System.Drawing.Size(286, 22);
            this.elementsThatReactWithThisAspectToolStripMenuItem.Text = "Elements that react with this aspect";
            this.elementsThatReactWithThisAspectToolStripMenuItem.Click += new System.EventHandler(this.elementsThatReactWithThisAspectToolStripMenuItem_Click);
            // 
            // recipesRequiringThisAspectToolStripMenuItem
            // 
            this.recipesRequiringThisAspectToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.recipesRequiringThisAspectToolStripMenuItem.Name = "recipesRequiringThisAspectToolStripMenuItem";
            this.recipesRequiringThisAspectToolStripMenuItem.Size = new System.Drawing.Size(286, 22);
            this.recipesRequiringThisAspectToolStripMenuItem.Text = "Recipes requiring this aspect";
            this.recipesRequiringThisAspectToolStripMenuItem.Click += new System.EventHandler(this.recipesRequiringThisAspectToolStripMenuItem_Click);
            // 
            // recipesThatProduceThisAspectToolStripMenuItem
            // 
            this.recipesThatProduceThisAspectToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.recipesThatProduceThisAspectToolStripMenuItem.Name = "recipesThatProduceThisAspectToolStripMenuItem";
            this.recipesThatProduceThisAspectToolStripMenuItem.Size = new System.Drawing.Size(286, 22);
            this.recipesThatProduceThisAspectToolStripMenuItem.Text = "Recipes that produce this aspect";
            this.recipesThatProduceThisAspectToolStripMenuItem.Click += new System.EventHandler(this.recipesThatProduceThisAspectToolStripMenuItem_Click);
            // 
            // slotsRequiringThisAspectToolStripMenuItem
            // 
            this.slotsRequiringThisAspectToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.slotsRequiringThisAspectToolStripMenuItem.Name = "slotsRequiringThisAspectToolStripMenuItem";
            this.slotsRequiringThisAspectToolStripMenuItem.Size = new System.Drawing.Size(286, 22);
            this.slotsRequiringThisAspectToolStripMenuItem.Text = "Elements with Slots requiring this aspect";
            // 
            // deleteSelectedAspectToolStripMenuItem
            // 
            this.deleteSelectedAspectToolStripMenuItem.Name = "deleteSelectedAspectToolStripMenuItem";
            this.deleteSelectedAspectToolStripMenuItem.Size = new System.Drawing.Size(263, 22);
            this.deleteSelectedAspectToolStripMenuItem.Text = "Delete Selected Aspect";
            this.deleteSelectedAspectToolStripMenuItem.Click += new System.EventHandler(this.deleteSelectedAspectToolStripMenuItem_Click);
            // 
            // duplicateSelectedAspectToolStripMenuItem
            // 
            this.duplicateSelectedAspectToolStripMenuItem.Name = "duplicateSelectedAspectToolStripMenuItem";
            this.duplicateSelectedAspectToolStripMenuItem.Size = new System.Drawing.Size(263, 22);
            this.duplicateSelectedAspectToolStripMenuItem.Text = "Duplicate Selected Aspect";
            this.duplicateSelectedAspectToolStripMenuItem.Click += new System.EventHandler(this.duplicateSelectedAspectToolStripMenuItem_Click);
            // 
            // exportSelectedAspectToolStripMenuItem
            // 
            this.exportSelectedAspectToolStripMenuItem.Name = "exportSelectedAspectToolStripMenuItem";
            this.exportSelectedAspectToolStripMenuItem.Size = new System.Drawing.Size(263, 22);
            this.exportSelectedAspectToolStripMenuItem.Text = "Export Selected Aspect";
            this.exportSelectedAspectToolStripMenuItem.Click += new System.EventHandler(this.exportSelectedAspectToolStripMenuItem_Click);
            // 
            // copyAspectJSONToClipboardToolStripMenuItem
            // 
            this.copyAspectJSONToClipboardToolStripMenuItem.Name = "copyAspectJSONToClipboardToolStripMenuItem";
            this.copyAspectJSONToClipboardToolStripMenuItem.Size = new System.Drawing.Size(263, 22);
            this.copyAspectJSONToClipboardToolStripMenuItem.Text = "Copy Selected Aspect JSON to Clipboard";
            this.copyAspectJSONToClipboardToolStripMenuItem.Click += new System.EventHandler(this.copySelectedAspectJSONToClipboardToolStripMenuItem_Click);
            // 
            // aspectsLabel
            // 
            this.aspectsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.aspectsLabel.Location = new System.Drawing.Point(3, 0);
            this.aspectsLabel.Name = "aspectsLabel";
            this.aspectsLabel.Size = new System.Drawing.Size(124, 13);
            this.aspectsLabel.TabIndex = 2;
            this.aspectsLabel.Text = "Aspects";
            this.aspectsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // elementsLabel
            // 
            this.elementsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.elementsLabel.Location = new System.Drawing.Point(133, 0);
            this.elementsLabel.Name = "elementsLabel";
            this.elementsLabel.Size = new System.Drawing.Size(125, 13);
            this.elementsLabel.TabIndex = 3;
            this.elementsLabel.Text = "Elements";
            this.elementsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // elementsListBox
            // 
            this.elementsListBox.ContextMenuStrip = this.elementContextMenuStrip;
            this.elementsListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.elementsListBox.FormattingEnabled = true;
            this.elementsListBox.Location = new System.Drawing.Point(133, 16);
            this.elementsListBox.Name = "elementsListBox";
            this.elementsListBox.ScrollAlwaysVisible = true;
            this.elementsListBox.Size = new System.Drawing.Size(125, 287);
            this.elementsListBox.Sorted = true;
            this.elementsListBox.TabIndex = 4;
            this.elementsListBox.DoubleClick += new System.EventHandler(this.elementsListBox_DoubleClick);
            this.elementsListBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.elementsListBox_MouseDown);
            // 
            // elementContextMenuStrip
            // 
            this.elementContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchToolStripMenuItem1,
            this.deleteSelectedElementToolStripMenuItem,
            this.duplicateSelectedElementToolStripMenuItem,
            this.exportSelectedElementToolStripMenuItem,
            this.copyElementJSONToClipboardToolStripMenuItem});
            this.elementContextMenuStrip.Name = "elementContextMenuStrip";
            this.elementContextMenuStrip.ShowImageMargin = false;
            this.elementContextMenuStrip.Size = new System.Drawing.Size(271, 114);
            // 
            // searchToolStripMenuItem1
            // 
            this.searchToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.elementsThatDecayIntoThisToolStripMenuItem,
            this.elementsThatXtriggerIntoThisToolStripMenuItem,
            this.recipesThatRequireThisElementToolStripMenuItem,
            this.recipesThatProduceThisElementToolStripMenuItem,
            this.decksThatContainThisElementToolStripMenuItem,
            this.legaciesThatStartWithThisElementToolStripMenuItem,
            this.elementsWithSlotsThatRequireThisElementToolStripMenuItem});
            this.searchToolStripMenuItem1.Name = "searchToolStripMenuItem1";
            this.searchToolStripMenuItem1.Size = new System.Drawing.Size(270, 22);
            this.searchToolStripMenuItem1.Text = "Search for...";
            // 
            // elementsThatDecayIntoThisToolStripMenuItem
            // 
            this.elementsThatDecayIntoThisToolStripMenuItem.Name = "elementsThatDecayIntoThisToolStripMenuItem";
            this.elementsThatDecayIntoThisToolStripMenuItem.Size = new System.Drawing.Size(308, 22);
            this.elementsThatDecayIntoThisToolStripMenuItem.Text = "Elements that decay into this element";
            this.elementsThatDecayIntoThisToolStripMenuItem.Click += new System.EventHandler(this.elementsThatDecayIntoThisToolStripMenuItem_Click);
            // 
            // elementsThatXtriggerIntoThisToolStripMenuItem
            // 
            this.elementsThatXtriggerIntoThisToolStripMenuItem.Name = "elementsThatXtriggerIntoThisToolStripMenuItem";
            this.elementsThatXtriggerIntoThisToolStripMenuItem.Size = new System.Drawing.Size(308, 22);
            this.elementsThatXtriggerIntoThisToolStripMenuItem.Text = "Elements that xtrigger into this element";
            this.elementsThatXtriggerIntoThisToolStripMenuItem.Click += new System.EventHandler(this.elementsThatXtriggerIntoThisToolStripMenuItem_Click);
            // 
            // recipesThatRequireThisElementToolStripMenuItem
            // 
            this.recipesThatRequireThisElementToolStripMenuItem.Name = "recipesThatRequireThisElementToolStripMenuItem";
            this.recipesThatRequireThisElementToolStripMenuItem.Size = new System.Drawing.Size(308, 22);
            this.recipesThatRequireThisElementToolStripMenuItem.Text = "Recipes that require this element";
            this.recipesThatRequireThisElementToolStripMenuItem.Click += new System.EventHandler(this.recipesThatRequireThisElementToolStripMenuItem_Click);
            // 
            // recipesThatProduceThisElementToolStripMenuItem
            // 
            this.recipesThatProduceThisElementToolStripMenuItem.Name = "recipesThatProduceThisElementToolStripMenuItem";
            this.recipesThatProduceThisElementToolStripMenuItem.Size = new System.Drawing.Size(308, 22);
            this.recipesThatProduceThisElementToolStripMenuItem.Text = "Recipes that produce this element";
            this.recipesThatProduceThisElementToolStripMenuItem.Click += new System.EventHandler(this.recipesThatProduceThisElementToolStripMenuItem_Click);
            // 
            // decksThatContainThisElementToolStripMenuItem
            // 
            this.decksThatContainThisElementToolStripMenuItem.Name = "decksThatContainThisElementToolStripMenuItem";
            this.decksThatContainThisElementToolStripMenuItem.Size = new System.Drawing.Size(308, 22);
            this.decksThatContainThisElementToolStripMenuItem.Text = "Decks that contain this element";
            this.decksThatContainThisElementToolStripMenuItem.Click += new System.EventHandler(this.decksThatContainThisElementToolStripMenuItem_Click);
            // 
            // legaciesThatStartWithThisElementToolStripMenuItem
            // 
            this.legaciesThatStartWithThisElementToolStripMenuItem.Name = "legaciesThatStartWithThisElementToolStripMenuItem";
            this.legaciesThatStartWithThisElementToolStripMenuItem.Size = new System.Drawing.Size(308, 22);
            this.legaciesThatStartWithThisElementToolStripMenuItem.Text = "Legacies that start with this element";
            this.legaciesThatStartWithThisElementToolStripMenuItem.Click += new System.EventHandler(this.legaciesThatStartWithThisElementToolStripMenuItem_Click);
            // 
            // elementsWithSlotsThatRequireThisElementToolStripMenuItem
            // 
            this.elementsWithSlotsThatRequireThisElementToolStripMenuItem.Name = "elementsWithSlotsThatRequireThisElementToolStripMenuItem";
            this.elementsWithSlotsThatRequireThisElementToolStripMenuItem.Size = new System.Drawing.Size(308, 22);
            this.elementsWithSlotsThatRequireThisElementToolStripMenuItem.Text = "Elements with Slots that require this element";
            // 
            // deleteSelectedElementToolStripMenuItem
            // 
            this.deleteSelectedElementToolStripMenuItem.Name = "deleteSelectedElementToolStripMenuItem";
            this.deleteSelectedElementToolStripMenuItem.Size = new System.Drawing.Size(270, 22);
            this.deleteSelectedElementToolStripMenuItem.Text = "Delete Selected Element";
            this.deleteSelectedElementToolStripMenuItem.Click += new System.EventHandler(this.deleteSelectedElementToolStripMenuItem_Click);
            // 
            // duplicateSelectedElementToolStripMenuItem
            // 
            this.duplicateSelectedElementToolStripMenuItem.Name = "duplicateSelectedElementToolStripMenuItem";
            this.duplicateSelectedElementToolStripMenuItem.Size = new System.Drawing.Size(270, 22);
            this.duplicateSelectedElementToolStripMenuItem.Text = "Duplicate Selected Element";
            this.duplicateSelectedElementToolStripMenuItem.Click += new System.EventHandler(this.duplicateSelectedElementToolStripMenuItem_Click);
            // 
            // exportSelectedElementToolStripMenuItem
            // 
            this.exportSelectedElementToolStripMenuItem.Name = "exportSelectedElementToolStripMenuItem";
            this.exportSelectedElementToolStripMenuItem.Size = new System.Drawing.Size(270, 22);
            this.exportSelectedElementToolStripMenuItem.Text = "Export Selected Element";
            this.exportSelectedElementToolStripMenuItem.Click += new System.EventHandler(this.exportSelectedElementToolStripMenuItem_Click);
            // 
            // copyElementJSONToClipboardToolStripMenuItem
            // 
            this.copyElementJSONToClipboardToolStripMenuItem.Name = "copyElementJSONToClipboardToolStripMenuItem";
            this.copyElementJSONToClipboardToolStripMenuItem.Size = new System.Drawing.Size(270, 22);
            this.copyElementJSONToClipboardToolStripMenuItem.Text = "Copy Selected Element JSON to Clipboard";
            this.copyElementJSONToClipboardToolStripMenuItem.Click += new System.EventHandler(this.copySelectedElementJSONToClipboardToolStripMenuItem_Click);
            // 
            // recipesLabel
            // 
            this.recipesLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.recipesLabel.Location = new System.Drawing.Point(264, 0);
            this.recipesLabel.Name = "recipesLabel";
            this.recipesLabel.Size = new System.Drawing.Size(125, 13);
            this.recipesLabel.TabIndex = 5;
            this.recipesLabel.Text = "Recipes";
            this.recipesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // recipesListBox
            // 
            this.recipesListBox.ContextMenuStrip = this.recipeContextMenuStrip;
            this.recipesListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.recipesListBox.FormattingEnabled = true;
            this.recipesListBox.Location = new System.Drawing.Point(264, 16);
            this.recipesListBox.Name = "recipesListBox";
            this.recipesListBox.ScrollAlwaysVisible = true;
            this.recipesListBox.Size = new System.Drawing.Size(125, 287);
            this.recipesListBox.Sorted = true;
            this.recipesListBox.TabIndex = 6;
            this.recipesListBox.DoubleClick += new System.EventHandler(this.recipesListBox_DoubleClick);
            this.recipesListBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.recipesListBox_MouseDown);
            // 
            // recipeContextMenuStrip
            // 
            this.recipeContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchForToolStripMenuItem,
            this.viewAsFlowchartToolStripMenuItem,
            this.deleteSelectedRecipeToolStripMenuItem,
            this.duplicateSelectedRecipeToolStripMenuItem,
            this.exportSelectedRecipeToolStripMenuItem,
            this.copyRecipeJSONToClipboardToolStripMenuItem});
            this.recipeContextMenuStrip.Name = "recipeContextMenuStrip";
            this.recipeContextMenuStrip.ShowImageMargin = false;
            this.recipeContextMenuStrip.Size = new System.Drawing.Size(216, 136);
            // 
            // searchForToolStripMenuItem
            // 
            this.searchForToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.recipesThatLinkToThisRecipeToolStripMenuItem});
            this.searchForToolStripMenuItem.Name = "searchForToolStripMenuItem";
            this.searchForToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.searchForToolStripMenuItem.Text = "Search for...";
            // 
            // recipesThatLinkToThisRecipeToolStripMenuItem
            // 
            this.recipesThatLinkToThisRecipeToolStripMenuItem.Name = "recipesThatLinkToThisRecipeToolStripMenuItem";
            this.recipesThatLinkToThisRecipeToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.recipesThatLinkToThisRecipeToolStripMenuItem.Text = "Recipes that link to this recipe";
            this.recipesThatLinkToThisRecipeToolStripMenuItem.Click += new System.EventHandler(this.recipesThatLinkToThisRecipeToolStripMenuItem_Click);
            // 
            // viewAsFlowchartToolStripMenuItem
            // 
            this.viewAsFlowchartToolStripMenuItem.Name = "viewAsFlowchartToolStripMenuItem";
            this.viewAsFlowchartToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.viewAsFlowchartToolStripMenuItem.Text = "View As Flowchart";
            this.viewAsFlowchartToolStripMenuItem.Click += new System.EventHandler(this.viewAsFlowchartToolStripMenuItem_Click);
            // 
            // deleteSelectedRecipeToolStripMenuItem
            // 
            this.deleteSelectedRecipeToolStripMenuItem.Name = "deleteSelectedRecipeToolStripMenuItem";
            this.deleteSelectedRecipeToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.deleteSelectedRecipeToolStripMenuItem.Text = "Delete Selected Recipe";
            this.deleteSelectedRecipeToolStripMenuItem.Click += new System.EventHandler(this.deleteSelectedRecipeToolStripMenuItem_Click);
            // 
            // duplicateSelectedRecipeToolStripMenuItem
            // 
            this.duplicateSelectedRecipeToolStripMenuItem.Name = "duplicateSelectedRecipeToolStripMenuItem";
            this.duplicateSelectedRecipeToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.duplicateSelectedRecipeToolStripMenuItem.Text = "Duplicate Selected Recipe";
            this.duplicateSelectedRecipeToolStripMenuItem.Click += new System.EventHandler(this.duplicateSelectedRecipeToolStripMenuItem_Click);
            // 
            // exportSelectedRecipeToolStripMenuItem
            // 
            this.exportSelectedRecipeToolStripMenuItem.Name = "exportSelectedRecipeToolStripMenuItem";
            this.exportSelectedRecipeToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.exportSelectedRecipeToolStripMenuItem.Text = "Export Selected Recipe";
            this.exportSelectedRecipeToolStripMenuItem.Click += new System.EventHandler(this.exportSelectedRecipeToolStripMenuItem_Click);
            // 
            // copyRecipeJSONToClipboardToolStripMenuItem
            // 
            this.copyRecipeJSONToClipboardToolStripMenuItem.Name = "copyRecipeJSONToClipboardToolStripMenuItem";
            this.copyRecipeJSONToClipboardToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.copyRecipeJSONToClipboardToolStripMenuItem.Text = "Copy Recipe JSON to Clipboard";
            this.copyRecipeJSONToClipboardToolStripMenuItem.Click += new System.EventHandler(this.copySelectedRecipeJSONToClipboardToolStripMenuItem_Click);
            // 
            // decksLabel
            // 
            this.decksLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.decksLabel.Location = new System.Drawing.Point(395, 0);
            this.decksLabel.Name = "decksLabel";
            this.decksLabel.Size = new System.Drawing.Size(125, 13);
            this.decksLabel.TabIndex = 7;
            this.decksLabel.Text = "Decks";
            this.decksLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // decksListBox
            // 
            this.decksListBox.ContextMenuStrip = this.deckContextMenuStrip;
            this.decksListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.decksListBox.FormattingEnabled = true;
            this.decksListBox.Location = new System.Drawing.Point(395, 16);
            this.decksListBox.Name = "decksListBox";
            this.decksListBox.ScrollAlwaysVisible = true;
            this.decksListBox.Size = new System.Drawing.Size(125, 287);
            this.decksListBox.Sorted = true;
            this.decksListBox.TabIndex = 8;
            this.decksListBox.DoubleClick += new System.EventHandler(this.decksListBox_DoubleClick);
            this.decksListBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.decksListBox_MouseDown);
            // 
            // deckContextMenuStrip
            // 
            this.deckContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchForToolStripMenuItem1,
            this.deleteSelectedDeckToolStripMenuItem,
            this.duplicateSelectedDeckToolStripMenuItem,
            this.exportSelectedDeckToolStripMenuItem,
            this.copyDeckJSONToClipboardToolStripMenuItem});
            this.deckContextMenuStrip.Name = "deckContextMenuStrip";
            this.deckContextMenuStrip.ShowImageMargin = false;
            this.deckContextMenuStrip.Size = new System.Drawing.Size(254, 114);
            // 
            // searchForToolStripMenuItem1
            // 
            this.searchForToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.recipesThatDrawFromThisDeckToolStripMenuItem});
            this.searchForToolStripMenuItem1.Name = "searchForToolStripMenuItem1";
            this.searchForToolStripMenuItem1.Size = new System.Drawing.Size(253, 22);
            this.searchForToolStripMenuItem1.Text = "Search for...";
            // 
            // recipesThatDrawFromThisDeckToolStripMenuItem
            // 
            this.recipesThatDrawFromThisDeckToolStripMenuItem.Name = "recipesThatDrawFromThisDeckToolStripMenuItem";
            this.recipesThatDrawFromThisDeckToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
            this.recipesThatDrawFromThisDeckToolStripMenuItem.Text = "Recipes that draw from this deck";
            this.recipesThatDrawFromThisDeckToolStripMenuItem.Click += new System.EventHandler(this.recipesThatDrawFromThisDeckToolStripMenuItem_Click);
            // 
            // deleteSelectedDeckToolStripMenuItem
            // 
            this.deleteSelectedDeckToolStripMenuItem.Name = "deleteSelectedDeckToolStripMenuItem";
            this.deleteSelectedDeckToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
            this.deleteSelectedDeckToolStripMenuItem.Text = "Delete Selected Deck";
            this.deleteSelectedDeckToolStripMenuItem.Click += new System.EventHandler(this.deleteSelectedDeckToolStripMenuItem_Click);
            // 
            // duplicateSelectedDeckToolStripMenuItem
            // 
            this.duplicateSelectedDeckToolStripMenuItem.Name = "duplicateSelectedDeckToolStripMenuItem";
            this.duplicateSelectedDeckToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
            this.duplicateSelectedDeckToolStripMenuItem.Text = "Duplicate Selected Deck";
            this.duplicateSelectedDeckToolStripMenuItem.Click += new System.EventHandler(this.duplicateSelectedDeckToolStripMenuItem_Click);
            // 
            // exportSelectedDeckToolStripMenuItem
            // 
            this.exportSelectedDeckToolStripMenuItem.Name = "exportSelectedDeckToolStripMenuItem";
            this.exportSelectedDeckToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
            this.exportSelectedDeckToolStripMenuItem.Text = "Export Selected Deck";
            this.exportSelectedDeckToolStripMenuItem.Click += new System.EventHandler(this.exportSelectedDeckToolStripMenuItem_Click);
            // 
            // copyDeckJSONToClipboardToolStripMenuItem
            // 
            this.copyDeckJSONToClipboardToolStripMenuItem.Name = "copyDeckJSONToClipboardToolStripMenuItem";
            this.copyDeckJSONToClipboardToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
            this.copyDeckJSONToClipboardToolStripMenuItem.Text = "Copy Selected Deck JSON to Clipboard";
            this.copyDeckJSONToClipboardToolStripMenuItem.Click += new System.EventHandler(this.copySelectedDeckJSONToClipboardToolStripMenuItem_Click);
            // 
            // legaciesLabel
            // 
            this.legaciesLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.legaciesLabel.Location = new System.Drawing.Point(526, 0);
            this.legaciesLabel.Name = "legaciesLabel";
            this.legaciesLabel.Size = new System.Drawing.Size(125, 13);
            this.legaciesLabel.TabIndex = 9;
            this.legaciesLabel.Text = "Legacies";
            this.legaciesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // legaciesListBox
            // 
            this.legaciesListBox.ContextMenuStrip = this.legacyContextMenuStrip;
            this.legaciesListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.legaciesListBox.FormattingEnabled = true;
            this.legaciesListBox.Location = new System.Drawing.Point(526, 16);
            this.legaciesListBox.Name = "legaciesListBox";
            this.legaciesListBox.ScrollAlwaysVisible = true;
            this.legaciesListBox.Size = new System.Drawing.Size(125, 287);
            this.legaciesListBox.Sorted = true;
            this.legaciesListBox.TabIndex = 10;
            this.legaciesListBox.DoubleClick += new System.EventHandler(this.legaciesListBox_DoubleClick);
            this.legaciesListBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.legaciesListBox_MouseDown);
            // 
            // legacyContextMenuStrip
            // 
            this.legacyContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteSelectedLegacyToolStripMenuItem,
            this.duplicateSelectedLegacyToolStripMenuItem,
            this.exportSelectedLegacyToolStripMenuItem,
            this.copySelectedLegacyJSONToClipboardToolStripMenuItem});
            this.legacyContextMenuStrip.Name = "legacyContextMenuStrip";
            this.legacyContextMenuStrip.Size = new System.Drawing.Size(290, 92);
            // 
            // deleteSelectedLegacyToolStripMenuItem
            // 
            this.deleteSelectedLegacyToolStripMenuItem.Name = "deleteSelectedLegacyToolStripMenuItem";
            this.deleteSelectedLegacyToolStripMenuItem.Size = new System.Drawing.Size(289, 22);
            this.deleteSelectedLegacyToolStripMenuItem.Text = "Delete Selected Legacy";
            this.deleteSelectedLegacyToolStripMenuItem.Click += new System.EventHandler(this.deleteSelectedLegacyToolStripMenuItem_Click);
            // 
            // duplicateSelectedLegacyToolStripMenuItem
            // 
            this.duplicateSelectedLegacyToolStripMenuItem.Name = "duplicateSelectedLegacyToolStripMenuItem";
            this.duplicateSelectedLegacyToolStripMenuItem.Size = new System.Drawing.Size(289, 22);
            this.duplicateSelectedLegacyToolStripMenuItem.Text = "Duplicate Selected Legacy";
            this.duplicateSelectedLegacyToolStripMenuItem.Click += new System.EventHandler(this.duplicateSelectedLegacyToolStripMenuItem_Click);
            // 
            // exportSelectedLegacyToolStripMenuItem
            // 
            this.exportSelectedLegacyToolStripMenuItem.Name = "exportSelectedLegacyToolStripMenuItem";
            this.exportSelectedLegacyToolStripMenuItem.Size = new System.Drawing.Size(289, 22);
            this.exportSelectedLegacyToolStripMenuItem.Text = "Export Selected Legacy";
            this.exportSelectedLegacyToolStripMenuItem.Click += new System.EventHandler(this.exportSelectedLegacyToolStripMenuItem_Click);
            // 
            // copySelectedLegacyJSONToClipboardToolStripMenuItem
            // 
            this.copySelectedLegacyJSONToClipboardToolStripMenuItem.Name = "copySelectedLegacyJSONToClipboardToolStripMenuItem";
            this.copySelectedLegacyJSONToClipboardToolStripMenuItem.Size = new System.Drawing.Size(289, 22);
            this.copySelectedLegacyJSONToClipboardToolStripMenuItem.Text = "Copy Selected Legacy JSON to Clipboard";
            this.copySelectedLegacyJSONToClipboardToolStripMenuItem.Click += new System.EventHandler(this.copySelectedLegacyJSONToClipboardToolStripMenuItem_Click);
            // 
            // endingsListBox
            // 
            this.endingsListBox.ContextMenuStrip = this.endingContextMenuStrip;
            this.endingsListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.endingsListBox.FormattingEnabled = true;
            this.endingsListBox.Location = new System.Drawing.Point(657, 16);
            this.endingsListBox.Name = "endingsListBox";
            this.endingsListBox.ScrollAlwaysVisible = true;
            this.endingsListBox.Size = new System.Drawing.Size(125, 287);
            this.endingsListBox.Sorted = true;
            this.endingsListBox.TabIndex = 11;
            this.endingsListBox.DoubleClick += new System.EventHandler(this.endingsListBox_DoubleClick);
            this.endingsListBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.endingsListBox_MouseDown);
            // 
            // endingContextMenuStrip
            // 
            this.endingContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchForToolStripMenuItem2,
            this.deleteSelectedEndingToolStripMenuItem,
            this.duplicateSelectedEndingToolStripMenuItem,
            this.exportSelectedEndingToolStripMenuItem,
            this.copySelectedEndingJSONToClipboardToolStripMenuItem});
            this.endingContextMenuStrip.Name = "endingContextMenuStrip";
            this.endingContextMenuStrip.Size = new System.Drawing.Size(290, 114);
            // 
            // searchForToolStripMenuItem2
            // 
            this.searchForToolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.recipesThatCauseThisEndingToolStripMenuItem});
            this.searchForToolStripMenuItem2.Name = "searchForToolStripMenuItem2";
            this.searchForToolStripMenuItem2.Size = new System.Drawing.Size(289, 22);
            this.searchForToolStripMenuItem2.Text = "Search for...";
            // 
            // recipesThatCauseThisEndingToolStripMenuItem
            // 
            this.recipesThatCauseThisEndingToolStripMenuItem.Name = "recipesThatCauseThisEndingToolStripMenuItem";
            this.recipesThatCauseThisEndingToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.recipesThatCauseThisEndingToolStripMenuItem.Text = "Recipes that cause this ending";
            this.recipesThatCauseThisEndingToolStripMenuItem.Click += new System.EventHandler(this.recipesThatCauseThisEndingToolStripMenuItem_Click);
            // 
            // deleteSelectedEndingToolStripMenuItem
            // 
            this.deleteSelectedEndingToolStripMenuItem.Name = "deleteSelectedEndingToolStripMenuItem";
            this.deleteSelectedEndingToolStripMenuItem.Size = new System.Drawing.Size(289, 22);
            this.deleteSelectedEndingToolStripMenuItem.Text = "Delete Selected Ending";
            this.deleteSelectedEndingToolStripMenuItem.Click += new System.EventHandler(this.deleteSelectedEndingToolStripMenuItem_Click);
            // 
            // duplicateSelectedEndingToolStripMenuItem
            // 
            this.duplicateSelectedEndingToolStripMenuItem.Name = "duplicateSelectedEndingToolStripMenuItem";
            this.duplicateSelectedEndingToolStripMenuItem.Size = new System.Drawing.Size(289, 22);
            this.duplicateSelectedEndingToolStripMenuItem.Text = "Duplicate Selected Ending";
            this.duplicateSelectedEndingToolStripMenuItem.Click += new System.EventHandler(this.duplicateSelectedEndingToolStripMenuItem_Click);
            // 
            // exportSelectedEndingToolStripMenuItem
            // 
            this.exportSelectedEndingToolStripMenuItem.Name = "exportSelectedEndingToolStripMenuItem";
            this.exportSelectedEndingToolStripMenuItem.Size = new System.Drawing.Size(289, 22);
            this.exportSelectedEndingToolStripMenuItem.Text = "Export Selected Ending";
            this.exportSelectedEndingToolStripMenuItem.Click += new System.EventHandler(this.exportSelectedEndingToolStripMenuItem_Click);
            // 
            // endingsLabel
            // 
            this.endingsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.endingsLabel.Location = new System.Drawing.Point(657, 0);
            this.endingsLabel.Name = "endingsLabel";
            this.endingsLabel.Size = new System.Drawing.Size(125, 13);
            this.endingsLabel.TabIndex = 12;
            this.endingsLabel.Text = "Endings";
            this.endingsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // verbsListBox
            // 
            this.verbsListBox.ContextMenuStrip = this.verbContextMenuStrip;
            this.verbsListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.verbsListBox.FormattingEnabled = true;
            this.verbsListBox.Location = new System.Drawing.Point(788, 16);
            this.verbsListBox.Name = "verbsListBox";
            this.verbsListBox.ScrollAlwaysVisible = true;
            this.verbsListBox.Size = new System.Drawing.Size(126, 287);
            this.verbsListBox.Sorted = true;
            this.verbsListBox.TabIndex = 13;
            this.verbsListBox.DoubleClick += new System.EventHandler(this.verbsListBox_DoubleClick);
            this.verbsListBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.verbsListBox_MouseDown);
            // 
            // verbContextMenuStrip
            // 
            this.verbContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchForToolStripMenuItem3,
            this.deleteSelectedVerbToolStripMenuItem,
            this.duplicateSelectedVerbToolStripMenuItem,
            this.exportSelectedVerbToolStripMenuItem,
            this.copySelectedVerbJSONToClipboardToolStripMenuItem});
            this.verbContextMenuStrip.Name = "verbContextMenuStrip";
            this.verbContextMenuStrip.Size = new System.Drawing.Size(276, 136);
            // 
            // searchForToolStripMenuItem3
            // 
            this.searchForToolStripMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.recipesThatUseThisVerbToolStripMenuItem,
            this.elementsWithSlotsForThisVerbToolStripMenuItem});
            this.searchForToolStripMenuItem3.Name = "searchForToolStripMenuItem3";
            this.searchForToolStripMenuItem3.Size = new System.Drawing.Size(197, 22);
            this.searchForToolStripMenuItem3.Text = "Search for...";
            // 
            // recipesThatUseThisVerbToolStripMenuItem
            // 
            this.recipesThatUseThisVerbToolStripMenuItem.Name = "recipesThatUseThisVerbToolStripMenuItem";
            this.recipesThatUseThisVerbToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.recipesThatUseThisVerbToolStripMenuItem.Text = "Recipes that use this verb";
            this.recipesThatUseThisVerbToolStripMenuItem.Click += new System.EventHandler(this.recipesThatUseThisVerbToolStripMenuItem_Click);
            // 
            // elementsWithSlotsForThisVerbToolStripMenuItem
            // 
            this.elementsWithSlotsForThisVerbToolStripMenuItem.Name = "elementsWithSlotsForThisVerbToolStripMenuItem";
            this.elementsWithSlotsForThisVerbToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.elementsWithSlotsForThisVerbToolStripMenuItem.Text = "Elements with Slots for this verb";
            this.elementsWithSlotsForThisVerbToolStripMenuItem.Click += new System.EventHandler(this.elementsWithSlotsForThisVerbToolStripMenuItem_Click);
            // 
            // deleteSelectedVerbToolStripMenuItem
            // 
            this.deleteSelectedVerbToolStripMenuItem.Name = "deleteSelectedVerbToolStripMenuItem";
            this.deleteSelectedVerbToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.deleteSelectedVerbToolStripMenuItem.Text = "Delete Selected Verb";
            this.deleteSelectedVerbToolStripMenuItem.Click += new System.EventHandler(this.deleteSelectedVerbToolStripMenuItem_Click);
            // 
            // duplicateSelectedVerbToolStripMenuItem
            // 
            this.duplicateSelectedVerbToolStripMenuItem.Name = "duplicateSelectedVerbToolStripMenuItem";
            this.duplicateSelectedVerbToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.duplicateSelectedVerbToolStripMenuItem.Text = "Duplicate Selected Verb";
            this.duplicateSelectedVerbToolStripMenuItem.Click += new System.EventHandler(this.duplicateSelectedVerbToolStripMenuItem_Click);
            // 
            // exportSelectedVerbToolStripMenuItem
            // 
            this.exportSelectedVerbToolStripMenuItem.Name = "exportSelectedVerbToolStripMenuItem";
            this.exportSelectedVerbToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.exportSelectedVerbToolStripMenuItem.Text = "Export Selected Verb";
            this.exportSelectedVerbToolStripMenuItem.Click += new System.EventHandler(this.exportSelectedVerbToolStripMenuItem_Click);
            // 
            // verbsLabel
            // 
            this.verbsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.verbsLabel.Location = new System.Drawing.Point(788, 0);
            this.verbsLabel.Name = "verbsLabel";
            this.verbsLabel.Size = new System.Drawing.Size(126, 13);
            this.verbsLabel.TabIndex = 14;
            this.verbsLabel.Text = "Verbs";
            this.verbsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripDropDownButton,
            this.newItemToolStripButton,
            this.importToolStripButton,
            this.toolsToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(935, 25);
            this.toolStrip1.TabIndex = 15;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // fileToolStripDropDownButton
            // 
            this.fileToolStripDropDownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fileToolStripDropDownButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveModToolStripMenuItem,
            this.saveToToolStripMenuItem,
            this.editManifestToolStripMenuItem,
            this.reloadContentToolStripMenuItem,
            this.toggleAutosaveToolStripMenuItem,
            this.toggleEditModeToolStripMenuItem});
            this.fileToolStripDropDownButton.Image = ((System.Drawing.Image)(resources.GetObject("fileToolStripDropDownButton.Image")));
            this.fileToolStripDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.fileToolStripDropDownButton.Name = "fileToolStripDropDownButton";
            this.fileToolStripDropDownButton.Size = new System.Drawing.Size(38, 22);
            this.fileToolStripDropDownButton.Text = "File";
            // 
            // saveModToolStripMenuItem
            // 
            this.saveModToolStripMenuItem.Name = "saveModToolStripMenuItem";
            this.saveModToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.saveModToolStripMenuItem.Text = "Save Mod";
            this.saveModToolStripMenuItem.Click += new System.EventHandler(this.saveMod);
            // 
            // saveToToolStripMenuItem
            // 
            this.saveToToolStripMenuItem.Name = "saveToToolStripMenuItem";
            this.saveToToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.saveToToolStripMenuItem.Text = "Save To...";
            this.saveToToolStripMenuItem.Click += new System.EventHandler(this.saveToToolStripMenuItem_Click);
            // 
            // editManifestToolStripMenuItem
            // 
            this.editManifestToolStripMenuItem.Name = "editManifestToolStripMenuItem";
            this.editManifestToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.editManifestToolStripMenuItem.Text = "Edit Manifest";
            this.editManifestToolStripMenuItem.Click += new System.EventHandler(this.editManifestToolStripMenuItem_Click);
            // 
            // reloadContentToolStripMenuItem
            // 
            this.reloadContentToolStripMenuItem.Name = "reloadContentToolStripMenuItem";
            this.reloadContentToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.reloadContentToolStripMenuItem.Text = "Reload Content";
            this.reloadContentToolStripMenuItem.Click += new System.EventHandler(this.reloadContentToolStripMenuItem_Click);
            // 
            // toggleAutosaveToolStripMenuItem
            // 
            this.toggleAutosaveToolStripMenuItem.Name = "toggleAutosaveToolStripMenuItem";
            this.toggleAutosaveToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.toggleAutosaveToolStripMenuItem.Text = "Toggle Autosave";
            this.toggleAutosaveToolStripMenuItem.Click += new System.EventHandler(this.toggleAutosaveToolStripMenuItem_Click);
            // 
            // toggleEditModeToolStripMenuItem
            // 
            this.toggleEditModeToolStripMenuItem.Name = "toggleEditModeToolStripMenuItem";
            this.toggleEditModeToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.toggleEditModeToolStripMenuItem.Text = "Toggle Edit Mode";
            this.toggleEditModeToolStripMenuItem.Click += new System.EventHandler(this.toggleEditModeToolStripMenuItem_Click);
            // 
            // newItemToolStripButton
            // 
            this.newItemToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.newItemToolStripButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aspectToolStripMenuItem,
            this.elementToolStripMenuItem,
            this.recipeToolStripMenuItem,
            this.deckToolStripMenuItem,
            this.legacyToolStripMenuItem,
            this.endingToolStripMenuItem,
            this.verbToolStripMenuItem});
            this.newItemToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("newItemToolStripButton.Image")));
            this.newItemToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newItemToolStripButton.Name = "newItemToolStripButton";
            this.newItemToolStripButton.Size = new System.Drawing.Size(44, 22);
            this.newItemToolStripButton.Text = "New";
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
            // importToolStripButton
            // 
            this.importToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.importToolStripButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aspectToolStripMenuItem1,
            this.elementToolStripMenuItem1,
            this.recipeToolStripMenuItem1,
            this.deckToolStripMenuItem1,
            this.legacyToolStripMenuItem1,
            this.endingToolStripMenuItem1,
            this.verbToolStripMenuItem1});
            this.importToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("importToolStripButton.Image")));
            this.importToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.importToolStripButton.Name = "importToolStripButton";
            this.importToolStripButton.Size = new System.Drawing.Size(56, 22);
            this.importToolStripButton.Text = "Import";
            // 
            // aspectToolStripMenuItem1
            // 
            this.aspectToolStripMenuItem1.Name = "aspectToolStripMenuItem1";
            this.aspectToolStripMenuItem1.Size = new System.Drawing.Size(117, 22);
            this.aspectToolStripMenuItem1.Text = "Aspect";
            this.aspectToolStripMenuItem1.Click += new System.EventHandler(this.aspectToolStripMenuItem1_Click);
            // 
            // elementToolStripMenuItem1
            // 
            this.elementToolStripMenuItem1.Name = "elementToolStripMenuItem1";
            this.elementToolStripMenuItem1.Size = new System.Drawing.Size(117, 22);
            this.elementToolStripMenuItem1.Text = "Element";
            this.elementToolStripMenuItem1.Click += new System.EventHandler(this.elementToolStripMenuItem1_Click);
            // 
            // recipeToolStripMenuItem1
            // 
            this.recipeToolStripMenuItem1.Name = "recipeToolStripMenuItem1";
            this.recipeToolStripMenuItem1.Size = new System.Drawing.Size(117, 22);
            this.recipeToolStripMenuItem1.Text = "Recipe";
            this.recipeToolStripMenuItem1.Click += new System.EventHandler(this.recipeToolStripMenuItem1_Click);
            // 
            // deckToolStripMenuItem1
            // 
            this.deckToolStripMenuItem1.Name = "deckToolStripMenuItem1";
            this.deckToolStripMenuItem1.Size = new System.Drawing.Size(117, 22);
            this.deckToolStripMenuItem1.Text = "Deck";
            this.deckToolStripMenuItem1.Click += new System.EventHandler(this.deckToolStripMenuItem1_Click);
            // 
            // legacyToolStripMenuItem1
            // 
            this.legacyToolStripMenuItem1.Name = "legacyToolStripMenuItem1";
            this.legacyToolStripMenuItem1.Size = new System.Drawing.Size(117, 22);
            this.legacyToolStripMenuItem1.Text = "Legacy";
            this.legacyToolStripMenuItem1.Click += new System.EventHandler(this.legacyToolStripMenuItem1_Click);
            // 
            // endingToolStripMenuItem1
            // 
            this.endingToolStripMenuItem1.Name = "endingToolStripMenuItem1";
            this.endingToolStripMenuItem1.Size = new System.Drawing.Size(117, 22);
            this.endingToolStripMenuItem1.Text = "Ending";
            this.endingToolStripMenuItem1.Click += new System.EventHandler(this.endingToolStripMenuItem1_Click);
            // 
            // verbToolStripMenuItem1
            // 
            this.verbToolStripMenuItem1.Name = "verbToolStripMenuItem1";
            this.verbToolStripMenuItem1.Size = new System.Drawing.Size(117, 22);
            this.verbToolStripMenuItem1.Text = "Verb";
            this.verbToolStripMenuItem1.Click += new System.EventHandler(this.verbToolStripMenuItem1_Click);
            // 
            // toolsToolStripButton
            // 
            this.toolsToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolsToolStripButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.summonGeneratorToolStripMenuItem,
            this.imageImporterToolStripMenuItem});
            this.toolsToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("toolsToolStripButton.Image")));
            this.toolsToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolsToolStripButton.Name = "toolsToolStripButton";
            this.toolsToolStripButton.Size = new System.Drawing.Size(47, 22);
            this.toolsToolStripButton.Text = "Tools";
            // 
            // summonGeneratorToolStripMenuItem
            // 
            this.summonGeneratorToolStripMenuItem.Name = "summonGeneratorToolStripMenuItem";
            this.summonGeneratorToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.summonGeneratorToolStripMenuItem.Text = "Summon Generator";
            this.summonGeneratorToolStripMenuItem.Click += new System.EventHandler(this.summonGeneratorToolStripMenuItem_Click);
            // 
            // imageImporterToolStripMenuItem
            // 
            this.imageImporterToolStripMenuItem.Name = "imageImporterToolStripMenuItem";
            this.imageImporterToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.imageImporterToolStripMenuItem.Text = "Image Importer";
            this.imageImporterToolStripMenuItem.Click += new System.EventHandler(this.imageImporterToolStripMenuItem_Click);
            // 
            // aspetsSearchTextBox
            // 
            this.aspetsSearchTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.aspetsSearchTextBox.Location = new System.Drawing.Point(3, 309);
            this.aspetsSearchTextBox.Name = "aspetsSearchTextBox";
            this.aspetsSearchTextBox.Size = new System.Drawing.Size(124, 20);
            this.aspetsSearchTextBox.TabIndex = 17;
            this.aspetsSearchTextBox.TextChanged += new System.EventHandler(this.aspetsSearchTextBox_TextChanged);
            // 
            // elementsSearchTextBox
            // 
            this.elementsSearchTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.elementsSearchTextBox.Location = new System.Drawing.Point(133, 309);
            this.elementsSearchTextBox.Name = "elementsSearchTextBox";
            this.elementsSearchTextBox.Size = new System.Drawing.Size(125, 20);
            this.elementsSearchTextBox.TabIndex = 18;
            this.elementsSearchTextBox.TextChanged += new System.EventHandler(this.elementsSearchTextBox_TextChanged);
            // 
            // recipesSearchTextBox
            // 
            this.recipesSearchTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.recipesSearchTextBox.Location = new System.Drawing.Point(264, 309);
            this.recipesSearchTextBox.Name = "recipesSearchTextBox";
            this.recipesSearchTextBox.Size = new System.Drawing.Size(125, 20);
            this.recipesSearchTextBox.TabIndex = 19;
            this.recipesSearchTextBox.TextChanged += new System.EventHandler(this.recipesSearchTextBox_TextChanged);
            // 
            // decksSearchTextBox
            // 
            this.decksSearchTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.decksSearchTextBox.Location = new System.Drawing.Point(395, 309);
            this.decksSearchTextBox.Name = "decksSearchTextBox";
            this.decksSearchTextBox.Size = new System.Drawing.Size(125, 20);
            this.decksSearchTextBox.TabIndex = 20;
            this.decksSearchTextBox.TextChanged += new System.EventHandler(this.decksSearchTextBox_TextChanged);
            // 
            // legaciesSearchTextBox
            // 
            this.legaciesSearchTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.legaciesSearchTextBox.Location = new System.Drawing.Point(526, 309);
            this.legaciesSearchTextBox.Name = "legaciesSearchTextBox";
            this.legaciesSearchTextBox.Size = new System.Drawing.Size(125, 20);
            this.legaciesSearchTextBox.TabIndex = 21;
            this.legaciesSearchTextBox.TextChanged += new System.EventHandler(this.legaciesSearchTextBox_TextChanged);
            // 
            // endingsSearchTextBox
            // 
            this.endingsSearchTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.endingsSearchTextBox.Location = new System.Drawing.Point(657, 309);
            this.endingsSearchTextBox.Name = "endingsSearchTextBox";
            this.endingsSearchTextBox.Size = new System.Drawing.Size(125, 20);
            this.endingsSearchTextBox.TabIndex = 22;
            this.endingsSearchTextBox.TextChanged += new System.EventHandler(this.endingsSearchTextBox_TextChanged);
            // 
            // verbsSearchTextBox
            // 
            this.verbsSearchTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.verbsSearchTextBox.Location = new System.Drawing.Point(788, 309);
            this.verbsSearchTextBox.Name = "verbsSearchTextBox";
            this.verbsSearchTextBox.Size = new System.Drawing.Size(126, 20);
            this.verbsSearchTextBox.TabIndex = 23;
            this.verbsSearchTextBox.TextChanged += new System.EventHandler(this.verbsSearchTextBox_TextChanged);
            // 
            // autosaveTimer
            // 
            this.autosaveTimer.Interval = 30000;
            this.autosaveTimer.Tick += new System.EventHandler(this.autosaveTimer_Tick);
            // 
            // ProgressBar
            // 
            this.ProgressBar.Location = new System.Drawing.Point(197, 2);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(726, 23);
            this.ProgressBar.TabIndex = 24;
            this.ProgressBar.Visible = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel1.Controls.Add(this.aspectsListBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.elementsListBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.recipesListBox, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.decksListBox, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.legaciesListBox, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.endingsListBox, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.verbsListBox, 6, 1);
            this.tableLayoutPanel1.Controls.Add(this.endingsLabel, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.verbsSearchTextBox, 6, 2);
            this.tableLayoutPanel1.Controls.Add(this.legaciesLabel, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.endingsSearchTextBox, 5, 2);
            this.tableLayoutPanel1.Controls.Add(this.decksLabel, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.legaciesSearchTextBox, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.recipesLabel, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.elementsLabel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.recipesSearchTextBox, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.aspectsLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.elementsSearchTextBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.aspetsSearchTextBox, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.decksSearchTextBox, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.verbsLabel, 6, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(9, 28);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(917, 332);
            this.tableLayoutPanel1.TabIndex = 25;
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "JSON files|*.json";
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "JSON files|*.json";
            // 
            // copySelectedEndingJSONToClipboardToolStripMenuItem
            // 
            this.copySelectedEndingJSONToClipboardToolStripMenuItem.Name = "copySelectedEndingJSONToClipboardToolStripMenuItem";
            this.copySelectedEndingJSONToClipboardToolStripMenuItem.Size = new System.Drawing.Size(289, 22);
            this.copySelectedEndingJSONToClipboardToolStripMenuItem.Text = "Copy Selected Ending JSON to Clipboard";
            this.copySelectedEndingJSONToClipboardToolStripMenuItem.Click += new System.EventHandler(this.copySelectedEndingJSONToClipboardToolStripMenuItem_Click);
            // 
            // copySelectedVerbJSONToClipboardToolStripMenuItem
            // 
            this.copySelectedVerbJSONToClipboardToolStripMenuItem.Name = "copySelectedVerbJSONToClipboardToolStripMenuItem";
            this.copySelectedVerbJSONToClipboardToolStripMenuItem.Size = new System.Drawing.Size(275, 22);
            this.copySelectedVerbJSONToClipboardToolStripMenuItem.Text = "Copy Selected Verb JSON to Clipboard";
            this.copySelectedVerbJSONToClipboardToolStripMenuItem.Click += new System.EventHandler(this.copySelectedVerbJSONToClipboardToolStripMenuItem_Click);
            // 
            // ModViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 369);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.ProgressBar);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ModViewer";
            this.Text = "Carcass Spark";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ModViewer_FormClosed);
            this.Shown += new System.EventHandler(this.ModViewer_Shown);
            this.aspectContextMenuStrip.ResumeLayout(false);
            this.elementContextMenuStrip.ResumeLayout(false);
            this.recipeContextMenuStrip.ResumeLayout(false);
            this.deckContextMenuStrip.ResumeLayout(false);
            this.legacyContextMenuStrip.ResumeLayout(false);
            this.endingContextMenuStrip.ResumeLayout(false);
            this.verbContextMenuStrip.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
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
        private System.Windows.Forms.ToolStripMenuItem editManifestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveModToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reloadContentToolStripMenuItem;
        private System.Windows.Forms.TextBox aspetsSearchTextBox;
        private System.Windows.Forms.TextBox elementsSearchTextBox;
        private System.Windows.Forms.TextBox recipesSearchTextBox;
        private System.Windows.Forms.TextBox decksSearchTextBox;
        private System.Windows.Forms.TextBox legaciesSearchTextBox;
        private System.Windows.Forms.TextBox endingsSearchTextBox;
        private System.Windows.Forms.TextBox verbsSearchTextBox;
        private System.Windows.Forms.ContextMenuStrip aspectContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem elementsWithThisAspectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recipesRequiringThisAspectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem slotsRequiringThisAspectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem elementsThatReactWithThisAspectToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip elementContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem recipesThatProduceThisAspectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem elementsThatDecayIntoThisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem elementsThatXtriggerIntoThisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recipesThatRequireThisElementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recipesThatProduceThisElementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem decksThatContainThisElementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem legaciesThatStartWithThisElementToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip recipeContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem searchForToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recipesThatLinkToThisRecipeToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip deckContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem searchForToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem recipesThatDrawFromThisDeckToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip legacyContextMenuStrip;
        private System.Windows.Forms.ContextMenuStrip endingContextMenuStrip;
        private System.Windows.Forms.ContextMenuStrip verbContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem searchForToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem recipesThatCauseThisEndingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchForToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem recipesThatUseThisVerbToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem elementsWithSlotsThatRequireThisElementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem elementsWithSlotsForThisVerbToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewAsFlowchartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toggleAutosaveToolStripMenuItem;
        private System.Windows.Forms.Timer autosaveTimer;
        private System.Windows.Forms.FolderBrowserDialog saveToFolderBrowserDialog;
        private System.Windows.Forms.ToolStripDropDownButton newItemToolStripButton;
        private System.Windows.Forms.ToolStripMenuItem aspectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem elementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recipeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deckToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem legacyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem endingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verbToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolsToolStripButton;
        private System.Windows.Forms.ToolStripMenuItem summonGeneratorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteSelectedAspectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteSelectedElementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteSelectedRecipeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteSelectedDeckToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteSelectedLegacyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteSelectedEndingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteSelectedVerbToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toggleEditModeToolStripMenuItem;
        private System.Windows.Forms.ProgressBar ProgressBar;
        private System.Windows.Forms.ToolStripMenuItem duplicateSelectedAspectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem duplicateSelectedElementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem duplicateSelectedRecipeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem duplicateSelectedDeckToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem duplicateSelectedLegacyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem duplicateSelectedEndingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem duplicateSelectedVerbToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolStripMenuItem imageImporterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportSelectedAspectToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.ToolStripMenuItem exportSelectedElementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportSelectedRecipeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportSelectedDeckToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportSelectedLegacyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportSelectedEndingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportSelectedVerbToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton importToolStripButton;
        private System.Windows.Forms.ToolStripMenuItem aspectToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem elementToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem recipeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deckToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem legacyToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem endingToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem verbToolStripMenuItem1;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ToolStripMenuItem copyAspectJSONToClipboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyElementJSONToClipboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyRecipeJSONToClipboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyDeckJSONToClipboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copySelectedLegacyJSONToClipboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copySelectedEndingJSONToClipboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copySelectedVerbJSONToClipboardToolStripMenuItem;
    }
}

