﻿namespace CZZD.ERP.WinUI
{
    partial class FrmProductionScheduleDetails
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProductionScheduleDetails));
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SLIP_NUMBER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TYPE_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.START_DATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.END_DATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PLAN_NUMBER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PSPP_ACTUAL_START_TIME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PSPP_ACTUAL_END_TIME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DelayTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LINE_NUMBER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.pInfo = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProduction = new System.Windows.Forms.DataGridView();
            this.row = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRODUCTION_PROCESS_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DEPARTMENT_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PSPP_PLAN_START_DATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PSPP_PLAN_END_DATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PSPP_ACTUAL_START_DATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PSPP_ACTUAL_END_DATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DelayTimeProduction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.pInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduction)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgvData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvData.BackgroundColor = System.Drawing.Color.White;
            this.dgvData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvData.ColumnHeadersHeight = 25;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.SLIP_NUMBER,
            this.TYPE_NAME,
            this.START_DATE,
            this.END_DATE,
            this.PLAN_NUMBER,
            this.PSPP_ACTUAL_START_TIME,
            this.PSPP_ACTUAL_END_TIME,
            this.DelayTime,
            this.LINE_NUMBER});
            this.dgvData.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvData.EnableHeadersVisualStyles = false;
            this.dgvData.Location = new System.Drawing.Point(3, 25);
            this.dgvData.MultiSelect = false;
            this.dgvData.Name = "dgvData";
            this.dgvData.RowHeadersVisible = false;
            this.dgvData.RowHeadersWidth = 45;
            this.dgvData.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.SkyBlue;
            this.dgvData.RowTemplate.Height = 23;
            this.dgvData.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvData.Size = new System.Drawing.Size(1005, 189);
            this.dgvData.TabIndex = 1;
            this.dgvData.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvData_CellPainting);
            this.dgvData.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dgvData_RowStateChanged);
            // 
            // No
            // 
            this.No.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle2.NullValue = null;
            this.No.DefaultCellStyle = dataGridViewCellStyle2;
            this.No.Frozen = true;
            this.No.HeaderText = "No.";
            this.No.Name = "No";
            this.No.ReadOnly = true;
            this.No.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.No.Width = 35;
            // 
            // SLIP_NUMBER
            // 
            this.SLIP_NUMBER.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.SLIP_NUMBER.DataPropertyName = "SLIP_NUMBER";
            this.SLIP_NUMBER.HeaderText = "生产工单编号";
            this.SLIP_NUMBER.Name = "SLIP_NUMBER";
            this.SLIP_NUMBER.ReadOnly = true;
            this.SLIP_NUMBER.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // TYPE_NAME
            // 
            this.TYPE_NAME.DataPropertyName = "CP_NAME";
            this.TYPE_NAME.HeaderText = "加工部件";
            this.TYPE_NAME.Name = "TYPE_NAME";
            this.TYPE_NAME.ReadOnly = true;
            this.TYPE_NAME.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // START_DATE
            // 
            this.START_DATE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.START_DATE.DataPropertyName = "PLAN_START_DATE";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Format = "yyyy-MM-dd";
            dataGridViewCellStyle3.NullValue = null;
            this.START_DATE.DefaultCellStyle = dataGridViewCellStyle3;
            this.START_DATE.HeaderText = "预定开始日期";
            this.START_DATE.Name = "START_DATE";
            this.START_DATE.ReadOnly = true;
            this.START_DATE.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.START_DATE.Width = 120;
            // 
            // END_DATE
            // 
            this.END_DATE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.END_DATE.DataPropertyName = "PLAN_END_DATE";
            dataGridViewCellStyle4.Format = "yyyy-MM-dd";
            this.END_DATE.DefaultCellStyle = dataGridViewCellStyle4;
            this.END_DATE.HeaderText = "预定完成日期";
            this.END_DATE.Name = "END_DATE";
            this.END_DATE.ReadOnly = true;
            this.END_DATE.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.END_DATE.Width = 120;
            // 
            // PLAN_NUMBER
            // 
            this.PLAN_NUMBER.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.PLAN_NUMBER.DataPropertyName = "PLAN_NUMBER";
            this.PLAN_NUMBER.HeaderText = "加工数量";
            this.PLAN_NUMBER.Name = "PLAN_NUMBER";
            this.PLAN_NUMBER.ReadOnly = true;
            this.PLAN_NUMBER.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.PLAN_NUMBER.Width = 80;
            // 
            // PSPP_ACTUAL_START_TIME
            // 
            this.PSPP_ACTUAL_START_TIME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.PSPP_ACTUAL_START_TIME.DataPropertyName = "PSPP_ACTUAL_START_TIME";
            dataGridViewCellStyle5.Format = "yyyy-MM-dd";
            this.PSPP_ACTUAL_START_TIME.DefaultCellStyle = dataGridViewCellStyle5;
            this.PSPP_ACTUAL_START_TIME.HeaderText = "实际开始日期";
            this.PSPP_ACTUAL_START_TIME.Name = "PSPP_ACTUAL_START_TIME";
            this.PSPP_ACTUAL_START_TIME.ReadOnly = true;
            this.PSPP_ACTUAL_START_TIME.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.PSPP_ACTUAL_START_TIME.Width = 120;
            // 
            // PSPP_ACTUAL_END_TIME
            // 
            this.PSPP_ACTUAL_END_TIME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.PSPP_ACTUAL_END_TIME.DataPropertyName = "PSPP_ACTUAL_END_TIME";
            dataGridViewCellStyle6.Format = "yyyy-MM-dd";
            this.PSPP_ACTUAL_END_TIME.DefaultCellStyle = dataGridViewCellStyle6;
            this.PSPP_ACTUAL_END_TIME.HeaderText = "实际完成日期";
            this.PSPP_ACTUAL_END_TIME.Name = "PSPP_ACTUAL_END_TIME";
            this.PSPP_ACTUAL_END_TIME.ReadOnly = true;
            this.PSPP_ACTUAL_END_TIME.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.PSPP_ACTUAL_END_TIME.Width = 120;
            // 
            // DelayTime
            // 
            this.DelayTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.DelayTime.HeaderText = "延迟时间(天)";
            this.DelayTime.Name = "DelayTime";
            this.DelayTime.ReadOnly = true;
            this.DelayTime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.DelayTime.Width = 120;
            // 
            // LINE_NUMBER
            // 
            this.LINE_NUMBER.DataPropertyName = "LINE_NUMBER";
            this.LINE_NUMBER.HeaderText = "LINE_NUMBER";
            this.LINE_NUMBER.Name = "LINE_NUMBER";
            this.LINE_NUMBER.ReadOnly = true;
            this.LINE_NUMBER.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.LINE_NUMBER.Visible = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.label1.Location = new System.Drawing.Point(3, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1005, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "工单进度明细";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pInfo
            // 
            this.pInfo.Controls.Add(this.btnClose);
            this.pInfo.Controls.Add(this.dataGridView2);
            this.pInfo.Controls.Add(this.dgvProduction);
            this.pInfo.Controls.Add(this.dgvData);
            this.pInfo.Controls.Add(this.label4);
            this.pInfo.Controls.Add(this.label3);
            this.pInfo.Controls.Add(this.label5);
            this.pInfo.Controls.Add(this.label2);
            this.pInfo.Controls.Add(this.label1);
            this.pInfo.Location = new System.Drawing.Point(0, 0);
            this.pInfo.Name = "pInfo";
            this.pInfo.Size = new System.Drawing.Size(1008, 690);
            this.pInfo.TabIndex = 3;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.btnClose.Location = new System.Drawing.Point(915, 659);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(90, 30);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "关　闭";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dataGridView2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView2.ColumnHeadersHeight = 25;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13});
            this.dataGridView2.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView2.EnableHeadersVisualStyles = false;
            this.dataGridView2.Location = new System.Drawing.Point(3, 488);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowHeadersWidth = 45;
            this.dataGridView2.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.SkyBlue;
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(1005, 167);
            this.dataGridView2.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "No";
            dataGridViewCellStyle8.Format = "yyyy-MM-dd";
            dataGridViewCellStyle8.NullValue = null;
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewTextBoxColumn4.Frozen = true;
            this.dataGridViewTextBoxColumn4.HeaderText = "No.";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn4.Width = 35;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "SLIP_NUMBER";
            this.dataGridViewTextBoxColumn7.HeaderText = "图纸类型";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn10.DataPropertyName = "END_DATE";
            this.dataGridViewTextBoxColumn10.HeaderText = "预定完成日期";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn10.Width = 120;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn12.HeaderText = "实际完成日期";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn12.Width = 120;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn13.HeaderText = "延迟时间(天)";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn13.Width = 120;
            // 
            // dgvProduction
            // 
            this.dgvProduction.AllowUserToAddRows = false;
            this.dgvProduction.AllowUserToResizeRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgvProduction.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvProduction.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProduction.BackgroundColor = System.Drawing.Color.White;
            this.dgvProduction.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvProduction.ColumnHeadersHeight = 25;
            this.dgvProduction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvProduction.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.row,
            this.PRODUCTION_PROCESS_NAME,
            this.DEPARTMENT_NAME,
            this.PSPP_PLAN_START_DATE,
            this.PSPP_PLAN_END_DATE,
            this.PSPP_ACTUAL_START_DATE,
            this.PSPP_ACTUAL_END_DATE,
            this.DelayTimeProduction});
            this.dgvProduction.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvProduction.EnableHeadersVisualStyles = false;
            this.dgvProduction.Location = new System.Drawing.Point(3, 263);
            this.dgvProduction.MultiSelect = false;
            this.dgvProduction.Name = "dgvProduction";
            this.dgvProduction.RowHeadersVisible = false;
            this.dgvProduction.RowHeadersWidth = 45;
            this.dgvProduction.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.SkyBlue;
            this.dgvProduction.RowTemplate.Height = 23;
            this.dgvProduction.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProduction.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProduction.Size = new System.Drawing.Size(1005, 201);
            this.dgvProduction.TabIndex = 1;
            this.dgvProduction.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvProduction_CellPainting);
            // 
            // row
            // 
            this.row.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle10.NullValue = null;
            this.row.DefaultCellStyle = dataGridViewCellStyle10;
            this.row.Frozen = true;
            this.row.HeaderText = "No.";
            this.row.Name = "row";
            this.row.ReadOnly = true;
            this.row.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.row.Width = 35;
            // 
            // PRODUCTION_PROCESS_NAME
            // 
            this.PRODUCTION_PROCESS_NAME.DataPropertyName = "PRODUCTION_PROCESS_NAME";
            this.PRODUCTION_PROCESS_NAME.HeaderText = "工序";
            this.PRODUCTION_PROCESS_NAME.Name = "PRODUCTION_PROCESS_NAME";
            this.PRODUCTION_PROCESS_NAME.ReadOnly = true;
            this.PRODUCTION_PROCESS_NAME.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // DEPARTMENT_NAME
            // 
            this.DEPARTMENT_NAME.DataPropertyName = "DEPARTMENT_NAME";
            this.DEPARTMENT_NAME.HeaderText = "加工部门";
            this.DEPARTMENT_NAME.Name = "DEPARTMENT_NAME";
            this.DEPARTMENT_NAME.ReadOnly = true;
            this.DEPARTMENT_NAME.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // PSPP_PLAN_START_DATE
            // 
            this.PSPP_PLAN_START_DATE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.PSPP_PLAN_START_DATE.DataPropertyName = "PSPP_PLAN_START_DATE";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.Format = "yyyy-MM-dd";
            dataGridViewCellStyle11.NullValue = null;
            this.PSPP_PLAN_START_DATE.DefaultCellStyle = dataGridViewCellStyle11;
            this.PSPP_PLAN_START_DATE.HeaderText = "预定开始日期";
            this.PSPP_PLAN_START_DATE.Name = "PSPP_PLAN_START_DATE";
            this.PSPP_PLAN_START_DATE.ReadOnly = true;
            this.PSPP_PLAN_START_DATE.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.PSPP_PLAN_START_DATE.Width = 120;
            // 
            // PSPP_PLAN_END_DATE
            // 
            this.PSPP_PLAN_END_DATE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.PSPP_PLAN_END_DATE.DataPropertyName = "PSPP_PLAN_END_DATE";
            dataGridViewCellStyle12.Format = "yyyy-MM-dd";
            this.PSPP_PLAN_END_DATE.DefaultCellStyle = dataGridViewCellStyle12;
            this.PSPP_PLAN_END_DATE.HeaderText = "预定完成日期";
            this.PSPP_PLAN_END_DATE.Name = "PSPP_PLAN_END_DATE";
            this.PSPP_PLAN_END_DATE.ReadOnly = true;
            this.PSPP_PLAN_END_DATE.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.PSPP_PLAN_END_DATE.Width = 120;
            // 
            // PSPP_ACTUAL_START_DATE
            // 
            this.PSPP_ACTUAL_START_DATE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.PSPP_ACTUAL_START_DATE.DataPropertyName = "PSPP_ACTUAL_START_TIME";
            dataGridViewCellStyle13.Format = "yyyy-MM-dd";
            this.PSPP_ACTUAL_START_DATE.DefaultCellStyle = dataGridViewCellStyle13;
            this.PSPP_ACTUAL_START_DATE.HeaderText = "实际开始日期";
            this.PSPP_ACTUAL_START_DATE.Name = "PSPP_ACTUAL_START_DATE";
            this.PSPP_ACTUAL_START_DATE.ReadOnly = true;
            this.PSPP_ACTUAL_START_DATE.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.PSPP_ACTUAL_START_DATE.Width = 120;
            // 
            // PSPP_ACTUAL_END_DATE
            // 
            this.PSPP_ACTUAL_END_DATE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.PSPP_ACTUAL_END_DATE.DataPropertyName = "PSPP_ACTUAL_END_TIME";
            dataGridViewCellStyle14.Format = "yyyy-MM-dd";
            this.PSPP_ACTUAL_END_DATE.DefaultCellStyle = dataGridViewCellStyle14;
            this.PSPP_ACTUAL_END_DATE.HeaderText = "实际完成日期";
            this.PSPP_ACTUAL_END_DATE.Name = "PSPP_ACTUAL_END_DATE";
            this.PSPP_ACTUAL_END_DATE.ReadOnly = true;
            this.PSPP_ACTUAL_END_DATE.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.PSPP_ACTUAL_END_DATE.Width = 120;
            // 
            // DelayTimeProduction
            // 
            this.DelayTimeProduction.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.DelayTimeProduction.HeaderText = "延迟时间(天)";
            this.DelayTimeProduction.Name = "DelayTimeProduction";
            this.DelayTimeProduction.ReadOnly = true;
            this.DelayTimeProduction.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.DelayTimeProduction.Width = 120;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.label4.Location = new System.Drawing.Point(111, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1005, 24);
            this.label4.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.label3.Location = new System.Drawing.Point(3, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "加工部件：";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.label5.Location = new System.Drawing.Point(3, 464);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(1005, 24);
            this.label5.TabIndex = 2;
            this.label5.Text = "图纸进度明细";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.label2.Location = new System.Drawing.Point(3, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1005, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "工序进度明细";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmProductionScheduleDetails
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1008, 692);
            this.Controls.Add(this.pInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmProductionScheduleDetails";
            this.Text = "加工进度明细";
            this.Load += new System.EventHandler(this.FrmProductionScheduleDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.pInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduction)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvProduction;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn SLIP_NUMBER;
        private System.Windows.Forms.DataGridViewTextBoxColumn TYPE_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn START_DATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn END_DATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn PLAN_NUMBER;
        private System.Windows.Forms.DataGridViewTextBoxColumn PSPP_ACTUAL_START_TIME;
        private System.Windows.Forms.DataGridViewTextBoxColumn PSPP_ACTUAL_END_TIME;
        private System.Windows.Forms.DataGridViewTextBoxColumn DelayTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn LINE_NUMBER;
        private System.Windows.Forms.DataGridViewTextBoxColumn row;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRODUCTION_PROCESS_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn DEPARTMENT_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn PSPP_PLAN_START_DATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn PSPP_PLAN_END_DATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn PSPP_ACTUAL_START_DATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn PSPP_ACTUAL_END_DATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn DelayTimeProduction;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
    }
}