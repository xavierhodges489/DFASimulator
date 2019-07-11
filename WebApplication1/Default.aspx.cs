using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.TextBox3.Text = 
                @"{0,1}
{a,b,c,d}
a
{d}
(a,0)->b
(a,1)->a
(b,0)->c
(b,1)->a
(c,0)->c
(c,1)->d
(d,0)->d
(d,1)->d";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DFA dfa = new DFA();
            dfa.set(this.TextBox3.Text);

            string inputString = this.TextBox1.Text;

            foreach (char c in inputString)
            {
                dfa.input(c.ToString());
            }

            
            if (dfa.isAccepting())
                this.TextBox2.Text = "accepted";
            else
                this.TextBox2.Text = "rejected";
                
            //this.TextBox2.Text = DFA.getStates();
        }
    }
}