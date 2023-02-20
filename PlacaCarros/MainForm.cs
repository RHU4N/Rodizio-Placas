/*
 * Created by SharpDevelop.
 * User: Aluno
 * Date: 10/12/2021
 * Time: 10:50
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace PlacaCarros
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		
			
		public MainForm()
		{
			
			InitializeComponent();
			
			
		}
		
		void MainFormLoad(object sender, EventArgs e){
	
		try{
		richTextBox1.LoadFile("ChapaCarros 1.txt", RichTextBoxStreamType.PlainText);
		}
			
		catch{}
	
	}
		void ComboBox1SelectedIndexChanged(object sender, EventArgs e)
		{
						int cont = 0;

						if (comboBox1.SelectedItem.ToString() == "Segunda-Feira"){
							listBox1.Items.Clear();
							foreach (string lInteira in richTextBox1.Lines)
				{
					string [] dados = lInteira.Split('\t');
					string nUltimo= dados[0];
					cont++;
					if (nUltimo[6] == '1' || nUltimo[6] == '2')
					{
			    	 listBox1.Items.Add(dados[1]);
					}
				}
			}

							if (comboBox1.SelectedItem.ToString() == "Terça-Feira"){
								listBox1.Items.Clear();						
								foreach (string lInteira in richTextBox1.Lines)
				{
					string [] dados = lInteira.Split('\t');
					string nUltimo = dados[0];
					cont++;
					if (nUltimo[6] == '3' || nUltimo[6] == '4')
					{
					 listBox1.Items.Add(dados[1]);
					}
				}
			}
						
							if (comboBox1.SelectedItem.ToString() == "Quarta-Feira"){
								listBox1.Items.Clear();
								foreach (string lInteira in richTextBox1.Lines)
				{
					string [] dados = lInteira.Split('\t');
					string nUltimo = dados[0];
					cont++;
					if (nUltimo[6] == '5' || nUltimo[6] == '6')
					{
					 listBox1.Items.Add(dados[1]);
					}
				}
			}	
						
							if (comboBox1.SelectedItem.ToString() == "Quinta-Feira"){
								listBox1.Items.Clear();
								foreach (string lInteira in richTextBox1.Lines)
				{	
					string [] dados = lInteira.Split('\t');
					string nUltimo = dados[0];
					cont++;
					if (nUltimo[6] == '7' || nUltimo[6] == '8')
					{
					 listBox1.Items.Add(dados[1]);
					}
				}
			}	
						
							if (comboBox1.SelectedItem.ToString() == "Sexta-Feira"){
								listBox1.Items.Clear();
								foreach (string lInteira in richTextBox1.Lines)
				{
					string [] dados = lInteira.Split('\t');
					string nUltimo = dados[0];
					cont++;
					if (nUltimo[6] == '9' || nUltimo[6] == '0')
					{
					listBox1.Items.Add(dados[1]);
					}
				}
			}
						
		}

	}
}
