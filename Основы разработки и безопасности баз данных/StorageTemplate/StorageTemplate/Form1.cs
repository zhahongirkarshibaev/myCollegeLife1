/*
 * Сделано в SharpDevelop.
 * Пользователь: ТМ
 * Дата: 19.03.2019
 * Время: 8:55
 * 
 * Для изменения этого шаблона используйте Сервис | Настройка | Кодирование | Правка стандартных заголовков.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace StorageTemplate
{
	/// <summary>
	/// Description of Form1.
	/// </summary>
	public partial class Form1 : Form
	{
		// Статическая переменная ссылочного типа для обращения к экземплярам класса
		public static Form1 chf = null;
		
		// Переменная для контроля состояния формы в массиве состояний
		public int numChf = -1;
		
		public Form1()
		{
			chf = this;
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
				
		void Form1FormClosing(object sender, FormClosingEventArgs e)
		{
			MainForm.mf.cfc.SetNull(numChf);
		}
		
		void Form1Load(object sender, EventArgs e)
		{
			chf.dataGridView1.DataSource = MainForm.mf.gds.dataSet1;
			switch(numChf)
			{
				case 0:
					chf.dataGridView1.DataMember = MainForm.mf.gds.dataSet1.Tables["Места хранения"].ToString();
					break;
				case 1:
					chf.dataGridView1.DataMember = MainForm.mf.gds.dataSet1.Tables["Ответственные лица"].ToString();
					break;
				case 2:
					chf.dataGridView1.DataMember = MainForm.mf.gds.dataSet1.Tables["Категории материальных ценностей"].ToString();
					break;
				case 3:
					chf.dataGridView1.DataMember = MainForm.mf.gds.dataSet1.Tables["Наименования материальных ценностей"].ToString();
					break;
				case 4:
					chf.dataGridView1.DataMember = MainForm.mf.gds.dataSet1.Tables["Поставщики"].ToString();
					break;
				case 5:
					chf.dataGridView1.DataMember = MainForm.mf.gds.dataSet1.Tables["Получатели"].ToString();
					break;
				case 6:
					chf.dataGridView1.DataMember = MainForm.mf.gds.dataSet1.Tables["Единицы измерения"].ToString();
					break;
			}
		}
	}
}
