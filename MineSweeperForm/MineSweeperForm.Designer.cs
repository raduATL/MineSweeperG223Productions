namespace Minesweeper
{
    partial class MinesweeperForm
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
            this.tileGrid = new Minesweeper.MinesweeperForm.TileGrid();
            this.gameButton = new System.Windows.Forms.PictureBox();
            this.flagCounter = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip_Game = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip_Game_New = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip_Game_CTRL_N = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip_Game_Beginner = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip_Game_Intermediate = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip_Game_Expert = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip_Game_Exit = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.gameButton)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tileGrid
            // 
            this.tileGrid.Location = new System.Drawing.Point(12, 54);
            this.tileGrid.Name = "tileGrid";
            this.tileGrid.Size = new System.Drawing.Size(340, 261);
            this.tileGrid.TabIndex = 0;
            // 
            // gameButton
            // 
            this.gameButton.BackgroundImage = global::MineSweeperForm.Properties.Resources.GameButton;
            this.gameButton.Location = new System.Drawing.Point(136, 23);
            this.gameButton.Name = "gameButton";
            this.gameButton.Size = new System.Drawing.Size(38, 25);
            this.gameButton.TabIndex = 0;
            this.gameButton.TabStop = false;
            this.gameButton.Click += new System.EventHandler(this.LoadGame);
            // 
            // flagCounter
            // 
            this.flagCounter.AutoSize = true;
            this.flagCounter.ForeColor = System.Drawing.Color.Black;
            this.flagCounter.Location = new System.Drawing.Point(212, 12);
            this.flagCounter.Name = "flagCounter";
            this.flagCounter.Size = new System.Drawing.Size(0, 13);
            this.flagCounter.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStrip_Game});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(360, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip_Game
            // 
            this.menuStrip_Game.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStrip_Game_New,
            this.menuStrip_Game_Beginner,
            this.menuStrip_Game_Intermediate,
            this.menuStrip_Game_Expert,
            this.menuStrip_Game_Exit});
            this.menuStrip_Game.Name = "menuStrip_Game";
            this.menuStrip_Game.Size = new System.Drawing.Size(50, 20);
            this.menuStrip_Game.Tag = "Game";
            this.menuStrip_Game.Text = "Game";
            // 
            // menuStrip_Game_New
            // 
            this.menuStrip_Game_New.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStrip_Game_CTRL_N});
            this.menuStrip_Game_New.Name = "menuStrip_Game_New";
            this.menuStrip_Game_New.Size = new System.Drawing.Size(141, 22);
            this.menuStrip_Game_New.Tag = "New";
            this.menuStrip_Game_New.Text = "New";
            this.menuStrip_Game_New.Click += new System.EventHandler(this.MenuStrip_Game_New_Click);
            // 
            // menuStrip_Game_CTRL_N
            // 
            this.menuStrip_Game_CTRL_N.Name = "menuStrip_Game_CTRL_N";
            this.menuStrip_Game_CTRL_N.Size = new System.Drawing.Size(119, 22);
            this.menuStrip_Game_CTRL_N.Text = "CTRL+N";
            // 
            // menuStrip_Game_Beginner
            // 
            this.menuStrip_Game_Beginner.Name = "menuStrip_Game_Beginner";
            this.menuStrip_Game_Beginner.Size = new System.Drawing.Size(141, 22);
            this.menuStrip_Game_Beginner.Tag = "Beginner";
            this.menuStrip_Game_Beginner.Text = "Beginner";
            this.menuStrip_Game_Beginner.Click += new System.EventHandler(this.MenuStrip_Game_DifficultyChanged);
            // 
            // menuStrip_Game_Intermediate
            // 
            this.menuStrip_Game_Intermediate.Name = "menuStrip_Game_Intermediate";
            this.menuStrip_Game_Intermediate.Size = new System.Drawing.Size(141, 22);
            this.menuStrip_Game_Intermediate.Tag = "Intermediate";
            this.menuStrip_Game_Intermediate.Text = "Intermediate";
            this.menuStrip_Game_Intermediate.Click += new System.EventHandler(this.MenuStrip_Game_DifficultyChanged);
            // 
            // menuStrip_Game_Expert
            // 
            this.menuStrip_Game_Expert.Name = "menuStrip_Game_Expert";
            this.menuStrip_Game_Expert.Size = new System.Drawing.Size(141, 22);
            this.menuStrip_Game_Expert.Tag = "Expert";
            this.menuStrip_Game_Expert.Text = "Expert";
            this.menuStrip_Game_Expert.Click += new System.EventHandler(this.MenuStrip_Game_DifficultyChanged);
            // 
            // menuStrip_Game_Exit
            // 
            this.menuStrip_Game_Exit.Name = "menuStrip_Game_Exit";
            this.menuStrip_Game_Exit.Size = new System.Drawing.Size(141, 22);
            this.menuStrip_Game_Exit.Tag = "Exit";
            this.menuStrip_Game_Exit.Text = "Exit";
            this.menuStrip_Game_Exit.Click += new System.EventHandler(this.MenuStrip_Game_Exit_Click);
            // 
            // MinesweeperForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(360, 340);
            this.Controls.Add(this.gameButton);
            this.Controls.Add(this.flagCounter);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.tileGrid);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MinesweeperForm";
            this.Text = "Minesweeper";
            ((System.ComponentModel.ISupportInitialize)(this.gameButton)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TileGrid tileGrid;
        private System.Windows.Forms.PictureBox gameButton;
        private System.Windows.Forms.Label flagCounter;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuStrip_Game;
        private System.Windows.Forms.ToolStripMenuItem menuStrip_Game_New;
        private System.Windows.Forms.ToolStripMenuItem menuStrip_Game_CTRL_N;
        private System.Windows.Forms.ToolStripMenuItem menuStrip_Game_Beginner;
        private System.Windows.Forms.ToolStripMenuItem menuStrip_Game_Intermediate;
        private System.Windows.Forms.ToolStripMenuItem menuStrip_Game_Expert;
        private System.Windows.Forms.ToolStripMenuItem menuStrip_Game_Exit;
    }
}

