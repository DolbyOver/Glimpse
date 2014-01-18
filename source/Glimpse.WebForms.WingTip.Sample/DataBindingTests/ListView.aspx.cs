﻿using System;
using System.Collections;
using System.Web.UI;

namespace WingtipToys.DataBindingTests
{
    public partial class ListView : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var text = TextBox1.Text;
            TextBox1.Text = "different text";
            ListView1.DataBind();
            TextBox1.Text = text;
            ListView1.DataBind();

        }

        public IEnumerable GetItems(string filter, string order)
        {
            if (filter == "different text")
            {
                yield return new { Id = 0 };
            }
            yield return new { Id = 1 };
            yield return new { Id = 2 };
        }
    }
}