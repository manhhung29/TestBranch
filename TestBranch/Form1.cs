using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace TestBranch
{
    public partial class Form1 : Form
    {
        private List<User> users;

        public Form1()
        {
            InitializeComponent();
            InitData();
        }

        private void InitData()
        {
            users = new List<User>
            {
                //test nè
                //Test tiếp nè
                // GRAPH TEST - FEATURE BRANCH
                new User { Id = 1, Name = "Hung", Department = "IT" },
                new User { Id = 2, Name = "An", Department = "QA" },
                new User { Id = 3, Name = "Binh", Department = "IT" }
            };
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = users;
        }

        private void btnFilterIT_Click(object sender, EventArgs e)
        {
            var result = users
                .Where(u => u.Department == "IT")
                .ToList();

            dataGridView1.DataSource = result;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = users;
        }
    }
}
