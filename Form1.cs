/*
	wizdl - Web Service GUI
    Copyright (C) 2008  Ajai Shankar

    This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program.  If not, see <http://www.gnu.org/licenses/>.
 */

using System;
using System.Collections;
using System.Windows.Forms;

namespace WebServices.UI
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
		private System.Windows.Forms.TextBox txtWsdlUrl;
		private System.Windows.Forms.Label lblWsdlUrl;
		private System.Windows.Forms.Button btnTest;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Panel gridPanel;
		private System.Windows.Forms.Button btnLoad;
		private System.Windows.Forms.TextBox txtSoap;
		private System.Windows.Forms.ComboBox cbxMethods;
		private System.Windows.Forms.ComboBox cbxServices;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private PropertyGrid propertyGrid;
		private System.Windows.Forms.Panel gridPanel2;
		private System.Windows.Forms.Button btnRefresh;
		private PropertyGrid resultsGrid;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			propertyGrid = new PropertyGrid();
			resultsGrid = new PropertyGrid();

			propertyGrid.HelpVisible = false;
			resultsGrid.HelpVisible = false;

			propertyGrid.ToolbarVisible = false;
			resultsGrid.ToolbarVisible = false;

			propertyGrid.Dock = DockStyle.Fill;
			resultsGrid.Dock = DockStyle.Fill;

			gridPanel.Controls.Add(propertyGrid);
			gridPanel2.Controls.Add(resultsGrid);
			
			TraceExtension.SoapTextBox = this.txtSoap;

			cbxServices.SelectedIndexChanged += new EventHandler(cbxServices_SelectedIndexChanged);
			cbxMethods.SelectedIndexChanged += new EventHandler(cbxMethods_SelectedIndexChanged);
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.txtWsdlUrl = new System.Windows.Forms.TextBox();
			this.lblWsdlUrl = new System.Windows.Forms.Label();
			this.btnLoad = new System.Windows.Forms.Button();
			this.cbxMethods = new System.Windows.Forms.ComboBox();
			this.btnTest = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.txtSoap = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.gridPanel = new System.Windows.Forms.Panel();
			this.cbxServices = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.gridPanel2 = new System.Windows.Forms.Panel();
			this.label3 = new System.Windows.Forms.Label();
			this.btnRefresh = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// txtWsdlUrl
			// 
			this.txtWsdlUrl.Location = new System.Drawing.Point(88, 8);
			this.txtWsdlUrl.Name = "txtWsdlUrl";
			this.txtWsdlUrl.Size = new System.Drawing.Size(336, 20);
			this.txtWsdlUrl.TabIndex = 0;
			this.txtWsdlUrl.Text = "";
			// 
			// lblWsdlUrl
			// 
			this.lblWsdlUrl.Location = new System.Drawing.Point(8, 8);
			this.lblWsdlUrl.Name = "lblWsdlUrl";
			this.lblWsdlUrl.Size = new System.Drawing.Size(72, 23);
			this.lblWsdlUrl.TabIndex = 1;
			this.lblWsdlUrl.Text = "WSDL URL";
			this.lblWsdlUrl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btnLoad
			// 
			this.btnLoad.Location = new System.Drawing.Point(440, 8);
			this.btnLoad.Name = "btnLoad";
			this.btnLoad.Size = new System.Drawing.Size(88, 23);
			this.btnLoad.TabIndex = 2;
			this.btnLoad.Text = "Load Url";
			this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
			// 
			// cbxMethods
			// 
			this.cbxMethods.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbxMethods.Location = new System.Drawing.Point(88, 72);
			this.cbxMethods.Name = "cbxMethods";
			this.cbxMethods.Size = new System.Drawing.Size(336, 21);
			this.cbxMethods.TabIndex = 3;
			// 
			// btnTest
			// 
			this.btnTest.Location = new System.Drawing.Point(440, 44);
			this.btnTest.Name = "btnTest";
			this.btnTest.Size = new System.Drawing.Size(88, 23);
			this.btnTest.TabIndex = 4;
			this.btnTest.Text = "Test Method";
			this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(8, 72);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(72, 23);
			this.label1.TabIndex = 5;
			this.label1.Text = "Method";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtSoap
			// 
			this.txtSoap.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.txtSoap.Location = new System.Drawing.Point(8, 16);
			this.txtSoap.Multiline = true;
			this.txtSoap.Name = "txtSoap";
			this.txtSoap.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtSoap.Size = new System.Drawing.Size(592, 152);
			this.txtSoap.TabIndex = 0;
			this.txtSoap.Text = "";
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.txtSoap);
			this.groupBox1.Location = new System.Drawing.Point(8, 477);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(608, 176);
			this.groupBox1.TabIndex = 6;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Soap Message Log";
			// 
			// gridPanel
			// 
			this.gridPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.gridPanel.Location = new System.Drawing.Point(8, 112);
			this.gridPanel.Name = "gridPanel";
			this.gridPanel.Size = new System.Drawing.Size(608, 208);
			this.gridPanel.TabIndex = 7;
			// 
			// cbxServices
			// 
			this.cbxServices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbxServices.Location = new System.Drawing.Point(88, 40);
			this.cbxServices.Name = "cbxServices";
			this.cbxServices.Size = new System.Drawing.Size(336, 21);
			this.cbxServices.TabIndex = 8;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(8, 40);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(72, 23);
			this.label2.TabIndex = 9;
			this.label2.Text = "Service";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// gridPanel2
			// 
			this.gridPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.gridPanel2.Location = new System.Drawing.Point(8, 352);
			this.gridPanel2.Name = "gridPanel2";
			this.gridPanel2.Size = new System.Drawing.Size(608, 120);
			this.gridPanel2.TabIndex = 10;
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label3.Location = new System.Drawing.Point(8, 328);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(72, 23);
			this.label3.TabIndex = 11;
			this.label3.Text = "Result";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btnRefresh
			// 
			this.btnRefresh.Location = new System.Drawing.Point(440, 80);
			this.btnRefresh.Name = "btnRefresh";
			this.btnRefresh.Size = new System.Drawing.Size(88, 23);
			this.btnRefresh.TabIndex = 12;
			this.btnRefresh.Text = "Refresh Grids";
			this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(624, 658);
			this.Controls.Add(this.btnRefresh);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.gridPanel2);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.cbxServices);
			this.Controls.Add(this.gridPanel);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnTest);
			this.Controls.Add(this.cbxMethods);
			this.Controls.Add(this.btnLoad);
			this.Controls.Add(this.lblWsdlUrl);
			this.Controls.Add(this.txtWsdlUrl);
			this.Name = "Form1";
			this.Text = "wizdl - Web Service GUI";
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}

		private void cbxServices_SelectedIndexChanged(object sender, EventArgs e)
		{
			WebService svc = cbxServices.SelectedItem as WebService;

			if(svc != null) 
			{
				cbxMethods.Items.Clear();

				foreach(WebMethod method in svc.Methods)
				{
					cbxMethods.Items.Add(method);
				}

				if(svc.Methods.Length > 0) 
				{
					cbxMethods.SelectedIndex = 0;
				}
			}
		}

		private void cbxMethods_SelectedIndexChanged(object sender, EventArgs e)
		{
			WebMethod method = cbxMethods.SelectedItem as WebMethod;

			if(method != null) 
			{
				propertyGrid.SelectedObject = method;
			}
		}

		private void btnLoad_Click(object sender, System.EventArgs e)
		{
			try 
			{
				propertyGrid.SelectedObject = null;
				resultsGrid.SelectedObject = null;

				cbxServices.Items.Clear();
				cbxMethods.Items.Clear();

				WebService[] services = WebService.GetServices(txtWsdlUrl.Text);

				foreach(WebService svc in services) 
				{
					cbxServices.Items.Add(svc);
				}

				if(services.Length > 0) 
				{
					cbxServices.SelectedIndex = 0;
				}
			} 
			catch(Exception x)
			{
				MessageBox.Show(x.ToString());
			}
		}

		private void btnTest_Click(object sender, System.EventArgs e)
		{
			try 
			{
				resultsGrid.SelectedObject = null;

				WebMethod method = cbxMethods.SelectedItem as WebMethod;

				if(method != null) 
				{
					resultsGrid.SelectedObject = method.Invoke();
				}
			} 
			catch(Exception x) 
			{
				MessageBox.Show(x.ToString());
			}
		}

		private void btnRefresh_Click(object sender, System.EventArgs e)
		{
			propertyGrid.Refresh();
			resultsGrid.Refresh();
		}
	}
}

