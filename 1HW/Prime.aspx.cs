using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _1HW
{
    public partial class Prime : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int n = 7;
            bool isPrime = true;
            if (n != 1)
            {
                for (int i = 2; i < n; i++)
                {
                    if (n % i == 0)
                    {
                        isPrime = false;
                    }
                }
            }
            if (isPrime)
            {
                Response.Write("Y");
            }
            else
            {
                Response.Write("N");
            }       
        }
    }
}
