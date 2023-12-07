/*
 * Сделано в SharpDevelop.
 * Пользователь: ТМ
 * Дата: 16.03.2019
 * Время: 9:25
 * 
 * Для изменения этого шаблона используйте Сервис | Настройка | Кодирование | Правка стандартных заголовков.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using ChildFormsFromMenuItemsCollectionControl;

namespace StorageTemplate
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public GenerateDataSet gds = new GenerateDataSet();
		
		public ChFrmCtrl cfc;
		
		public static MainForm mf = null;
		
		public MainForm()
		{
			mf = this;
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			cfc = new ChFrmCtrl(MainForm.mf.справочникиToolStripMenuItem);
		}
		
		// Метод создания дочерних окон
		public void GenChFrm(int a)
		{
			Form1 ob = new Form1();
			ob.MdiParent = this;
			ob.Text = cfc.TitlesText[a];
			cfc.SetNoNull(a, ob);
			ob.numChf = a;
			ob.Show();
		}
		
		public void Vhod()
		{
			FormDostup fd = new FormDostup();
			fd.ShowDialog();
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			Vhod();
			gds.CreateDataSet();
		}
		
		void ВыходToolStripMenuItemClick(object sender, EventArgs e)
		{
			Application.Exit();
		}
		
		void МестаХраненияToolStripMenuItemClick(object sender, EventArgs e)
		{
			GenChFrm(0);
		}
		
		void ОтветственныеЛицаToolStripMenuItemClick(object sender, EventArgs e)
		{
			GenChFrm(1);
		}
		
		void КатегорииToolStripMenuItemClick(object sender, EventArgs e)
		{
			GenChFrm(2);
		}
		
		void НаименованияToolStripMenuItemClick(object sender, EventArgs e)
		{
			GenChFrm(3);
		}
		
		void ПоставщикиToolStripMenuItemClick(object sender, EventArgs e)
		{
			GenChFrm(4);
		}
		
		void ПолучателиToolStripMenuItemClick(object sender, EventArgs e)
		{
			GenChFrm(5);
		}
		
		void ЕдиницыИзмеренияToolStripMenuItemClick(object sender, EventArgs e)
		{
			GenChFrm(6);
		}
		
				
		void СправочникиToolStripMenuItemDropDownOpening(object sender, EventArgs e)
		{
			cfc.EnableMenuItem();
		}
		
		void КаскадомToolStripMenuItemClick(object sender, EventArgs e)
		{
			this.LayoutMdi(MdiLayout.Cascade);
		}
		
		void ВертикальноToolStripMenuItemClick(object sender, EventArgs e)
		{
			this.LayoutMdi(MdiLayout.TileVertical);
		}
		
		void ГоризонтальноToolStripMenuItemClick(object sender, EventArgs e)
		{
			this.LayoutMdi(MdiLayout.TileHorizontal);
		}
		
		void ЗагрузитьБазуToolStripMenuItemClick(object sender, EventArgs e)
		{
			try{
				gds.dataSet1.Clear();
				gds.dataSet1.ReadXml("Baza.xml");
			}catch{
				MessageBox.Show("Файл не существует");
			}
			
		}
		
		void СоздатьToolStripMenuItemClick(object sender, EventArgs e)
		{
			gds.dataSet1.Clear();
		}
		
		void СохранитьToolStripMenuItemClick(object sender, EventArgs e)
		{
			gds.dataSet1.WriteXml("Baza.xml");
			gds.dataSet1.WriteXmlSchema("Baza.xsl");
		}
		
		void ВыгрузитьБазуToolStripMenuItemClick(object sender, EventArgs e)
		{
			gds.dataSet1.WriteXml("Baza.xml");
			gds.dataSet1.WriteXmlSchema("Baza.xsl");
			gds.dataSet1.Clear();
		}
	}
}
