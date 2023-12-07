/*
 * Сделано в SharpDevelop.
 * Пользователь: User
 * Дата: 07.03.2022
 * Время: 12:27
 * 
 * Для изменения этого шаблона используйте Сервис | Настройка | Кодирование | Правка стандартных заголовков.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace StorageTemplate
{
	/// <summary>
	/// Description of FormDostup.
	/// </summary>
	public partial class FormDostup : Form
	{
		string szStrLogin = "12345678";
		string szStrPass = "12345678";
		
		public FormDostup()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		public void Proverka()
		{
			if((textBox1.Text != szStrLogin)||(textBox2.Text != szStrPass))
			{
				MessageBox.Show("Неправильный логин или пароль");
			}else{
				this.Close();
			}
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			Proverka();
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			
		}
		
		void TextBox3TextChanged(object sender, EventArgs e)
		{
			
		}
	}
}
