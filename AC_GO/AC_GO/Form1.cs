


using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using System;
using System.Windows.Forms;
namespace AC_GO
{
    public partial class Form1 : Form
    {

        bool t;

        public Form1()
        {
            InitializeComponent();
        }

        /*private void Form1_Load(object sender, EventArgs e)
        {

        }*/
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }


        public void Send(string text,IWebDriver driver)
        {
            var jsReturnValue = (IWebElement)((IJavaScriptExecutor)driver).ExecuteScript("sourceNode = document.getElementsByClassName(\"ace_line\")[0]; \n"+
            "clonedNode = sourceNode.cloneNode(true); clonedNode.innerText=\""+text+
            "\";\nsourceNode.parentNode.appendChild(clonedNode);");
        }



        private void button1_Click(object sender, EventArgs e)
        {
            var service = EdgeDriverService.CreateDefaultService(@".", "msedgedriver.exe");
            using (IWebDriver driver = new OpenQA.Selenium.Edge.EdgeDriver(service))
            {/*
                driver.Navigate().GoToUrl("https://www.luogu.com.cn/auth/login");

                ((IJavaScriptExecutor)driver).ExecuteScript("document.getElementsByTagName(\"input\")[1].value='yangchang'");
                ((IJavaScriptExecutor)driver).ExecuteScript("document.getElementsByTagName(\"input\")[2].value='yb1234567890'");
                */

                driver.Navigate().GoToUrl("https://www.luogu.com.cn/problem/"+this.textBox1.Text+"#submit");  //driver.Url = "http://www.baidu.com"是一样的
                
                MessageBox.Show("Plase sign in!");
                var source = driver.PageSource;
                driver.FindElements(By.TagName("button"))[0].Click();
                var jsReturnValue = (IWebElement)((IJavaScriptExecutor)driver).ExecuteScript("console.log(0)");
                /*
                 
                 var sourceNode = document.getElementsByClassName("ace_line")[0]; // 获得被克隆的节点对象   
	var clonedNode = sourceNode.cloneNode(true); clonedNode.innerText="on"  
	sourceNode.parentNode.appendChild(clonedNode); // 在父节点插入克隆的节点   

                 */
                Send("#include<iostream>",driver);
                Send("int main(){", driver);
                Send("int c = getchar()-48;", driver);
                Send("while(c%2) if(c%4==1) puts(48);", driver);
                Send("if(c==2) new int[1000000];", driver);
                Send("else throw;}", driver);
                ((IJavaScriptExecutor)driver).ExecuteScript("document.getElementsByTagName(\"button\")[2].click()"); ;
                MessageBox.Show("NULL");

                this.button1.Text = source;
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            ((TextBox)sender).Text = "";
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            t=false;
        }
    }
}