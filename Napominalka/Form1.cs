using System;
using System.Windows.Forms;

namespace Napominalka
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeContextMenu(); // Инициализируем контекстное меню
            this.MouseDown += Form1_MouseDown; // Создаем экземпляр панели
            InitializePanel(); // Инициализируем панель
        }
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripTextBox toolStripTextBox1;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton2;
        private ToolStripButton toolStripButton3;
        private ToolStripButton toolStripButton4;
        private ToolStripButton toolStripButton5;
        private VScrollBar vScrollBar1;

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStrip1.Show(this, e.Location);
            }
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem1.Text = "toolStripMenuItem1";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem2.Text = "toolStripMenuItem2";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem3.Text = "toolStripMenuItem3";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 23);
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(206, 9);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(25, 432);
            this.vScrollBar1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Location = new System.Drawing.Point(293, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(258, 331);
            this.panel1.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(14, 17);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(165, 275);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(84, 134);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(45)))), ((int)(((byte)(47)))));
            this.ClientSize = new System.Drawing.Size(622, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.vScrollBar1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        private void InitializePanel()
        {
            panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            panel1.ForeColor = System.Drawing.SystemColors.ControlLight;
            panel1.Location = new System.Drawing.Point(293, 12);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(258, 331);
            panel1.TabIndex = 2;
            textBox1.Visible = false;
            dateTimePicker1.Visible = false;
            button1.Visible = false;
            panel1.Visible = false; // Устанавливаем видимость панели false по умолчанию

            this.Controls.Add(panel1); // Добавляем панель на форму
        }

        private void InitializeContextMenu()
        {
            contextMenuStrip1 = new ContextMenuStrip();

            toolStripMenuItem1 = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripMenuItem();
            toolStripButton1 = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            toolStripButton3 = new ToolStripButton();
            toolStripButton4 = new ToolStripButton();
            toolStripButton5 = new ToolStripButton();

            toolStripButton1.Text = "Пункт меню 1";
            toolStripButton2.Text = "Пункт меню 2";

            contextMenuStrip1.Items.AddRange(new ToolStripItem[]
            {
                toolStripMenuItem1,
                toolStripMenuItem2,
                toolStripMenuItem3,
                toolStripButton1,
                toolStripButton2,
                toolStripButton3,
                toolStripButton4,
                toolStripButton5
            });
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 95);

            this.ContextMenuStrip = contextMenuStrip1;

            toolStripMenuItem1.Click += ToolStripMenuItem1_Click;
            toolStripMenuItem2.Click += ToolStripMenuItem2_Click;
        }


        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            // Показываем или скрываем панель в зависимости от текущего состояния видимости
            panel1.Visible = !panel1.Visible;
        }

        private void ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textBox1.Visible = !textBox1.Visible;
            dateTimePicker1.Visible = !dateTimePicker1.Visible;
            button1.Visible = !button1.Visible;
            panel1.Visible = !panel1.Visible;
            MessageBox.Show("Вы выбрали Пункт меню 1");
        }

        private void ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Вы выбрали Пункт меню 2");
        }

        public void ShowForm()
        {
            Application.Run(this);
        }
    }
}