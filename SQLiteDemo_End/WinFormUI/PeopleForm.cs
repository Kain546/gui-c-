public partial class PeopleForm : Form
{
    List<PersonModel> people = new List<PersonModel>();

    public PeopleForm()
    {
        InitializeComponent();

        firstNameText.TabIndex = 1;
    lastNameText.TabIndex = 2;
    ageTextbox.TabIndex = 3;
    addPersonButton.TabIndex = 4;
    refreshListButton.TabIndex = 5;
    listPeopleListBox.TabIndex = 6;


        LoadPeopleList();
    }
   private void InitializeComponent()
{
    this.firstNameLabel = new System.Windows.Forms.Label();
    this.lastNameLabel = new System.Windows.Forms.Label();
    this.firstNameText = new System.Windows.Forms.TextBox();
    this.lastNameText = new System.Windows.Forms.TextBox();
    this.addPersonHeader = new System.Windows.Forms.Label();
    this.listPeopleHeader = new System.Windows.Forms.Label();
    this.listPeopleListBox = new System.Windows.Forms.ListBox();
    this.addPersonButton = new System.Windows.Forms.Button();
    this.refreshListButton = new System.Windows.Forms.Button();
    // ADD THESE TWO LINES:
    this.ageLabel = new System.Windows.Forms.Label();
    this.ageTextbox = new System.Windows.Forms.TextBox();
    this.SuspendLayout();
    // 
    // firstNameLabel
    // 
    this.firstNameLabel.AutoSize = true;
    this.firstNameLabel.Location = new System.Drawing.Point(46, 101);
    this.firstNameLabel.Name = "firstNameLabel";
    this.firstNameLabel.Size = new System.Drawing.Size(134, 33);
    this.firstNameLabel.TabIndex = 0;
    this.firstNameLabel.Text = "First Name";
    // 
    // lastNameLabel
    // 
    this.lastNameLabel.AutoSize = true;
    this.lastNameLabel.Location = new System.Drawing.Point(46, 190);
    this.lastNameLabel.Name = "lastNameLabel";
    this.lastNameLabel.Size = new System.Drawing.Size(131, 33);
    this.lastNameLabel.TabIndex = 1;
    this.lastNameLabel.Text = "Last Name";
    // 
    // firstNameText
    // 
    this.firstNameText.Location = new System.Drawing.Point(52, 137);
    this.firstNameText.Name = "firstNameText";
    this.firstNameText.Size = new System.Drawing.Size(234, 40);
    this.firstNameText.TabIndex = 1;  // Changed to 1
    // 
    // lastNameText
    // 
    this.lastNameText.Location = new System.Drawing.Point(52, 226);
    this.lastNameText.Name = "lastNameText";
    this.lastNameText.Size = new System.Drawing.Size(234, 40);
    this.lastNameText.TabIndex = 2;  // Changed to 2
    // 
    // addPersonHeader
    // 
    this.addPersonHeader.AutoSize = true;
    this.addPersonHeader.Font = new System.Drawing.Font("Open Sans SemiBold", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    this.addPersonHeader.Location = new System.Drawing.Point(32, 42);
    this.addPersonHeader.Name = "addPersonHeader";
    this.addPersonHeader.Size = new System.Drawing.Size(213, 47);
    this.addPersonHeader.TabIndex = 4;
    this.addPersonHeader.Text = "Add Person";
    // 
    // listPeopleHeader
    // 
    this.listPeopleHeader.AutoSize = true;
    this.listPeopleHeader.Font = new System.Drawing.Font("Open Sans SemiBold", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    this.listPeopleHeader.Location = new System.Drawing.Point(380, 42);
    this.listPeopleHeader.Name = "listPeopleHeader";
    this.listPeopleHeader.Size = new System.Drawing.Size(204, 47);
    this.listPeopleHeader.TabIndex = 5;
    this.listPeopleHeader.Text = "List People";
    // 
    // listPeopleListBox
    // 
    this.listPeopleListBox.FormattingEnabled = true;
    this.listPeopleListBox.ItemHeight = 33;
    this.listPeopleListBox.Location = new System.Drawing.Point(388, 107);
    this.listPeopleListBox.Name = "listPeopleListBox";
    this.listPeopleListBox.Size = new System.Drawing.Size(332, 367);
    this.listPeopleListBox.TabIndex = 6;
    // 
    // addPersonButton
    // 
    this.addPersonButton.Location = new System.Drawing.Point(52, 380);
    this.addPersonButton.Name = "addPersonButton";
    this.addPersonButton.Size = new System.Drawing.Size(234, 69);
    this.addPersonButton.TabIndex = 4;  // Changed to 4
    this.addPersonButton.Text = "Add Person";
    this.addPersonButton.UseVisualStyleBackColor = true;
    this.addPersonButton.Click += new System.EventHandler(this.addPersonButton_Click);
    // 
    // refreshListButton
    // 
    this.refreshListButton.Location = new System.Drawing.Point(52, 467);
    this.refreshListButton.Name = "refreshListButton";
    this.refreshListButton.Size = new System.Drawing.Size(234, 69);
    this.refreshListButton.TabIndex = 5;  // Changed to 5
    this.refreshListButton.Text = "Refresh List";
    this.refreshListButton.UseVisualStyleBackColor = true;
    this.refreshListButton.Click += new System.EventHandler(this.refreshListButton_Click);
    // 
    // ageLabel
    // 
    this.ageLabel.AutoSize = true;
    this.ageLabel.Location = new System.Drawing.Point(46, 279);
    this.ageLabel.Name = "ageLabel";
    this.ageLabel.Size = new System.Drawing.Size(58, 33);
    this.ageLabel.TabIndex = 8;
    this.ageLabel.Text = "Age";
    // 
    // ageTextbox
    // 
    this.ageTextbox.Location = new System.Drawing.Point(52, 315);
    this.ageTextbox.Name = "ageTextbox";
    this.ageTextbox.Size = new System.Drawing.Size(100, 40);
    this.ageTextbox.TabIndex = 3;  // Set to 3 for proper tab order
    // 
    // PeopleForm
    // 
    this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 33F);
    this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
    this.ClientSize = new System.Drawing.Size(754, 560);  // Increased height from 492 to 560
    this.Controls.Add(this.ageTextbox);
    this.Controls.Add(this.ageLabel);
    this.Controls.Add(this.refreshListButton);
    this.Controls.Add(this.addPersonButton);
    this.Controls.Add(this.listPeopleListBox);
    this.Controls.Add(this.listPeopleHeader);
    this.Controls.Add(this.addPersonHeader);
    this.Controls.Add(this.lastNameText);
    this.Controls.Add(this.firstNameText);
    this.Controls.Add(this.lastNameLabel);
    this.Controls.Add(this.firstNameLabel);
    this.Font = new System.Drawing.Font("Open Sans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    this.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
    this.Name = "PeopleForm";
    this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
    this.Text = "SQLite Demo Form by Tim Corey";
    this.ResumeLayout(false);
    this.PerformLayout();
}
    private void LoadPeopleList()
    {
        people = SqliteDataAccess.LoadPeople();
        WireUpPeopleList();
    }

    private void WireUpPeopleList()
    {
        listPeopleListBox.DataSource = null;
        listPeopleListBox.DataSource = people;
        listPeopleListBox.DisplayMember = "FullName";
    }

   

    private void addPersonButton_Click(object sender, EventArgs e)
{
    // Validate input
    if (!int.TryParse(ageTextbox.Text, out int ageValue))
    {
        MessageBox.Show("Please enter a valid number for age");
        ageTextbox.Focus();
        return;
    }
    
    // Additional validation
    if (string.IsNullOrWhiteSpace(firstNameText.Text))
    {
        MessageBox.Show("Please enter a first name");
        firstNameText.Focus();
        return;
    }
    
    if (string.IsNullOrWhiteSpace(lastNameText.Text))
    {
        MessageBox.Show("Please enter a last name");
        lastNameText.Focus();
        return;
    }
    
    PersonModel p = new PersonModel();
    p.FirstName = firstNameText.Text.Trim();
    p.LastName = lastNameText.Text.Trim();
    p.Age = ageValue;
    
    SqliteDataAccess.SavePerson(p);
    
    // Clear fields
    firstNameText.Text = "";
    lastNameText.Text = "";
    ageTextbox.Text = "";
    
    // Refresh the list (REMOVE THE DUPLICATE CALL)
    LoadPeopleList();
    
    // Set focus back to first field
    firstNameText.Focus();
}
