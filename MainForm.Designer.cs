namespace Salesforce2SendGrid
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.scMain = new System.Windows.Forms.SplitContainer();
            this.dgvSource = new System.Windows.Forms.DataGridView();
            this.scRight = new System.Windows.Forms.SplitContainer();
            this.pbArrow = new System.Windows.Forms.PictureBox();
            this.btImport = new System.Windows.Forms.Button();
            this.dgvDestination = new System.Windows.Forms.DataGridView();
            this.contactBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salesforceDataSet = new Salesforce2SendGrid.SalesforceDataSet();
            this.recipientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sendGridDataSet = new Salesforce2SendGrid.SendGridDataSet();
            this.contactTableAdapter = new Salesforce2SendGrid.SalesforceDataSetTableAdapters.ContactTableAdapter();
            this.recipientsTableAdapter = new Salesforce2SendGrid.SendGridDataSetTableAdapters.RecipientsTableAdapter();
            this.btReload = new System.Windows.Forms.Button();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assistantNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leadSourceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ownerIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdByIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastModifiedDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastModifiedByIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.systemModstampDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastActivityDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastCURequestDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastCUUpdateDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastViewedDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastReferencedDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailBouncedReasonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailBouncedDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isEmailBouncedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.photoUrlDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jigsawDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jigsawContactIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cleanStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.levelcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.languagescDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdAtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastClickedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastEmailedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastOpenedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updatedAtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).BeginInit();
            this.scMain.Panel1.SuspendLayout();
            this.scMain.Panel2.SuspendLayout();
            this.scMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scRight)).BeginInit();
            this.scRight.Panel1.SuspendLayout();
            this.scRight.Panel2.SuspendLayout();
            this.scRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbArrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDestination)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesforceDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recipientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sendGridDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // scMain
            // 
            this.scMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.scMain.Location = new System.Drawing.Point(20, 49);
            this.scMain.Name = "scMain";
            // 
            // scMain.Panel1
            // 
            this.scMain.Panel1.Controls.Add(this.dgvSource);
            // 
            // scMain.Panel2
            // 
            this.scMain.Panel2.Controls.Add(this.scRight);
            this.scMain.Size = new System.Drawing.Size(1097, 428);
            this.scMain.SplitterDistance = 481;
            this.scMain.TabIndex = 7;
            // 
            // dgvSource
            // 
            this.dgvSource.AllowUserToAddRows = false;
            this.dgvSource.AllowUserToDeleteRows = false;
            this.dgvSource.AllowUserToResizeRows = false;
            this.dgvSource.AutoGenerateColumns = false;
            this.dgvSource.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSource.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lastNameDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.departmentDataGridViewTextBoxColumn,
            this.assistantNameDataGridViewTextBoxColumn,
            this.leadSourceDataGridViewTextBoxColumn,
            this.birthdateDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.ownerIdDataGridViewTextBoxColumn,
            this.createdDateDataGridViewTextBoxColumn,
            this.createdByIdDataGridViewTextBoxColumn,
            this.lastModifiedDateDataGridViewTextBoxColumn,
            this.lastModifiedByIdDataGridViewTextBoxColumn,
            this.systemModstampDataGridViewTextBoxColumn,
            this.lastActivityDateDataGridViewTextBoxColumn,
            this.lastCURequestDateDataGridViewTextBoxColumn,
            this.lastCUUpdateDateDataGridViewTextBoxColumn,
            this.lastViewedDateDataGridViewTextBoxColumn,
            this.lastReferencedDateDataGridViewTextBoxColumn,
            this.emailBouncedReasonDataGridViewTextBoxColumn,
            this.emailBouncedDateDataGridViewTextBoxColumn,
            this.isEmailBouncedDataGridViewCheckBoxColumn,
            this.photoUrlDataGridViewTextBoxColumn,
            this.jigsawDataGridViewTextBoxColumn,
            this.jigsawContactIdDataGridViewTextBoxColumn,
            this.cleanStatusDataGridViewTextBoxColumn,
            this.levelcDataGridViewTextBoxColumn,
            this.languagescDataGridViewTextBoxColumn});
            this.dgvSource.DataSource = this.contactBindingSource;
            this.dgvSource.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSource.Location = new System.Drawing.Point(0, 0);
            this.dgvSource.Name = "dgvSource";
            this.dgvSource.ReadOnly = true;
            this.dgvSource.RowTemplate.Height = 21;
            this.dgvSource.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSource.Size = new System.Drawing.Size(481, 428);
            this.dgvSource.TabIndex = 1;
            // 
            // scRight
            // 
            this.scRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scRight.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.scRight.Location = new System.Drawing.Point(0, 0);
            this.scRight.Name = "scRight";
            // 
            // scRight.Panel1
            // 
            this.scRight.Panel1.Controls.Add(this.pbArrow);
            this.scRight.Panel1.Controls.Add(this.btImport);
            // 
            // scRight.Panel2
            // 
            this.scRight.Panel2.Controls.Add(this.dgvDestination);
            this.scRight.Size = new System.Drawing.Size(612, 428);
            this.scRight.SplitterDistance = 87;
            this.scRight.TabIndex = 0;
            // 
            // pbArrow
            // 
            this.pbArrow.Image = ((System.Drawing.Image)(resources.GetObject("pbArrow.Image")));
            this.pbArrow.Location = new System.Drawing.Point(16, 171);
            this.pbArrow.Name = "pbArrow";
            this.pbArrow.Size = new System.Drawing.Size(54, 33);
            this.pbArrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbArrow.TabIndex = 4;
            this.pbArrow.TabStop = false;
            // 
            // btImport
            // 
            this.btImport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btImport.Location = new System.Drawing.Point(7, 220);
            this.btImport.Name = "btImport";
            this.btImport.Size = new System.Drawing.Size(73, 27);
            this.btImport.TabIndex = 3;
            this.btImport.Text = "インポート";
            this.btImport.UseVisualStyleBackColor = true;
            this.btImport.Click += new System.EventHandler(this.btImport_Click);
            // 
            // dgvDestination
            // 
            this.dgvDestination.AllowUserToAddRows = false;
            this.dgvDestination.AllowUserToDeleteRows = false;
            this.dgvDestination.AllowUserToResizeRows = false;
            this.dgvDestination.AutoGenerateColumns = false;
            this.dgvDestination.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDestination.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.emailDataGridViewTextBoxColumn1,
            this.firstNameDataGridViewTextBoxColumn1,
            this.lastNameDataGridViewTextBoxColumn1,
            this.createdAtDataGridViewTextBoxColumn,
            this.lastClickedDataGridViewTextBoxColumn,
            this.lastEmailedDataGridViewTextBoxColumn,
            this.lastOpenedDataGridViewTextBoxColumn,
            this.updatedAtDataGridViewTextBoxColumn});
            this.dgvDestination.DataSource = this.recipientsBindingSource;
            this.dgvDestination.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDestination.Location = new System.Drawing.Point(0, 0);
            this.dgvDestination.Name = "dgvDestination";
            this.dgvDestination.ReadOnly = true;
            this.dgvDestination.RowTemplate.Height = 21;
            this.dgvDestination.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDestination.Size = new System.Drawing.Size(521, 428);
            this.dgvDestination.TabIndex = 2;
            // 
            // contactBindingSource
            // 
            this.contactBindingSource.DataMember = "Contact";
            this.contactBindingSource.DataSource = this.salesforceDataSet;
            // 
            // salesforceDataSet
            // 
            this.salesforceDataSet.DataSetName = "SalesforceDataSet";
            this.salesforceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // recipientsBindingSource
            // 
            this.recipientsBindingSource.DataMember = "Recipients";
            this.recipientsBindingSource.DataSource = this.sendGridDataSet;
            // 
            // sendGridDataSet
            // 
            this.sendGridDataSet.DataSetName = "SendGridDataSet";
            this.sendGridDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // contactTableAdapter
            // 
            this.contactTableAdapter.ClearBeforeFill = true;
            // 
            // recipientsTableAdapter
            // 
            this.recipientsTableAdapter.ClearBeforeFill = true;
            // 
            // btReload
            // 
            this.btReload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btReload.Location = new System.Drawing.Point(1044, 16);
            this.btReload.Name = "btReload";
            this.btReload.Size = new System.Drawing.Size(73, 27);
            this.btReload.TabIndex = 5;
            this.btReload.Text = "リロード";
            this.btReload.UseVisualStyleBackColor = true;
            this.btReload.Click += new System.EventHandler(this.btReload_Click);
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // departmentDataGridViewTextBoxColumn
            // 
            this.departmentDataGridViewTextBoxColumn.DataPropertyName = "Department";
            this.departmentDataGridViewTextBoxColumn.HeaderText = "Department";
            this.departmentDataGridViewTextBoxColumn.Name = "departmentDataGridViewTextBoxColumn";
            this.departmentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // assistantNameDataGridViewTextBoxColumn
            // 
            this.assistantNameDataGridViewTextBoxColumn.DataPropertyName = "AssistantName";
            this.assistantNameDataGridViewTextBoxColumn.HeaderText = "AssistantName";
            this.assistantNameDataGridViewTextBoxColumn.Name = "assistantNameDataGridViewTextBoxColumn";
            this.assistantNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // leadSourceDataGridViewTextBoxColumn
            // 
            this.leadSourceDataGridViewTextBoxColumn.DataPropertyName = "LeadSource";
            this.leadSourceDataGridViewTextBoxColumn.HeaderText = "LeadSource";
            this.leadSourceDataGridViewTextBoxColumn.Name = "leadSourceDataGridViewTextBoxColumn";
            this.leadSourceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // birthdateDataGridViewTextBoxColumn
            // 
            this.birthdateDataGridViewTextBoxColumn.DataPropertyName = "Birthdate";
            this.birthdateDataGridViewTextBoxColumn.HeaderText = "Birthdate";
            this.birthdateDataGridViewTextBoxColumn.Name = "birthdateDataGridViewTextBoxColumn";
            this.birthdateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ownerIdDataGridViewTextBoxColumn
            // 
            this.ownerIdDataGridViewTextBoxColumn.DataPropertyName = "OwnerId";
            this.ownerIdDataGridViewTextBoxColumn.HeaderText = "OwnerId";
            this.ownerIdDataGridViewTextBoxColumn.Name = "ownerIdDataGridViewTextBoxColumn";
            this.ownerIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // createdDateDataGridViewTextBoxColumn
            // 
            this.createdDateDataGridViewTextBoxColumn.DataPropertyName = "CreatedDate";
            this.createdDateDataGridViewTextBoxColumn.HeaderText = "CreatedDate";
            this.createdDateDataGridViewTextBoxColumn.Name = "createdDateDataGridViewTextBoxColumn";
            this.createdDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // createdByIdDataGridViewTextBoxColumn
            // 
            this.createdByIdDataGridViewTextBoxColumn.DataPropertyName = "CreatedById";
            this.createdByIdDataGridViewTextBoxColumn.HeaderText = "CreatedById";
            this.createdByIdDataGridViewTextBoxColumn.Name = "createdByIdDataGridViewTextBoxColumn";
            this.createdByIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lastModifiedDateDataGridViewTextBoxColumn
            // 
            this.lastModifiedDateDataGridViewTextBoxColumn.DataPropertyName = "LastModifiedDate";
            this.lastModifiedDateDataGridViewTextBoxColumn.HeaderText = "LastModifiedDate";
            this.lastModifiedDateDataGridViewTextBoxColumn.Name = "lastModifiedDateDataGridViewTextBoxColumn";
            this.lastModifiedDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lastModifiedByIdDataGridViewTextBoxColumn
            // 
            this.lastModifiedByIdDataGridViewTextBoxColumn.DataPropertyName = "LastModifiedById";
            this.lastModifiedByIdDataGridViewTextBoxColumn.HeaderText = "LastModifiedById";
            this.lastModifiedByIdDataGridViewTextBoxColumn.Name = "lastModifiedByIdDataGridViewTextBoxColumn";
            this.lastModifiedByIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // systemModstampDataGridViewTextBoxColumn
            // 
            this.systemModstampDataGridViewTextBoxColumn.DataPropertyName = "SystemModstamp";
            this.systemModstampDataGridViewTextBoxColumn.HeaderText = "SystemModstamp";
            this.systemModstampDataGridViewTextBoxColumn.Name = "systemModstampDataGridViewTextBoxColumn";
            this.systemModstampDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lastActivityDateDataGridViewTextBoxColumn
            // 
            this.lastActivityDateDataGridViewTextBoxColumn.DataPropertyName = "LastActivityDate";
            this.lastActivityDateDataGridViewTextBoxColumn.HeaderText = "LastActivityDate";
            this.lastActivityDateDataGridViewTextBoxColumn.Name = "lastActivityDateDataGridViewTextBoxColumn";
            this.lastActivityDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lastCURequestDateDataGridViewTextBoxColumn
            // 
            this.lastCURequestDateDataGridViewTextBoxColumn.DataPropertyName = "LastCURequestDate";
            this.lastCURequestDateDataGridViewTextBoxColumn.HeaderText = "LastCURequestDate";
            this.lastCURequestDateDataGridViewTextBoxColumn.Name = "lastCURequestDateDataGridViewTextBoxColumn";
            this.lastCURequestDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lastCUUpdateDateDataGridViewTextBoxColumn
            // 
            this.lastCUUpdateDateDataGridViewTextBoxColumn.DataPropertyName = "LastCUUpdateDate";
            this.lastCUUpdateDateDataGridViewTextBoxColumn.HeaderText = "LastCUUpdateDate";
            this.lastCUUpdateDateDataGridViewTextBoxColumn.Name = "lastCUUpdateDateDataGridViewTextBoxColumn";
            this.lastCUUpdateDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lastViewedDateDataGridViewTextBoxColumn
            // 
            this.lastViewedDateDataGridViewTextBoxColumn.DataPropertyName = "LastViewedDate";
            this.lastViewedDateDataGridViewTextBoxColumn.HeaderText = "LastViewedDate";
            this.lastViewedDateDataGridViewTextBoxColumn.Name = "lastViewedDateDataGridViewTextBoxColumn";
            this.lastViewedDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lastReferencedDateDataGridViewTextBoxColumn
            // 
            this.lastReferencedDateDataGridViewTextBoxColumn.DataPropertyName = "LastReferencedDate";
            this.lastReferencedDateDataGridViewTextBoxColumn.HeaderText = "LastReferencedDate";
            this.lastReferencedDateDataGridViewTextBoxColumn.Name = "lastReferencedDateDataGridViewTextBoxColumn";
            this.lastReferencedDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailBouncedReasonDataGridViewTextBoxColumn
            // 
            this.emailBouncedReasonDataGridViewTextBoxColumn.DataPropertyName = "EmailBouncedReason";
            this.emailBouncedReasonDataGridViewTextBoxColumn.HeaderText = "EmailBouncedReason";
            this.emailBouncedReasonDataGridViewTextBoxColumn.Name = "emailBouncedReasonDataGridViewTextBoxColumn";
            this.emailBouncedReasonDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailBouncedDateDataGridViewTextBoxColumn
            // 
            this.emailBouncedDateDataGridViewTextBoxColumn.DataPropertyName = "EmailBouncedDate";
            this.emailBouncedDateDataGridViewTextBoxColumn.HeaderText = "EmailBouncedDate";
            this.emailBouncedDateDataGridViewTextBoxColumn.Name = "emailBouncedDateDataGridViewTextBoxColumn";
            this.emailBouncedDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // isEmailBouncedDataGridViewCheckBoxColumn
            // 
            this.isEmailBouncedDataGridViewCheckBoxColumn.DataPropertyName = "IsEmailBounced";
            this.isEmailBouncedDataGridViewCheckBoxColumn.HeaderText = "IsEmailBounced";
            this.isEmailBouncedDataGridViewCheckBoxColumn.Name = "isEmailBouncedDataGridViewCheckBoxColumn";
            this.isEmailBouncedDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // photoUrlDataGridViewTextBoxColumn
            // 
            this.photoUrlDataGridViewTextBoxColumn.DataPropertyName = "PhotoUrl";
            this.photoUrlDataGridViewTextBoxColumn.HeaderText = "PhotoUrl";
            this.photoUrlDataGridViewTextBoxColumn.Name = "photoUrlDataGridViewTextBoxColumn";
            this.photoUrlDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // jigsawDataGridViewTextBoxColumn
            // 
            this.jigsawDataGridViewTextBoxColumn.DataPropertyName = "Jigsaw";
            this.jigsawDataGridViewTextBoxColumn.HeaderText = "Jigsaw";
            this.jigsawDataGridViewTextBoxColumn.Name = "jigsawDataGridViewTextBoxColumn";
            this.jigsawDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // jigsawContactIdDataGridViewTextBoxColumn
            // 
            this.jigsawContactIdDataGridViewTextBoxColumn.DataPropertyName = "JigsawContactId";
            this.jigsawContactIdDataGridViewTextBoxColumn.HeaderText = "JigsawContactId";
            this.jigsawContactIdDataGridViewTextBoxColumn.Name = "jigsawContactIdDataGridViewTextBoxColumn";
            this.jigsawContactIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cleanStatusDataGridViewTextBoxColumn
            // 
            this.cleanStatusDataGridViewTextBoxColumn.DataPropertyName = "CleanStatus";
            this.cleanStatusDataGridViewTextBoxColumn.HeaderText = "CleanStatus";
            this.cleanStatusDataGridViewTextBoxColumn.Name = "cleanStatusDataGridViewTextBoxColumn";
            this.cleanStatusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // levelcDataGridViewTextBoxColumn
            // 
            this.levelcDataGridViewTextBoxColumn.DataPropertyName = "Level__c";
            this.levelcDataGridViewTextBoxColumn.HeaderText = "Level__c";
            this.levelcDataGridViewTextBoxColumn.Name = "levelcDataGridViewTextBoxColumn";
            this.levelcDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // languagescDataGridViewTextBoxColumn
            // 
            this.languagescDataGridViewTextBoxColumn.DataPropertyName = "Languages__c";
            this.languagescDataGridViewTextBoxColumn.HeaderText = "Languages__c";
            this.languagescDataGridViewTextBoxColumn.Name = "languagescDataGridViewTextBoxColumn";
            this.languagescDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn1
            // 
            this.emailDataGridViewTextBoxColumn1.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn1.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn1.Name = "emailDataGridViewTextBoxColumn1";
            this.emailDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // firstNameDataGridViewTextBoxColumn1
            // 
            this.firstNameDataGridViewTextBoxColumn1.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn1.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn1.Name = "firstNameDataGridViewTextBoxColumn1";
            this.firstNameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // lastNameDataGridViewTextBoxColumn1
            // 
            this.lastNameDataGridViewTextBoxColumn1.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn1.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn1.Name = "lastNameDataGridViewTextBoxColumn1";
            this.lastNameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // createdAtDataGridViewTextBoxColumn
            // 
            this.createdAtDataGridViewTextBoxColumn.DataPropertyName = "CreatedAt";
            this.createdAtDataGridViewTextBoxColumn.HeaderText = "CreatedAt";
            this.createdAtDataGridViewTextBoxColumn.Name = "createdAtDataGridViewTextBoxColumn";
            this.createdAtDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lastClickedDataGridViewTextBoxColumn
            // 
            this.lastClickedDataGridViewTextBoxColumn.DataPropertyName = "LastClicked";
            this.lastClickedDataGridViewTextBoxColumn.HeaderText = "LastClicked";
            this.lastClickedDataGridViewTextBoxColumn.Name = "lastClickedDataGridViewTextBoxColumn";
            this.lastClickedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lastEmailedDataGridViewTextBoxColumn
            // 
            this.lastEmailedDataGridViewTextBoxColumn.DataPropertyName = "LastEmailed";
            this.lastEmailedDataGridViewTextBoxColumn.HeaderText = "LastEmailed";
            this.lastEmailedDataGridViewTextBoxColumn.Name = "lastEmailedDataGridViewTextBoxColumn";
            this.lastEmailedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lastOpenedDataGridViewTextBoxColumn
            // 
            this.lastOpenedDataGridViewTextBoxColumn.DataPropertyName = "LastOpened";
            this.lastOpenedDataGridViewTextBoxColumn.HeaderText = "LastOpened";
            this.lastOpenedDataGridViewTextBoxColumn.Name = "lastOpenedDataGridViewTextBoxColumn";
            this.lastOpenedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // updatedAtDataGridViewTextBoxColumn
            // 
            this.updatedAtDataGridViewTextBoxColumn.DataPropertyName = "UpdatedAt";
            this.updatedAtDataGridViewTextBoxColumn.HeaderText = "UpdatedAt";
            this.updatedAtDataGridViewTextBoxColumn.Name = "updatedAtDataGridViewTextBoxColumn";
            this.updatedAtDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 526);
            this.Controls.Add(this.btReload);
            this.Controls.Add(this.scMain);
            this.Name = "MainForm";
            this.Text = "Salesforce -> SendGrid";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.scMain.Panel1.ResumeLayout(false);
            this.scMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).EndInit();
            this.scMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSource)).EndInit();
            this.scRight.Panel1.ResumeLayout(false);
            this.scRight.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scRight)).EndInit();
            this.scRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbArrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDestination)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesforceDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recipientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sendGridDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer scMain;
        private System.Windows.Forms.DataGridView dgvSource;
        private System.Windows.Forms.SplitContainer scRight;
        private System.Windows.Forms.PictureBox pbArrow;
        private System.Windows.Forms.Button btImport;
        private System.Windows.Forms.DataGridView dgvDestination;
        private SalesforceDataSet salesforceDataSet;
        private System.Windows.Forms.BindingSource contactBindingSource;
        private SalesforceDataSetTableAdapters.ContactTableAdapter contactTableAdapter;
        private SendGridDataSet sendGridDataSet;
        private System.Windows.Forms.BindingSource recipientsBindingSource;
        private SendGridDataSetTableAdapters.RecipientsTableAdapter recipientsTableAdapter;
        private System.Windows.Forms.Button btReload;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn assistantNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn leadSourceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ownerIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdByIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastModifiedDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastModifiedByIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn systemModstampDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastActivityDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastCURequestDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastCUUpdateDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastViewedDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastReferencedDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailBouncedReasonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailBouncedDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isEmailBouncedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn photoUrlDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jigsawDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jigsawContactIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cleanStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn levelcDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn languagescDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdAtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastClickedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastEmailedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastOpenedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn updatedAtDataGridViewTextBoxColumn;
    }
}

