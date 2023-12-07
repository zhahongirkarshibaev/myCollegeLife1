/*
 * Сделано в SharpDevelop.
 * Пользователь: ТМ
 * Дата: 16.03.2019
 * Время: 9:25
 * 
 * Для изменения этого шаблона используйте Сервис | Настройка | Кодирование | Правка стандартных заголовков.
 */
namespace StorageTemplate
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.создатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.загрузитьБазуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.выгрузитьБазуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
			this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.учётToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.справочникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.местаХраненияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ответственныеЛицаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
			this.категорииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.наименованияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
			this.поставщикиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.получателиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
			this.единицыИзмеренияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.окнаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.упорядочитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.каскадомToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.вертикальноToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.горизонтальноToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.файлToolStripMenuItem,
									this.учётToolStripMenuItem,
									this.справочникиToolStripMenuItem,
									this.окнаToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.MdiWindowListItem = this.окнаToolStripMenuItem;
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(584, 24);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// файлToolStripMenuItem
			// 
			this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.создатьToolStripMenuItem,
									this.загрузитьБазуToolStripMenuItem,
									this.сохранитьToolStripMenuItem,
									this.выгрузитьБазуToolStripMenuItem,
									this.toolStripMenuItem1,
									this.выходToolStripMenuItem});
			this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
			this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
			this.файлToolStripMenuItem.Text = "&Файл";
			// 
			// создатьToolStripMenuItem
			// 
			this.создатьToolStripMenuItem.Name = "создатьToolStripMenuItem";
			this.создатьToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
			this.создатьToolStripMenuItem.Text = "Со&здать";
			this.создатьToolStripMenuItem.Click += new System.EventHandler(this.СоздатьToolStripMenuItemClick);
			// 
			// загрузитьБазуToolStripMenuItem
			// 
			this.загрузитьБазуToolStripMenuItem.Name = "загрузитьБазуToolStripMenuItem";
			this.загрузитьБазуToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
			this.загрузитьБазуToolStripMenuItem.Text = "За&грузить базу";
			this.загрузитьБазуToolStripMenuItem.Click += new System.EventHandler(this.ЗагрузитьБазуToolStripMenuItemClick);
			// 
			// сохранитьToolStripMenuItem
			// 
			this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
			this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
			this.сохранитьToolStripMenuItem.Text = "Со&хранить";
			this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.СохранитьToolStripMenuItemClick);
			// 
			// выгрузитьБазуToolStripMenuItem
			// 
			this.выгрузитьБазуToolStripMenuItem.Name = "выгрузитьБазуToolStripMenuItem";
			this.выгрузитьБазуToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
			this.выгрузитьБазуToolStripMenuItem.Text = "&Выгрузить базу";
			this.выгрузитьБазуToolStripMenuItem.Click += new System.EventHandler(this.ВыгрузитьБазуToolStripMenuItemClick);
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(155, 6);
			// 
			// выходToolStripMenuItem
			// 
			this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
			this.выходToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
			this.выходToolStripMenuItem.Text = "В&ыход";
			this.выходToolStripMenuItem.Click += new System.EventHandler(this.ВыходToolStripMenuItemClick);
			// 
			// учётToolStripMenuItem
			// 
			this.учётToolStripMenuItem.Name = "учётToolStripMenuItem";
			this.учётToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.учётToolStripMenuItem.Text = "&Учёт";
			// 
			// справочникиToolStripMenuItem
			// 
			this.справочникиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.местаХраненияToolStripMenuItem,
									this.ответственныеЛицаToolStripMenuItem,
									this.toolStripMenuItem2,
									this.категорииToolStripMenuItem,
									this.наименованияToolStripMenuItem,
									this.toolStripMenuItem3,
									this.поставщикиToolStripMenuItem,
									this.получателиToolStripMenuItem,
									this.toolStripMenuItem4,
									this.единицыИзмеренияToolStripMenuItem});
			this.справочникиToolStripMenuItem.Name = "справочникиToolStripMenuItem";
			this.справочникиToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
			this.справочникиToolStripMenuItem.Text = "С&правочники";
			this.справочникиToolStripMenuItem.DropDownOpening += new System.EventHandler(this.СправочникиToolStripMenuItemDropDownOpening);
			// 
			// местаХраненияToolStripMenuItem
			// 
			this.местаХраненияToolStripMenuItem.Name = "местаХраненияToolStripMenuItem";
			this.местаХраненияToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
			this.местаХраненияToolStripMenuItem.Text = "&Места хранения";
			this.местаХраненияToolStripMenuItem.Click += new System.EventHandler(this.МестаХраненияToolStripMenuItemClick);
			// 
			// ответственныеЛицаToolStripMenuItem
			// 
			this.ответственныеЛицаToolStripMenuItem.Name = "ответственныеЛицаToolStripMenuItem";
			this.ответственныеЛицаToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
			this.ответственныеЛицаToolStripMenuItem.Text = "&Ответственные лица";
			this.ответственныеЛицаToolStripMenuItem.Click += new System.EventHandler(this.ОтветственныеЛицаToolStripMenuItemClick);
			// 
			// toolStripMenuItem2
			// 
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.Size = new System.Drawing.Size(184, 6);
			// 
			// категорииToolStripMenuItem
			// 
			this.категорииToolStripMenuItem.Name = "категорииToolStripMenuItem";
			this.категорииToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
			this.категорииToolStripMenuItem.Text = "&Категории";
			this.категорииToolStripMenuItem.Click += new System.EventHandler(this.КатегорииToolStripMenuItemClick);
			// 
			// наименованияToolStripMenuItem
			// 
			this.наименованияToolStripMenuItem.Name = "наименованияToolStripMenuItem";
			this.наименованияToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
			this.наименованияToolStripMenuItem.Text = "&Наименования";
			this.наименованияToolStripMenuItem.Click += new System.EventHandler(this.НаименованияToolStripMenuItemClick);
			// 
			// toolStripMenuItem3
			// 
			this.toolStripMenuItem3.Name = "toolStripMenuItem3";
			this.toolStripMenuItem3.Size = new System.Drawing.Size(184, 6);
			// 
			// поставщикиToolStripMenuItem
			// 
			this.поставщикиToolStripMenuItem.Name = "поставщикиToolStripMenuItem";
			this.поставщикиToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
			this.поставщикиToolStripMenuItem.Text = "Пос&тавщики";
			this.поставщикиToolStripMenuItem.Click += new System.EventHandler(this.ПоставщикиToolStripMenuItemClick);
			// 
			// получателиToolStripMenuItem
			// 
			this.получателиToolStripMenuItem.Name = "получателиToolStripMenuItem";
			this.получателиToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
			this.получателиToolStripMenuItem.Text = "По&лучатели";
			this.получателиToolStripMenuItem.Click += new System.EventHandler(this.ПолучателиToolStripMenuItemClick);
			// 
			// toolStripMenuItem4
			// 
			this.toolStripMenuItem4.Name = "toolStripMenuItem4";
			this.toolStripMenuItem4.Size = new System.Drawing.Size(184, 6);
			// 
			// единицыИзмеренияToolStripMenuItem
			// 
			this.единицыИзмеренияToolStripMenuItem.Name = "единицыИзмеренияToolStripMenuItem";
			this.единицыИзмеренияToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
			this.единицыИзмеренияToolStripMenuItem.Text = "&Единицы измерения";
			this.единицыИзмеренияToolStripMenuItem.Click += new System.EventHandler(this.ЕдиницыИзмеренияToolStripMenuItemClick);
			// 
			// окнаToolStripMenuItem
			// 
			this.окнаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.упорядочитьToolStripMenuItem});
			this.окнаToolStripMenuItem.Name = "окнаToolStripMenuItem";
			this.окнаToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
			this.окнаToolStripMenuItem.Text = "&Окна";
			// 
			// упорядочитьToolStripMenuItem
			// 
			this.упорядочитьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.каскадомToolStripMenuItem,
									this.вертикальноToolStripMenuItem,
									this.горизонтальноToolStripMenuItem});
			this.упорядочитьToolStripMenuItem.Name = "упорядочитьToolStripMenuItem";
			this.упорядочитьToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
			this.упорядочитьToolStripMenuItem.Text = "&Упорядочить";
			// 
			// каскадомToolStripMenuItem
			// 
			this.каскадомToolStripMenuItem.Name = "каскадомToolStripMenuItem";
			this.каскадомToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
			this.каскадомToolStripMenuItem.Text = "&Каскадом";
			this.каскадомToolStripMenuItem.Click += new System.EventHandler(this.КаскадомToolStripMenuItemClick);
			// 
			// вертикальноToolStripMenuItem
			// 
			this.вертикальноToolStripMenuItem.Name = "вертикальноToolStripMenuItem";
			this.вертикальноToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
			this.вертикальноToolStripMenuItem.Text = "&Вертикально";
			this.вертикальноToolStripMenuItem.Click += new System.EventHandler(this.ВертикальноToolStripMenuItemClick);
			// 
			// горизонтальноToolStripMenuItem
			// 
			this.горизонтальноToolStripMenuItem.Name = "горизонтальноToolStripMenuItem";
			this.горизонтальноToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
			this.горизонтальноToolStripMenuItem.Text = "&Горизонтально";
			this.горизонтальноToolStripMenuItem.Click += new System.EventHandler(this.ГоризонтальноToolStripMenuItemClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(584, 262);
			this.Controls.Add(this.menuStrip1);
			this.IsMdiContainer = true;
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainForm";
			this.Text = "StorageTemplate";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ToolStripMenuItem выгрузитьБазуToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem горизонтальноToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem вертикальноToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem каскадомToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem упорядочитьToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem окнаToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem единицыИзмеренияToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
		private System.Windows.Forms.ToolStripMenuItem получателиToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem поставщикиToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
		private System.Windows.Forms.ToolStripMenuItem наименованияToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem категорииToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem ответственныеЛицаToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem местаХраненияToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem справочникиToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem учётToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem загрузитьБазуToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem создатьToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
		private System.Windows.Forms.MenuStrip menuStrip1;
	}
}
