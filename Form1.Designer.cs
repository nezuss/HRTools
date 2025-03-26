namespace Assiment4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            company_name_input = new TextBox();
            company_name_label = new Label();
            company_address_label = new Label();
            company_address_input = new TextBox();
            company_phone_label = new Label();
            company_phone_input = new TextBox();
            company_email_label = new Label();
            company_email_input = new TextBox();
            company_comments_label = new Label();
            company_comments_input = new TextBox();
            company_rating_label = new Label();
            company_rating_input = new TextBox();
            company_expertise_label = new Label();
            company_expertise_input = new TextBox();
            companies_content = new DataGridView();
            company_id_grid = new DataGridViewTextBoxColumn();
            company_name_grid = new DataGridViewTextBoxColumn();
            company_address_grid = new DataGridViewTextBoxColumn();
            company_email_grid = new DataGridViewTextBoxColumn();
            company_phone_grid = new DataGridViewTextBoxColumn();
            company_expertise_grid = new DataGridViewTextBoxColumn();
            company_rating_grid = new DataGridViewTextBoxColumn();
            company_comments_grid = new DataGridViewTextBoxColumn();
            button_save = new Button();
            button_new = new Button();
            button_delete = new Button();
            button_with_same_name_expertise = new Button();
            button_bigger_raiting = new Button();
            button_equal_raiting = new Button();
            button_less_raiting = new Button();
            search_input = new TextBox();
            error_label = new Label();
            company_id_label = new Label();
            company_id_input = new TextBox();
            ((System.ComponentModel.ISupportInitialize)companies_content).BeginInit();
            SuspendLayout();
            // 
            // company_name_input
            // 
            company_name_input.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            company_name_input.Enabled = false;
            company_name_input.Location = new Point(650, 120);
            company_name_input.Name = "company_name_input";
            company_name_input.Size = new Size(149, 23);
            company_name_input.TabIndex = 0;
            // 
            // company_name_label
            // 
            company_name_label.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            company_name_label.AutoSize = true;
            company_name_label.Location = new Point(650, 102);
            company_name_label.Name = "company_name_label";
            company_name_label.Size = new Size(39, 15);
            company_name_label.TabIndex = 1;
            company_name_label.Text = "Name";
            // 
            // company_address_label
            // 
            company_address_label.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            company_address_label.AutoSize = true;
            company_address_label.Location = new Point(650, 146);
            company_address_label.Name = "company_address_label";
            company_address_label.Size = new Size(49, 15);
            company_address_label.TabIndex = 3;
            company_address_label.Text = "Address";
            // 
            // company_address_input
            // 
            company_address_input.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            company_address_input.Enabled = false;
            company_address_input.Location = new Point(650, 164);
            company_address_input.Name = "company_address_input";
            company_address_input.Size = new Size(149, 23);
            company_address_input.TabIndex = 2;
            // 
            // company_phone_label
            // 
            company_phone_label.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            company_phone_label.AutoSize = true;
            company_phone_label.Location = new Point(650, 234);
            company_phone_label.Name = "company_phone_label";
            company_phone_label.Size = new Size(41, 15);
            company_phone_label.TabIndex = 7;
            company_phone_label.Text = "Phone";
            // 
            // company_phone_input
            // 
            company_phone_input.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            company_phone_input.Enabled = false;
            company_phone_input.Location = new Point(650, 252);
            company_phone_input.Name = "company_phone_input";
            company_phone_input.Size = new Size(149, 23);
            company_phone_input.TabIndex = 6;
            // 
            // company_email_label
            // 
            company_email_label.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            company_email_label.AutoSize = true;
            company_email_label.Location = new Point(650, 190);
            company_email_label.Name = "company_email_label";
            company_email_label.Size = new Size(36, 15);
            company_email_label.TabIndex = 5;
            company_email_label.Text = "Email";
            // 
            // company_email_input
            // 
            company_email_input.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            company_email_input.Enabled = false;
            company_email_input.Location = new Point(650, 208);
            company_email_input.Name = "company_email_input";
            company_email_input.Size = new Size(149, 23);
            company_email_input.TabIndex = 4;
            // 
            // company_comments_label
            // 
            company_comments_label.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            company_comments_label.AutoSize = true;
            company_comments_label.Location = new Point(650, 366);
            company_comments_label.Name = "company_comments_label";
            company_comments_label.Size = new Size(66, 15);
            company_comments_label.TabIndex = 13;
            company_comments_label.Text = "Comments";
            // 
            // company_comments_input
            // 
            company_comments_input.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            company_comments_input.Enabled = false;
            company_comments_input.Location = new Point(650, 384);
            company_comments_input.MaxLength = 0;
            company_comments_input.Multiline = true;
            company_comments_input.Name = "company_comments_input";
            company_comments_input.Size = new Size(149, 67);
            company_comments_input.TabIndex = 12;
            company_comments_input.KeyPress += company_comments_input_KeyPress;
            // 
            // company_rating_label
            // 
            company_rating_label.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            company_rating_label.AutoSize = true;
            company_rating_label.Location = new Point(650, 322);
            company_rating_label.Name = "company_rating_label";
            company_rating_label.Size = new Size(41, 15);
            company_rating_label.TabIndex = 11;
            company_rating_label.Text = "Rating";
            // 
            // company_rating_input
            // 
            company_rating_input.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            company_rating_input.Enabled = false;
            company_rating_input.Location = new Point(650, 340);
            company_rating_input.Name = "company_rating_input";
            company_rating_input.Size = new Size(149, 23);
            company_rating_input.TabIndex = 10;
            // 
            // company_expertise_label
            // 
            company_expertise_label.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            company_expertise_label.AutoSize = true;
            company_expertise_label.Location = new Point(650, 278);
            company_expertise_label.Name = "company_expertise_label";
            company_expertise_label.Size = new Size(54, 15);
            company_expertise_label.TabIndex = 9;
            company_expertise_label.Text = "Expertise";
            // 
            // company_expertise_input
            // 
            company_expertise_input.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            company_expertise_input.Enabled = false;
            company_expertise_input.Location = new Point(650, 296);
            company_expertise_input.Name = "company_expertise_input";
            company_expertise_input.Size = new Size(149, 23);
            company_expertise_input.TabIndex = 8;
            // 
            // companies_content
            // 
            companies_content.AllowUserToAddRows = false;
            companies_content.AllowUserToDeleteRows = false;
            companies_content.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            companies_content.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            companies_content.Columns.AddRange(new DataGridViewColumn[] { company_id_grid, company_name_grid, company_address_grid, company_email_grid, company_phone_grid, company_expertise_grid, company_rating_grid, company_comments_grid });
            companies_content.EditMode = DataGridViewEditMode.EditProgrammatically;
            companies_content.Location = new Point(0, 51);
            companies_content.Name = "companies_content";
            companies_content.Size = new Size(576, 485);
            companies_content.TabIndex = 14;
            companies_content.RowEnter += companies_content_RowEnter;
            // 
            // company_id_grid
            // 
            company_id_grid.HeaderText = "Id";
            company_id_grid.Name = "company_id_grid";
            // 
            // company_name_grid
            // 
            company_name_grid.HeaderText = "Name";
            company_name_grid.Name = "company_name_grid";
            // 
            // company_address_grid
            // 
            company_address_grid.HeaderText = "Address";
            company_address_grid.Name = "company_address_grid";
            // 
            // company_email_grid
            // 
            company_email_grid.HeaderText = "Email";
            company_email_grid.Name = "company_email_grid";
            // 
            // company_phone_grid
            // 
            company_phone_grid.HeaderText = "Phone";
            company_phone_grid.Name = "company_phone_grid";
            // 
            // company_expertise_grid
            // 
            company_expertise_grid.HeaderText = "Expertise";
            company_expertise_grid.Name = "company_expertise_grid";
            // 
            // company_rating_grid
            // 
            company_rating_grid.HeaderText = "Rating";
            company_rating_grid.Name = "company_rating_grid";
            // 
            // company_comments_grid
            // 
            company_comments_grid.HeaderText = "Comments";
            company_comments_grid.Name = "company_comments_grid";
            // 
            // button_save
            // 
            button_save.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_save.Location = new Point(683, 460);
            button_save.Name = "button_save";
            button_save.Size = new Size(75, 23);
            button_save.TabIndex = 15;
            button_save.Text = "Save";
            button_save.UseVisualStyleBackColor = true;
            button_save.Click += button_save_Click;
            // 
            // button_new
            // 
            button_new.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_new.Location = new Point(602, 460);
            button_new.Name = "button_new";
            button_new.Size = new Size(75, 23);
            button_new.TabIndex = 16;
            button_new.Text = "New";
            button_new.UseVisualStyleBackColor = true;
            button_new.Click += button_new_Click;
            // 
            // button_delete
            // 
            button_delete.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_delete.Enabled = false;
            button_delete.Location = new Point(764, 460);
            button_delete.Name = "button_delete";
            button_delete.Size = new Size(75, 23);
            button_delete.TabIndex = 17;
            button_delete.Text = "Delete";
            button_delete.UseVisualStyleBackColor = true;
            button_delete.Click += button_delete_Click;
            // 
            // button_with_same_name_expertise
            // 
            button_with_same_name_expertise.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button_with_same_name_expertise.Location = new Point(310, 13);
            button_with_same_name_expertise.Name = "button_with_same_name_expertise";
            button_with_same_name_expertise.Size = new Size(162, 23);
            button_with_same_name_expertise.TabIndex = 18;
            button_with_same_name_expertise.Text = "Same - Name, Expertise";
            button_with_same_name_expertise.UseVisualStyleBackColor = true;
            button_with_same_name_expertise.Click += button_with_same_name_expertise_Click;
            // 
            // button_bigger_raiting
            // 
            button_bigger_raiting.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button_bigger_raiting.Location = new Point(478, 13);
            button_bigger_raiting.Name = "button_bigger_raiting";
            button_bigger_raiting.Size = new Size(117, 23);
            button_bigger_raiting.TabIndex = 19;
            button_bigger_raiting.Text = "By bigger raiting";
            button_bigger_raiting.UseVisualStyleBackColor = true;
            button_bigger_raiting.Click += button_bigger_raiting_Click;
            // 
            // button_equal_raiting
            // 
            button_equal_raiting.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button_equal_raiting.Location = new Point(715, 13);
            button_equal_raiting.Name = "button_equal_raiting";
            button_equal_raiting.Size = new Size(124, 23);
            button_equal_raiting.TabIndex = 21;
            button_equal_raiting.Text = "By equal rating";
            button_equal_raiting.UseVisualStyleBackColor = true;
            button_equal_raiting.Click += button_equal_raiting_Click;
            // 
            // button_less_raiting
            // 
            button_less_raiting.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button_less_raiting.Location = new Point(601, 13);
            button_less_raiting.Name = "button_less_raiting";
            button_less_raiting.Size = new Size(108, 23);
            button_less_raiting.TabIndex = 20;
            button_less_raiting.Text = "By less raiting";
            button_less_raiting.UseVisualStyleBackColor = true;
            button_less_raiting.Click += button_less_raiting_Click;
            // 
            // search_input
            // 
            search_input.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            search_input.Location = new Point(0, 13);
            search_input.Name = "search_input";
            search_input.Size = new Size(304, 23);
            search_input.TabIndex = 22;
            search_input.TextChanged += search_input_TextChanged;
            // 
            // error_label
            // 
            error_label.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            error_label.AutoSize = true;
            error_label.ForeColor = Color.IndianRed;
            error_label.Location = new Point(601, 494);
            error_label.MaximumSize = new Size(240, 30);
            error_label.MinimumSize = new Size(240, 30);
            error_label.Name = "error_label";
            error_label.Size = new Size(240, 30);
            error_label.TabIndex = 23;
            error_label.Text = "Error line 45";
            error_label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // company_id_label
            // 
            company_id_label.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            company_id_label.AutoSize = true;
            company_id_label.Location = new Point(650, 58);
            company_id_label.Name = "company_id_label";
            company_id_label.Size = new Size(17, 15);
            company_id_label.TabIndex = 25;
            company_id_label.Text = "Id";
            // 
            // company_id_input
            // 
            company_id_input.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            company_id_input.Enabled = false;
            company_id_input.Location = new Point(650, 76);
            company_id_input.Name = "company_id_input";
            company_id_input.Size = new Size(149, 23);
            company_id_input.TabIndex = 24;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(862, 536);
            Controls.Add(company_id_label);
            Controls.Add(company_id_input);
            Controls.Add(error_label);
            Controls.Add(search_input);
            Controls.Add(button_equal_raiting);
            Controls.Add(button_less_raiting);
            Controls.Add(button_bigger_raiting);
            Controls.Add(button_with_same_name_expertise);
            Controls.Add(button_delete);
            Controls.Add(button_new);
            Controls.Add(button_save);
            Controls.Add(companies_content);
            Controls.Add(company_comments_label);
            Controls.Add(company_comments_input);
            Controls.Add(company_rating_label);
            Controls.Add(company_rating_input);
            Controls.Add(company_expertise_label);
            Controls.Add(company_expertise_input);
            Controls.Add(company_phone_label);
            Controls.Add(company_phone_input);
            Controls.Add(company_email_label);
            Controls.Add(company_email_input);
            Controls.Add(company_address_label);
            Controls.Add(company_address_input);
            Controls.Add(company_name_label);
            Controls.Add(company_name_input);
            MinimumSize = new Size(878, 575);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)companies_content).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox company_name_input;
        private Label company_name_label;
        private Label company_address_label;
        private TextBox company_address_input;
        private Label company_phone_label;
        private TextBox company_phone_input;
        private Label company_email_label;
        private TextBox company_email_input;
        private Label company_comments_label;
        private TextBox company_comments_input;
        private Label company_rating_label;
        private TextBox company_rating_input;
        private Label company_expertise_label;
        private TextBox company_expertise_input;
        private DataGridView companies_content;
        private Button button_save;
        private Button button_new;
        private Button button_delete;
        private Button button_with_same_name_expertise;
        private Button button_bigger_raiting;
        private Button button_equal_raiting;
        private Button button_less_raiting;
        private TextBox search_input;
        private Label error_label;
        private Label company_id_label;
        private TextBox company_id_input;
        private DataGridViewTextBoxColumn company_id_grid;
        private DataGridViewTextBoxColumn company_name_grid;
        private DataGridViewTextBoxColumn company_address_grid;
        private DataGridViewTextBoxColumn company_email_grid;
        private DataGridViewTextBoxColumn company_phone_grid;
        private DataGridViewTextBoxColumn company_expertise_grid;
        private DataGridViewTextBoxColumn company_rating_grid;
        private DataGridViewTextBoxColumn company_comments_grid;
    }
}
