﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.225
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Blog.DAL
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="dbBlog")]
	public partial class LinqTodbBlogDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertUstawienia(Ustawienia instance);
    partial void UpdateUstawienia(Ustawienia instance);
    partial void DeleteUstawienia(Ustawienia instance);
    partial void InsertKomentarze(Komentarze instance);
    partial void UpdateKomentarze(Komentarze instance);
    partial void DeleteKomentarze(Komentarze instance);
    partial void InsertPosty(Posty instance);
    partial void UpdatePosty(Posty instance);
    partial void DeletePosty(Posty instance);
    partial void InsertTagi(Tagi instance);
    partial void UpdateTagi(Tagi instance);
    partial void DeleteTagi(Tagi instance);
    #endregion
		
		public LinqTodbBlogDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["dbBlogConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public LinqTodbBlogDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LinqTodbBlogDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LinqTodbBlogDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LinqTodbBlogDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Ustawienia> Ustawienias
		{
			get
			{
				return this.GetTable<Ustawienia>();
			}
		}
		
		public System.Data.Linq.Table<Komentarze> Komentarzes
		{
			get
			{
				return this.GetTable<Komentarze>();
			}
		}
		
		public System.Data.Linq.Table<Posty> Posties
		{
			get
			{
				return this.GetTable<Posty>();
			}
		}
		
		public System.Data.Linq.Table<Tagi> Tagis
		{
			get
			{
				return this.GetTable<Tagi>();
			}
		}
		
		public System.Data.Linq.Table<PostyTagi> PostyTagis
		{
			get
			{
				return this.GetTable<PostyTagi>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Ustawienia")]
	public partial class Ustawienia : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _key;
		
		private string _value;
		
		private string _description;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnkeyChanging(string value);
    partial void OnkeyChanged();
    partial void OnvalueChanging(string value);
    partial void OnvalueChanged();
    partial void OndescriptionChanging(string value);
    partial void OndescriptionChanged();
    #endregion
		
		public Ustawienia()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[key]", Storage="_key", DbType="VarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string key
		{
			get
			{
				return this._key;
			}
			set
			{
				if ((this._key != value))
				{
					this.OnkeyChanging(value);
					this.SendPropertyChanging();
					this._key = value;
					this.SendPropertyChanged("key");
					this.OnkeyChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_value", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string value
		{
			get
			{
				return this._value;
			}
			set
			{
				if ((this._value != value))
				{
					this.OnvalueChanging(value);
					this.SendPropertyChanging();
					this._value = value;
					this.SendPropertyChanged("value");
					this.OnvalueChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_description", DbType="VarChar(200)")]
		public string description
		{
			get
			{
				return this._description;
			}
			set
			{
				if ((this._description != value))
				{
					this.OndescriptionChanging(value);
					this.SendPropertyChanging();
					this._description = value;
					this.SendPropertyChanged("description");
					this.OndescriptionChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Komentarze")]
	public partial class Komentarze : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private int _id_posta;
		
		private string _tresc;
		
		private string _autor;
		
		private System.DateTime _data_dodania;
		
		private int _status;
		
		private EntityRef<Posty> _Posty;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void Onid_postaChanging(int value);
    partial void Onid_postaChanged();
    partial void OntrescChanging(string value);
    partial void OntrescChanged();
    partial void OnautorChanging(string value);
    partial void OnautorChanged();
    partial void Ondata_dodaniaChanging(System.DateTime value);
    partial void Ondata_dodaniaChanged();
    partial void OnstatusChanging(int value);
    partial void OnstatusChanged();
    #endregion
		
		public Komentarze()
		{
			this._Posty = default(EntityRef<Posty>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_posta", DbType="Int NOT NULL")]
		public int id_posta
		{
			get
			{
				return this._id_posta;
			}
			set
			{
				if ((this._id_posta != value))
				{
					if (this._Posty.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Onid_postaChanging(value);
					this.SendPropertyChanging();
					this._id_posta = value;
					this.SendPropertyChanged("id_posta");
					this.Onid_postaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tresc", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string tresc
		{
			get
			{
				return this._tresc;
			}
			set
			{
				if ((this._tresc != value))
				{
					this.OntrescChanging(value);
					this.SendPropertyChanging();
					this._tresc = value;
					this.SendPropertyChanged("tresc");
					this.OntrescChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_autor", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string autor
		{
			get
			{
				return this._autor;
			}
			set
			{
				if ((this._autor != value))
				{
					this.OnautorChanging(value);
					this.SendPropertyChanging();
					this._autor = value;
					this.SendPropertyChanged("autor");
					this.OnautorChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_data_dodania", DbType="DateTime NOT NULL")]
		public System.DateTime data_dodania
		{
			get
			{
				return this._data_dodania;
			}
			set
			{
				if ((this._data_dodania != value))
				{
					this.Ondata_dodaniaChanging(value);
					this.SendPropertyChanging();
					this._data_dodania = value;
					this.SendPropertyChanged("data_dodania");
					this.Ondata_dodaniaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_status", DbType="Int NOT NULL")]
		public int status
		{
			get
			{
				return this._status;
			}
			set
			{
				if ((this._status != value))
				{
					this.OnstatusChanging(value);
					this.SendPropertyChanging();
					this._status = value;
					this.SendPropertyChanged("status");
					this.OnstatusChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Posty_Komentarze", Storage="_Posty", ThisKey="id_posta", OtherKey="id", IsForeignKey=true)]
		public Posty Posty
		{
			get
			{
				return this._Posty.Entity;
			}
			set
			{
				Posty previousValue = this._Posty.Entity;
				if (((previousValue != value) 
							|| (this._Posty.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Posty.Entity = null;
						previousValue.Komentarzes.Remove(this);
					}
					this._Posty.Entity = value;
					if ((value != null))
					{
						value.Komentarzes.Add(this);
						this._id_posta = value.id;
					}
					else
					{
						this._id_posta = default(int);
					}
					this.SendPropertyChanged("Posty");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Posty")]
	public partial class Posty : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private System.DateTime _data_dodania;
		
		private string _tytul;
		
		private string _tresc;
		
		private int _status;
		
		private System.Nullable<System.DateTime> _data_modyfikacji;
		
		private EntitySet<Komentarze> _Komentarzes;
		
		private EntityRef<Tagi> _Tagi;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void Ondata_dodaniaChanging(System.DateTime value);
    partial void Ondata_dodaniaChanged();
    partial void OntytulChanging(string value);
    partial void OntytulChanged();
    partial void OntrescChanging(string value);
    partial void OntrescChanged();
    partial void OnstatusChanging(int value);
    partial void OnstatusChanged();
    partial void Ondata_modyfikacjiChanging(System.Nullable<System.DateTime> value);
    partial void Ondata_modyfikacjiChanged();
    #endregion
		
		public Posty()
		{
			this._Komentarzes = new EntitySet<Komentarze>(new Action<Komentarze>(this.attach_Komentarzes), new Action<Komentarze>(this.detach_Komentarzes));
			this._Tagi = default(EntityRef<Tagi>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_data_dodania", DbType="DateTime NOT NULL")]
		public System.DateTime data_dodania
		{
			get
			{
				return this._data_dodania;
			}
			set
			{
				if ((this._data_dodania != value))
				{
					this.Ondata_dodaniaChanging(value);
					this.SendPropertyChanging();
					this._data_dodania = value;
					this.SendPropertyChanged("data_dodania");
					this.Ondata_dodaniaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tytul", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string tytul
		{
			get
			{
				return this._tytul;
			}
			set
			{
				if ((this._tytul != value))
				{
					this.OntytulChanging(value);
					this.SendPropertyChanging();
					this._tytul = value;
					this.SendPropertyChanged("tytul");
					this.OntytulChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tresc", DbType="VarChar(MAX)")]
		public string tresc
		{
			get
			{
				return this._tresc;
			}
			set
			{
				if ((this._tresc != value))
				{
					this.OntrescChanging(value);
					this.SendPropertyChanging();
					this._tresc = value;
					this.SendPropertyChanged("tresc");
					this.OntrescChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_status", DbType="Int NOT NULL")]
		public int status
		{
			get
			{
				return this._status;
			}
			set
			{
				if ((this._status != value))
				{
					this.OnstatusChanging(value);
					this.SendPropertyChanging();
					this._status = value;
					this.SendPropertyChanged("status");
					this.OnstatusChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_data_modyfikacji", DbType="DateTime")]
		public System.Nullable<System.DateTime> data_modyfikacji
		{
			get
			{
				return this._data_modyfikacji;
			}
			set
			{
				if ((this._data_modyfikacji != value))
				{
					this.Ondata_modyfikacjiChanging(value);
					this.SendPropertyChanging();
					this._data_modyfikacji = value;
					this.SendPropertyChanged("data_modyfikacji");
					this.Ondata_modyfikacjiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Posty_Komentarze", Storage="_Komentarzes", ThisKey="id", OtherKey="id_posta")]
		public EntitySet<Komentarze> Komentarzes
		{
			get
			{
				return this._Komentarzes;
			}
			set
			{
				this._Komentarzes.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Posty_Tagi", Storage="_Tagi", ThisKey="id", OtherKey="id_posta", IsUnique=true, IsForeignKey=false)]
		public Tagi Tagi
		{
			get
			{
				return this._Tagi.Entity;
			}
			set
			{
				Tagi previousValue = this._Tagi.Entity;
				if (((previousValue != value) 
							|| (this._Tagi.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Tagi.Entity = null;
						previousValue.Posty = null;
					}
					this._Tagi.Entity = value;
					if ((value != null))
					{
						value.Posty = this;
					}
					this.SendPropertyChanged("Tagi");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Komentarzes(Komentarze entity)
		{
			this.SendPropertyChanging();
			entity.Posty = this;
		}
		
		private void detach_Komentarzes(Komentarze entity)
		{
			this.SendPropertyChanging();
			entity.Posty = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Tagi")]
	public partial class Tagi : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id_posta;
		
		private string _keywords;
		
		private string _description;
		
		private EntityRef<Posty> _Posty;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onid_postaChanging(int value);
    partial void Onid_postaChanged();
    partial void OnkeywordsChanging(string value);
    partial void OnkeywordsChanged();
    partial void OndescriptionChanging(string value);
    partial void OndescriptionChanged();
    #endregion
		
		public Tagi()
		{
			this._Posty = default(EntityRef<Posty>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_posta", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int id_posta
		{
			get
			{
				return this._id_posta;
			}
			set
			{
				if ((this._id_posta != value))
				{
					if (this._Posty.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Onid_postaChanging(value);
					this.SendPropertyChanging();
					this._id_posta = value;
					this.SendPropertyChanged("id_posta");
					this.Onid_postaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_keywords", DbType="VarChar(MAX)")]
		public string keywords
		{
			get
			{
				return this._keywords;
			}
			set
			{
				if ((this._keywords != value))
				{
					this.OnkeywordsChanging(value);
					this.SendPropertyChanging();
					this._keywords = value;
					this.SendPropertyChanged("keywords");
					this.OnkeywordsChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_description", DbType="NVarChar(MAX)")]
		public string description
		{
			get
			{
				return this._description;
			}
			set
			{
				if ((this._description != value))
				{
					this.OndescriptionChanging(value);
					this.SendPropertyChanging();
					this._description = value;
					this.SendPropertyChanged("description");
					this.OndescriptionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Posty_Tagi", Storage="_Posty", ThisKey="id_posta", OtherKey="id", IsForeignKey=true)]
		public Posty Posty
		{
			get
			{
				return this._Posty.Entity;
			}
			set
			{
				Posty previousValue = this._Posty.Entity;
				if (((previousValue != value) 
							|| (this._Posty.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Posty.Entity = null;
						previousValue.Tagi = null;
					}
					this._Posty.Entity = value;
					if ((value != null))
					{
						value.Tagi = this;
						this._id_posta = value.id;
					}
					else
					{
						this._id_posta = default(int);
					}
					this.SendPropertyChanged("Posty");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.PostyTagi")]
	public partial class PostyTagi
	{
		
		private int _id;
		
		private System.DateTime _data_dodania;
		
		private string _tytul;
		
		private string _tresc;
		
		private int _status;
		
		private System.Nullable<System.DateTime> _data_modyfikacji;
		
		private string _keywords;
		
		private string _description;
		
		public PostyTagi()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", DbType="Int NOT NULL")]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this._id = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_data_dodania", DbType="DateTime NOT NULL")]
		public System.DateTime data_dodania
		{
			get
			{
				return this._data_dodania;
			}
			set
			{
				if ((this._data_dodania != value))
				{
					this._data_dodania = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tytul", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string tytul
		{
			get
			{
				return this._tytul;
			}
			set
			{
				if ((this._tytul != value))
				{
					this._tytul = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tresc", DbType="VarChar(MAX) NOT NULL", CanBeNull=false)]
		public string tresc
		{
			get
			{
				return this._tresc;
			}
			set
			{
				if ((this._tresc != value))
				{
					this._tresc = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_status", DbType="Int NOT NULL")]
		public int status
		{
			get
			{
				return this._status;
			}
			set
			{
				if ((this._status != value))
				{
					this._status = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_data_modyfikacji", DbType="DateTime")]
		public System.Nullable<System.DateTime> data_modyfikacji
		{
			get
			{
				return this._data_modyfikacji;
			}
			set
			{
				if ((this._data_modyfikacji != value))
				{
					this._data_modyfikacji = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_keywords", DbType="VarChar(MAX)")]
		public string keywords
		{
			get
			{
				return this._keywords;
			}
			set
			{
				if ((this._keywords != value))
				{
					this._keywords = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_description", DbType="NVarChar(MAX)")]
		public string description
		{
			get
			{
				return this._description;
			}
			set
			{
				if ((this._description != value))
				{
					this._description = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
