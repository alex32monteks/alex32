using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FmClient {

//=================================================================================================
// Главная форма проекта
//=================================================================================================
public partial class Form1 : Form {

    public Form1()
    {
        InitializeComponent();
        pSsc = null;
    }

    private WS.WebServiceSoapClient pSsc;

    private void button1_Click(object sender, EventArgs e)
    {
        if (pSsc == null) pSsc = new WS.WebServiceSoapClient();
        String St = pSsc.HelloWorld();
        String vSt = richTextBox1.Text;
        if (vSt != "") vSt = vSt + "\n";
        richTextBox1.Text = vSt + St;
    }

    private void button2_Click(object sender, EventArgs e)
    {
        if (pSsc == null) pSsc = new WS.WebServiceSoapClient();
        int d = pSsc.MyRemoteMethod(56);
        String vSt = richTextBox1.Text;
        if (vSt != "") vSt = vSt + "\n";
        richTextBox1.Text = vSt + d.ToString();
    }



}

//=================================================================================================
}
