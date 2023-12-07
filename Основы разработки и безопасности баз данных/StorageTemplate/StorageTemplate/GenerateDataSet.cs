/*
 * Created by SharpDevelop.
 * User: VET
 * Date: 24.01.2019
 * Time: 15:09
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.Common;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections.ObjectModel;
using System.Runtime.InteropServices;


namespace StorageTemplate
{
	/// <summary>
	/// Description of GenerateDataSet.
	/// </summary>
	public class GenerateDataSet
	{
		
		// Обявление имён экземпляров объектов
		public System.Data.DataSet dataSet1;
		public System.Data.DataTable MestHran;
		public System.Data.DataTable OtvLica;
		public System.Data.DataTable Kategor;
		public System.Data.DataTable Naimen;
		public System.Data.DataTable Postav;
		public System.Data.DataTable Poluch;
		public System.Data.DataTable EdIzm;
		public System.Data.DataTable Vydacha;
		public System.Data.DataTable Spisanie;
		public System.Data.DataTable Uchet;
		public System.Data.DataColumn id_mh;
		public System.Data.DataColumn naim_mh;
		public System.Data.DataColumn id_ol;
		public System.Data.DataColumn fio_ol;
		public System.Data.DataColumn tel_ol;
		public System.Data.DataColumn id_mh_fk;
		public System.Data.DataColumn id_kat;
		public System.Data.DataColumn naim_kat;
		public System.Data.DataColumn id_naim;
		public System.Data.DataColumn naim_naim;
		public System.Data.DataColumn id_post;
		public System.Data.DataColumn naim_post;
		public System.Data.DataColumn adress_post;
		public System.Data.DataColumn tel_post;
		public System.Data.DataColumn bank_post;
		public System.Data.DataColumn inn_post;
		public System.Data.DataColumn bik_post;
		public System.Data.DataColumn rs_post;
		public System.Data.DataColumn ks_post;
		public System.Data.DataColumn id_pol;
		public System.Data.DataColumn naim_pol;
		public System.Data.DataColumn adress_pol;
		public System.Data.DataColumn tel_pol;
		public System.Data.DataColumn bank_pol;
		public System.Data.DataColumn inn_pol;
		public System.Data.DataColumn bik_pol;
		public System.Data.DataColumn rs_pol;
		public System.Data.DataColumn ks_pol;
		public System.Data.DataColumn id_ed;
		public System.Data.DataColumn naim_ed;
		public System.Data.DataColumn id_pol_vyd;
		public System.Data.DataColumn id_mc_vyd;
		public System.Data.DataColumn kol_mc_vyd;
		public System.Data.DataColumn cena_vyd;
		public System.Data.DataColumn summa_vyd;
		public System.Data.DataColumn id_mc_sp;
		public System.Data.DataColumn kol_sp;
		public System.Data.DataColumn cena_sp;
		public System.Data.DataColumn summa_sp;
		public System.Data.DataColumn id_mc;
		public System.Data.DataColumn id_mh_uch;
		public System.Data.DataColumn id_ol_uch;
		public System.Data.DataColumn id_kat_uch;
		public System.Data.DataColumn id_post_uch;
		public System.Data.DataColumn id_naim_uch;
		public System.Data.DataColumn kol_nal;
		public System.Data.DataColumn cen_zak;
		public System.Data.DataColumn cen_roz;
		public System.Data.DataColumn sum_zak;
		public System.Data.DataColumn sum_roz;
		public System.Data.DataColumn data_post;
		public System.Data.DataRelation mhol;
		public System.Data.DataRelation mhuch;
		public System.Data.DataRelation polvyd;
		public System.Data.DataRelation uchvyd;
		public System.Data.DataRelation uchsp;
		public System.Data.DataRelation oluc;
		public System.Data.DataRelation katuch;
		public System.Data.DataRelation postuch;
		public System.Data.DataRelation naimuch;
		
		public GenerateDataSet()
		{
		}
		
		public void CreateDataSet()
		{
			// Создание экземпляра объекта класса DataSet
			this.dataSet1 = new System.Data.DataSet();
			
			// Создание экземпляров таблиц
			this.MestHran = new System.Data.DataTable();
			this.OtvLica = new System.Data.DataTable();
			this.Kategor = new System.Data.DataTable();
			this.Naimen = new System.Data.DataTable();
			this.Postav = new System.Data.DataTable();
			this.Poluch = new System.Data.DataTable();
			this.EdIzm = new System.Data.DataTable();
			this.Vydacha = new System.Data.DataTable();
			this.Spisanie = new System.Data.DataTable();
			this.Uchet = new System.Data.DataTable();
			
			// Создание экземпляров столбцов
			this.id_mh = new System.Data.DataColumn();
			this.naim_mh = new System.Data.DataColumn();
			this.id_ol = new System.Data.DataColumn();
			this.fio_ol = new System.Data.DataColumn();
			this.tel_ol = new System.Data.DataColumn();
			this.id_mh_fk = new System.Data.DataColumn();
			this.id_kat = new System.Data.DataColumn();
			this.naim_kat = new System.Data.DataColumn();
			this.id_naim = new System.Data.DataColumn();
			this.naim_naim = new System.Data.DataColumn();
			this.id_post = new System.Data.DataColumn();
			this.naim_post = new System.Data.DataColumn();
			this.adress_post = new System.Data.DataColumn();
			this.tel_post = new System.Data.DataColumn();
			this.bank_post = new System.Data.DataColumn();
			this.inn_post = new System.Data.DataColumn();
			this.bik_post = new System.Data.DataColumn();
			this.rs_post = new System.Data.DataColumn();
			this.ks_post = new System.Data.DataColumn();
			this.id_pol = new System.Data.DataColumn();
			this.naim_pol = new System.Data.DataColumn();
			this.adress_pol = new System.Data.DataColumn();
			this.tel_pol = new System.Data.DataColumn();
			this.bank_pol = new System.Data.DataColumn();
			this.inn_pol = new System.Data.DataColumn();
			this.bik_pol = new System.Data.DataColumn();
			this.rs_pol = new System.Data.DataColumn();
			this.ks_pol = new System.Data.DataColumn();
			this.id_ed = new System.Data.DataColumn();
			this.naim_ed = new System.Data.DataColumn();
			this.id_pol_vyd = new System.Data.DataColumn();
			this.id_mc_vyd = new System.Data.DataColumn();
			this.kol_mc_vyd = new System.Data.DataColumn();
			this.cena_vyd = new System.Data.DataColumn();
			this.summa_vyd = new System.Data.DataColumn();
			this.id_mc_sp = new System.Data.DataColumn();
			this.kol_sp = new System.Data.DataColumn();
			this.cena_sp = new System.Data.DataColumn();
			this.summa_sp = new System.Data.DataColumn();
			this.id_mc = new System.Data.DataColumn();
			this.id_mh_uch = new System.Data.DataColumn();
			this.id_ol_uch = new System.Data.DataColumn();
			this.id_kat_uch = new System.Data.DataColumn();
			this.id_post_uch = new System.Data.DataColumn();
			this.id_naim_uch = new System.Data.DataColumn();
			this.kol_nal = new System.Data.DataColumn();
			this.cen_zak = new System.Data.DataColumn();
			this.cen_roz = new System.Data.DataColumn();
			this.sum_zak = new System.Data.DataColumn();
			this.sum_roz = new System.Data.DataColumn();
			this.data_post = new System.Data.DataColumn();
			
			// Присвоение псевдонимов таблицам
			this.MestHran.TableName = "Места хранения";
			this.OtvLica.TableName = "Ответственные лица";
			this.Kategor.TableName = "Категории материальных ценностей";
			this.Naimen.TableName = "Наименования материальных ценностей";
			this.Postav.TableName = "Поставщики";
			this.Poluch.TableName = "Получатели";
			this.EdIzm.TableName = "Единицы измерения";
			this.Vydacha.TableName = "Учёт выдачи";
			this.Spisanie.TableName = "Учёт списания";
			this.Uchet.TableName = "Учёт материальных ценностей";
			
			// Присвоение псевдонимов столбцам
			this.id_mh.ColumnName = "пк";
			this.naim_mh.ColumnName = "Место хранения";
			this.id_ol.ColumnName = "пк";
			this.fio_ol.ColumnName = "Фамилия Имя Отчество";
			this.tel_ol.ColumnName = "Номер телефона";
			this.id_mh_fk.ColumnName = "вк";
			this.id_kat.ColumnName = "пк";
			this.naim_kat.ColumnName = "Наименование категории";
			this.id_naim.ColumnName = "пк";
			this.naim_naim.ColumnName = "Наименование";
			this.id_post.ColumnName = "пк";
			this.naim_post.ColumnName = "Наименование поставщика";
			this.adress_post.ColumnName = "Адрес";
			this.tel_post.ColumnName = "Телефон";
			this.bank_post.ColumnName = "Наименование банка";
			this.inn_post.ColumnName = "ИНН";
			this.bik_post.ColumnName = "БИК";
			this.rs_post.ColumnName = "Расчётный счёт";
			this.ks_post.ColumnName = "Корр. счёт";
			this.id_pol.ColumnName = "пк";
			this.naim_pol.ColumnName = "Наименование получателя";
			this.adress_pol.ColumnName = "Адрес";
			this.tel_pol.ColumnName = "Телефон";
			this.bank_pol.ColumnName = "Наименование банка";
			this.inn_pol.ColumnName = "ИНН";
			this.bik_pol.ColumnName = "БИК";
			this.rs_pol.ColumnName = "Расчётный счёт";
			this.ks_pol.ColumnName = "Корр. счёт";
			this.id_ed.ColumnName = "пк";
			this.naim_ed.ColumnName = "Единица измерения";
			this.id_pol_vyd.ColumnName = "пк";
			this.id_mc_vyd.ColumnName = "вк";
			this.kol_mc_vyd.ColumnName = "Количество";
			this.cena_vyd.ColumnName = "Цена";
			this.summa_vyd.ColumnName = "Сумма";
			this.id_mc_sp.ColumnName = "вк";
			this.kol_sp.ColumnName = "Количество";
			this.cena_sp.ColumnName = "Цена";
			this.summa_sp.ColumnName = "Сумма";
			this.id_mc.ColumnName = "пк";
			this.id_mh_uch.ColumnName = "вк";
			this.id_ol_uch.ColumnName = "вк1";
			this.id_kat_uch.ColumnName = "вк2";
			this.id_post_uch.ColumnName = "вк3";
			this.id_naim_uch.ColumnName = "вк4";
			this.kol_nal.ColumnName = "Количество";
			this.cen_zak.ColumnName = "Закупочная цена";
			this.cen_roz.ColumnName = "Розничная цена";
			this.sum_zak.ColumnName = "Сумма закупки";
			this.sum_roz.ColumnName = "Сумма розницы";
			this.data_post.ColumnName = "Дата поступления";
			
			// Добавление столбцов к таблицам
			this.MestHran.Columns.AddRange(new DataColumn[]{
			                               	id_mh,
			                               	naim_mh
			                               });
			
			this.OtvLica.Columns.AddRange(new DataColumn[]{
			                              	id_ol,
			                              	fio_ol,
			                              	tel_ol,
			                              	id_mh_fk
			                              });
			
			this.Kategor.Columns.AddRange(new DataColumn[]{
			                              	id_kat,
			                              	naim_kat
			                              });
			
			this.Naimen.Columns.AddRange(new DataColumn[]{
			                             	id_naim,
			                             	naim_naim
			                             });
			
			this.Postav.Columns.AddRange(new DataColumn[]{
			                             	id_post,
			                             	naim_post,
			                             	adress_post,
			                             	tel_post,
			                             	bank_post,
			                             	inn_post,
			                             	bik_post,
			                             	rs_post,
			                             	ks_post
			                             });
			
			this.Poluch.Columns.AddRange(new DataColumn[]{
			                             	id_pol,
			                             	naim_pol,
			                             	adress_pol,
			                             	tel_pol,
			                             	bank_pol,
			                             	inn_pol,
			                             	bik_pol,
			                             	rs_pol,
			                             	ks_pol
			                             });
			
			this.EdIzm.Columns.AddRange(new DataColumn[]{
			                            	id_ed,
			                            	naim_ed
			                            });
			
			this.Vydacha.Columns.AddRange(new DataColumn[]{
			                              	id_pol_vyd,
			                              	id_mc_vyd,
			                              	kol_mc_vyd,
			                              	cena_vyd,
			                              	summa_vyd
			                              });
			
			this.Spisanie.Columns.AddRange(new DataColumn[]{
			                               	id_mc_sp,
			                               	kol_sp,
			                               	cena_sp,
			                               	summa_sp
			                               });
			
			this.Uchet.Columns.AddRange(new DataColumn[]{
			                            	id_mc,
			                            	id_mh_uch,
			                            	id_ol_uch,
			                            	id_kat_uch,
			                            	id_post_uch,
			                            	id_naim_uch,
			                            	kol_nal,
			                            	cen_zak,
			                            	cen_roz,
			                            	sum_zak,
			                            	sum_roz,
			                            	data_post
			                            });
			
			
			// Определение свойств столбцов
			this.id_mh.DataType = typeof(System.Guid);
			this.id_mh.AllowDBNull = false;
			this.id_mh.ReadOnly = true;
			this.id_mh.Unique = true;
			this.id_mh.DefaultValue = Guid.NewGuid();
			
			this.naim_mh.DataType = typeof(System.String);
			this.naim_mh.AllowDBNull = true;
			this.naim_mh.ReadOnly = false;
			this.naim_mh.Unique = false;
			this.naim_mh.MaxLength = 30;
			
			this.id_ol.DataType = typeof(System.Guid);
			this.id_ol.AllowDBNull = false;
			this.id_ol.ReadOnly = true;
			this.id_ol.Unique = true;
			this.id_ol.DefaultValue = Guid.NewGuid();
			
			this.fio_ol.DataType = typeof(System.String);
			this.fio_ol.AllowDBNull = true;
			this.fio_ol.ReadOnly = false;
			this.fio_ol.Unique = false;
			this.fio_ol.MaxLength = 50;
			
			this.tel_ol.DataType = typeof(System.String);
			this.tel_ol.AllowDBNull = true;
			this.tel_ol.ReadOnly = false;
			this.tel_ol.Unique = false;
			this.tel_ol.MaxLength = 12;
			
			this.id_mh_fk.DataType = typeof(System.Guid);
			this.id_mh_fk.AllowDBNull = false;
			this.id_mh_fk.ReadOnly = true;
			this.id_mh_fk.Unique = false;
			
			this.id_kat.DataType = typeof(System.Guid);
			this.id_kat.AllowDBNull = false;
			this.id_kat.ReadOnly = true;
			this.id_kat.Unique = true;
			this.id_kat.DefaultValue = Guid.NewGuid();
			
			this.naim_kat.DataType = typeof(System.String);
			this.naim_kat.AllowDBNull = true;
			this.naim_kat.ReadOnly = false;
			this.naim_kat.Unique = false;
			this.naim_kat.MaxLength = 35;
			
			this.id_naim.DataType = typeof(System.Guid);
			this.id_naim.AllowDBNull = false;
			this.id_naim.ReadOnly = true;
			this.id_naim.Unique = true;
			this.id_naim.DefaultValue = Guid.NewGuid();
			
			this.naim_naim.DataType = typeof(System.String);
			this.naim_naim.AllowDBNull = true;
			this.naim_naim.ReadOnly = false;
			this.naim_naim.Unique = false;
			this.naim_naim.MaxLength = 50;
			
			this.id_post.DataType = typeof(System.Guid);
			this.id_post.AllowDBNull = false;
			this.id_post.ReadOnly = true;
			this.id_post.Unique = true;
			this.id_post.DefaultValue = Guid.NewGuid();
			
			this.naim_post.DataType = typeof(System.String);
			this.naim_post.AllowDBNull = true;
			this.naim_post.ReadOnly = false;
			this.naim_post.Unique = false;
			this.naim_post.MaxLength = 50;
			
			this.adress_post.DataType = typeof(System.String);
			this.adress_post.AllowDBNull = true;
			this.adress_post.ReadOnly = false;
			this.adress_post.Unique = false;
			this.adress_post.MaxLength = 100;
			
			this.tel_post.DataType = typeof(System.String);
			this.tel_post.AllowDBNull = true;
			this.tel_post.ReadOnly = false;
			this.tel_post.Unique = false;
			this.tel_post.MaxLength = 12;
			
			this.bank_post.DataType = typeof(System.String);
			this.bank_post.AllowDBNull = true;
			this.bank_post.ReadOnly = false;
			this.bank_post.Unique = false;
			this.bank_post.MaxLength = 50;
			
			this.inn_post.DataType = typeof(System.String);
			this.inn_post.AllowDBNull = true;
			this.inn_post.ReadOnly = false;
			this.inn_post.Unique = false;
			this.inn_post.MaxLength = 25;
			
			this.bik_post.DataType = typeof(System.String);
			this.bik_post.AllowDBNull = true;
			this.bik_post.ReadOnly = false;
			this.bik_post.Unique = false;
			this.bik_post.MaxLength = 15;
			
			this.rs_post.DataType = typeof(System.String);
			this.rs_post.AllowDBNull = true;
			this.rs_post.ReadOnly = false;
			this.rs_post.Unique = false;
			this.rs_post.MaxLength = 25;
			
			this.ks_post.DataType = typeof(System.String);
			this.ks_post.AllowDBNull = true;
			this.ks_post.ReadOnly = false;
			this.ks_post.Unique = false;
			this.ks_post.MaxLength = 25;
			
			this.id_pol.DataType = typeof(System.Guid);
			this.id_pol.AllowDBNull = false;
			this.id_pol.ReadOnly = true;
			this.id_pol.Unique = true;
			this.id_pol.DefaultValue = Guid.NewGuid();
			
			this.naim_pol.DataType = typeof(System.String);
			this.naim_pol.AllowDBNull = true;
			this.naim_pol.ReadOnly = false;
			this.naim_pol.Unique = false;
			this.naim_pol.MaxLength = 50;
			
			this.adress_pol.DataType = typeof(System.String);
			this.adress_pol.AllowDBNull = true;
			this.adress_pol.ReadOnly = false;
			this.adress_pol.Unique = false;
			this.adress_pol.MaxLength = 100;
			
			this.tel_pol.DataType = typeof(System.String);
			this.tel_pol.AllowDBNull = true;
			this.tel_pol.ReadOnly = false;
			this.tel_pol.Unique = false;
			this.tel_pol.MaxLength = 12;
			
			this.bank_pol.DataType = typeof(System.String);
			this.bank_pol.AllowDBNull = true;
			this.bank_pol.ReadOnly = false;
			this.bank_pol.Unique = false;
			this.bank_pol.MaxLength = 50;
			
			this.inn_pol.DataType = typeof(System.String);
			this.inn_pol.AllowDBNull = true;
			this.inn_pol.ReadOnly = false;
			this.inn_pol.Unique = false;
			this.inn_pol.MaxLength = 25;
			
			this.bik_pol.DataType = typeof(System.String);
			this.bik_pol.AllowDBNull = true;
			this.bik_pol.ReadOnly = false;
			this.bik_pol.Unique = false;
			this.bik_pol.MaxLength = 15;
			
			this.rs_pol.DataType = typeof(System.String);
			this.rs_pol.AllowDBNull = true;
			this.rs_pol.ReadOnly = false;
			this.rs_pol.Unique = false;
			this.rs_pol.MaxLength = 25;
			
			this.ks_pol.DataType = typeof(System.String);
			this.ks_pol.AllowDBNull = true;
			this.ks_pol.ReadOnly = false;
			this.ks_pol.Unique = false;
			this.ks_pol.MaxLength = 25;
			
			this.id_ed.DataType = typeof(System.Guid);
			this.id_ed.AllowDBNull = false;
			this.id_ed.ReadOnly = true;
			this.id_ed.Unique = true;
			this.id_ed.DefaultValue = Guid.NewGuid();
			
			this.naim_ed.DataType = typeof(System.String);
			this.naim_ed.AllowDBNull = true;
			this.naim_ed.ReadOnly = false;
			this.naim_ed.Unique = false;
			this.naim_ed.MaxLength = 25;
			
			this.id_pol_vyd.DataType = typeof(System.Guid);
			this.id_pol_vyd.AllowDBNull = false;
			this.id_pol_vyd.ReadOnly = true;
			this.id_pol_vyd.Unique = false;
			
			this.id_mc_vyd.DataType = typeof(System.Guid);
			this.id_mc_vyd.AllowDBNull = false;
			this.id_mc_vyd.ReadOnly = true;
			this.id_mc_vyd.Unique = false;
			
			this.kol_mc_vyd.DataType = typeof(System.Decimal);
			this.kol_mc_vyd.AllowDBNull = true;
			this.kol_mc_vyd.ReadOnly = false;
			this.kol_mc_vyd.Unique = false;
			
			this.cena_vyd.DataType = typeof(System.Decimal);
			this.cena_vyd.AllowDBNull = true;
			this.cena_vyd.ReadOnly = false;
			this.cena_vyd.Unique = false;
			
			this.summa_vyd.DataType = typeof(System.Decimal);
			this.summa_vyd.AllowDBNull = true;
			this.summa_vyd.ReadOnly = false;
			this.summa_vyd.Unique = false;
			
			this.id_mc_sp.DataType = typeof(System.Guid);
			this.id_mc_sp.AllowDBNull = false;
			this.id_mc_sp.ReadOnly = true;
			this.id_mc_sp.Unique = false;
			
			this.kol_sp.DataType = typeof(System.Decimal);
			this.kol_sp.AllowDBNull = true;
			this.kol_sp.ReadOnly = false;
			this.kol_sp.Unique = false;
			
			this.cena_sp.DataType = typeof(System.Decimal);
			this.cena_sp.AllowDBNull = true;
			this.cena_sp.ReadOnly = false;
			this.cena_sp.Unique = false;
			
			this.summa_sp.DataType = typeof(System.Decimal);
			this.summa_sp.AllowDBNull = true;
			this.summa_sp.ReadOnly = false;
			this.summa_sp.Unique = false;
			
			this.id_mc.DataType = typeof(System.Guid);
			this.id_mc.AllowDBNull = false;
			this.id_mc.ReadOnly = true;
			this.id_mc.Unique = true;
			this.id_mc.DefaultValue = Guid.NewGuid();
			
			this.id_mh_uch.DataType = typeof(System.Guid);
			this.id_mh_uch.AllowDBNull = false;
			this.id_mh_uch.ReadOnly = true;
			this.id_mh_uch.Unique = false;
			
			this.id_ol_uch.DataType = typeof(System.Guid);
			this.id_ol_uch.AllowDBNull = false;
			this.id_ol_uch.ReadOnly = true;
			this.id_ol_uch.Unique = false;
			
			this.id_kat_uch.DataType = typeof(System.Guid);
			this.id_kat_uch.AllowDBNull = false;
			this.id_kat_uch.ReadOnly = true;
			this.id_kat_uch.Unique = false;
			
			this.id_post_uch.DataType = typeof(System.Guid);
			this.id_post_uch.AllowDBNull = false;
			this.id_post_uch.ReadOnly = true;
			this.id_post_uch.Unique = false;
			
			this.id_naim_uch.DataType = typeof(System.Guid);
			this.id_naim_uch.AllowDBNull = false;
			this.id_naim_uch.ReadOnly = true;
			this.id_naim_uch.Unique = false;
			
			this.kol_nal.DataType = typeof(System.Decimal);
			this.kol_nal.AllowDBNull = true;
			this.kol_nal.ReadOnly = false;
			this.kol_nal.Unique = false;
			
			this.cen_zak.DataType = typeof(System.Decimal);
			this.cen_zak.AllowDBNull = true;
			this.cen_zak.ReadOnly = false;
			this.cen_zak.Unique = false;
			
			this.cen_roz.DataType = typeof(System.Decimal);
			this.cen_roz.AllowDBNull = true;
			this.cen_roz.ReadOnly = false;
			this.cen_roz.Unique = false;
			
			this.sum_zak.DataType = typeof(System.Decimal);
			this.sum_zak.AllowDBNull = true;
			this.sum_zak.ReadOnly = false;
			this.sum_zak.Unique = false;
			
			this.sum_roz.DataType = typeof(System.Decimal);
			this.sum_roz.AllowDBNull = true;
			this.sum_roz.ReadOnly = false;
			this.sum_roz.Unique = false;
			
			this.data_post.DataType = typeof(System.DateTime);
			this.data_post.AllowDBNull = true;
			this.data_post.ReadOnly = false;
			this.data_post.Unique = false;
			
			// Добавление таблиц в объект DataSet
			this.dataSet1.Tables.AddRange(new DataTable[]{
			                              	MestHran,
			                              	OtvLica,
			                              	Kategor,
			                              	Naimen,
			                              	Postav,
			                              	Poluch,
			                              	EdIzm,
			                              	Vydacha,
			                              	Spisanie,
			                              	Uchet
			                              });
			
			// Установка первичных ключей
			this.MestHran.PrimaryKey = new DataColumn[]{
				id_mh
			};
			
			this.OtvLica.PrimaryKey = new DataColumn[]{
				id_ol
			};
			
			this.Kategor.PrimaryKey = new DataColumn[]{
				id_kat
			};
			
			this.Naimen.PrimaryKey = new DataColumn[]{
				id_naim
			};
			
			this.Postav.PrimaryKey = new DataColumn[]{
				id_post
			};
			
			this.Poluch.PrimaryKey = new DataColumn[]{
				id_pol
			};
			
			this.EdIzm.PrimaryKey = new DataColumn[]{
				id_ed
			};
			
			this.Uchet.PrimaryKey = new DataColumn[]{
				id_mc
			};
			
			
			// Создание отношений и ограничений
			ForeignKeyConstraint mholcon = new ForeignKeyConstraint(MestHran.Columns["пк"],
			                                                        OtvLica.Columns["вк"]);
			mholcon.ConstraintName = "mholcon";
			mholcon.DeleteRule = Rule.Cascade;
			mholcon.UpdateRule = Rule.Cascade;
			dataSet1.Tables["Ответственные лица"].Constraints.Add(mholcon);
			
			mhol = new DataRelation("mhol",MestHran.Columns["пк"],
			                        OtvLica.Columns["вк"]);
			dataSet1.Relations.Add(mhol);
			
			ForeignKeyConstraint mhuchcon = new ForeignKeyConstraint(MestHran.Columns["пк"],
			                                                         Uchet.Columns["вк"]);
			mhuchcon.ConstraintName = "mhuchcon";
			mhuchcon.DeleteRule = Rule.Cascade;
			mhuchcon.UpdateRule = Rule.Cascade;
			dataSet1.Tables["Учёт материальных ценностей"].Constraints.Add(mhuchcon);
			
			mhuch = new DataRelation("mhuch",MestHran.Columns["пк"],
			                         Uchet.Columns["вк"]);
			dataSet1.Relations.Add(mhuch);
			
			ForeignKeyConstraint polvydcon = new ForeignKeyConstraint(Poluch.Columns["пк"],
			                                                          Vydacha.Columns["пк"]);
			polvydcon.ConstraintName = "polvydcon";
			polvydcon.DeleteRule = Rule.Cascade;
			polvydcon.UpdateRule = Rule.Cascade;
			dataSet1.Tables["Учёт выдачи"].Constraints.Add(polvydcon);
			
			polvyd = new DataRelation("polvyd",Poluch.Columns["пк"],
			                          Vydacha.Columns["пк"]);
			dataSet1.Relations.Add(polvyd);
			
			ForeignKeyConstraint uchvydcon = new ForeignKeyConstraint(Uchet.Columns["пк"],
			                                                          Vydacha.Columns["вк"]);
			uchvydcon.ConstraintName = "uchvydcon";
			uchvydcon.DeleteRule = Rule.Cascade;
			uchvydcon.UpdateRule = Rule.Cascade;
			dataSet1.Tables["Учёт выдачи"].Constraints.Add(uchvydcon);
			
			uchvyd = new DataRelation("uchvyd",Uchet.Columns["пк"],
			                          Vydacha.Columns["вк"]);
			dataSet1.Relations.Add(uchvyd);
			
			ForeignKeyConstraint uchspcon = new ForeignKeyConstraint(Uchet.Columns["пк"],
			                                                         Spisanie.Columns["вк"]);
			uchspcon.ConstraintName = "uchspcon";
			uchspcon.DeleteRule = Rule.Cascade;
			uchspcon.UpdateRule = Rule.Cascade;
			dataSet1.Tables["Учёт списания"].Constraints.Add(uchspcon);
			
			uchsp = new DataRelation("uchsp",Uchet.Columns["пк"],
			                         Spisanie.Columns["вк"]);
			dataSet1.Relations.Add(uchsp);
			
			ForeignKeyConstraint oluccon = new ForeignKeyConstraint(OtvLica.Columns["пк"],
			                                                        Uchet.Columns["вк"]);
			oluccon.ConstraintName = "oluccon";
			oluccon.DeleteRule = Rule.Cascade;
			oluccon.UpdateRule = Rule.Cascade;
			dataSet1.Tables["Учёт материальных ценностей"].Constraints.Add(oluccon);
			
			oluc = new DataRelation("oluc",OtvLica.Columns["пк"],
			                        Uchet.Columns["вк"]);
			dataSet1.Relations.Add(oluc);
			
			ForeignKeyConstraint katuchcon = new ForeignKeyConstraint(Kategor.Columns["пк"],
			                                                          Uchet.Columns["вк"]);
			katuchcon.ConstraintName = "katuchcon";
			katuchcon.DeleteRule = Rule.Cascade;
			katuchcon.UpdateRule = Rule.Cascade;
			dataSet1.Tables["Учёт материальных ценностей"].Constraints.Add(katuchcon);
			
			katuch = new DataRelation("katuch",Kategor.Columns["пк"],
			                          Uchet.Columns["вк"]);
			dataSet1.Relations.Add(katuch);
			
			ForeignKeyConstraint postuchcon = new ForeignKeyConstraint(Postav.Columns["пк"],
			                                                           Uchet.Columns["вк"]);
			postuchcon.ConstraintName = "postuchcon";
			postuchcon.DeleteRule = Rule.Cascade;
			postuchcon.UpdateRule = Rule.Cascade;
			dataSet1.Tables["Учёт материальных ценностей"].Constraints.Add(postuchcon);
			
			postuch = new DataRelation("postuch",Postav.Columns["пк"],
			                           Uchet.Columns["вк"]);
			dataSet1.Relations.Add(postuch);
			
			ForeignKeyConstraint naimuchcon = new ForeignKeyConstraint(Naimen.Columns["пк"],
			                                                           Uchet.Columns["вк"]);
			naimuchcon.ConstraintName = "naimuchcon";
			naimuchcon.DeleteRule = Rule.Cascade;
			naimuchcon.UpdateRule = Rule.Cascade;
			dataSet1.Tables["Учёт материальных ценностей"].Constraints.Add(naimuchcon);
			
			naimuch = new DataRelation("naimuch",Naimen.Columns["пк"],
			                           Uchet.Columns["вк"]);
			dataSet1.Relations.Add(naimuch);
			
			dataSet1.EnforceConstraints = true;

			
		}
	}
}
