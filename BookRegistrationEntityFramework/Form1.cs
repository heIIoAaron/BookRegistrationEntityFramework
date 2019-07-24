﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookRegistrationEntityFramework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PopulateCustomerList();
            PopulateBooks();
        }

        /// <summary>
        /// Adds all books to the form in alphabetical order.
        /// </summary>
        private void PopulateBooks()
        {
            List<Book> books = BookDb.GetBooks();
            cboBooks.DataSource = books;
            cboBooks.DisplayMember = nameof(Book.Title);
        }

        /// <summary>
        /// Populate customer list from the database
        /// </summary>
        private void PopulateCustomerList()
        {
            List<Customer> customers = CustomerDb.GetCustomers();
            cboCustomers.DataSource = customers;
            cboCustomers.DisplayMember = nameof(Customer.FullName);
        }
    }
}
