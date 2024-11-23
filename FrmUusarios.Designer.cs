namespace pryGarciaLuciana
{
    partial class FrmUusarios
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Invitado");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Administrador", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Usuarios Regulares", new System.Windows.Forms.TreeNode[] {
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Usuarios Avanzados", new System.Windows.Forms.TreeNode[] {
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Categorias", new System.Windows.Forms.TreeNode[] {
            treeNode4});
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Usuarios", new System.Windows.Forms.TreeNode[] {
            treeNode5});
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.lstDatosUusario = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(12, 12);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Invitado";
            treeNode1.Text = "Invitado";
            treeNode2.Name = "Administrador";
            treeNode2.Text = "Administrador";
            treeNode3.Name = "Usuarios Regulares";
            treeNode3.Text = "Usuarios Regulares";
            treeNode4.Name = "Usuarios Avazados";
            treeNode4.Text = "Usuarios Avanzados";
            treeNode5.Name = "Categorias";
            treeNode5.Text = "Categorias";
            treeNode6.Name = "Usuarios";
            treeNode6.Text = "Usuarios";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode6});
            this.treeView1.Size = new System.Drawing.Size(197, 175);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_NodeMouseclick);
            // 
            // lstDatosUusario
            // 
            this.lstDatosUusario.FormattingEnabled = true;
            this.lstDatosUusario.Location = new System.Drawing.Point(256, 12);
            this.lstDatosUusario.Name = "lstDatosUusario";
            this.lstDatosUusario.Size = new System.Drawing.Size(149, 173);
            this.lstDatosUusario.TabIndex = 1;
            // 
            // FrmUusarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(446, 255);
            this.Controls.Add(this.lstDatosUusario);
            this.Controls.Add(this.treeView1);
            this.Name = "FrmUusarios";
            this.Text = "FrmUusarios";
            this.Load += new System.EventHandler(this.FrmUusarios_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ListBox lstDatosUusario;
    }
}