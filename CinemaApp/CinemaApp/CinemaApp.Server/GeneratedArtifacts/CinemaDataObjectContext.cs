﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Data.EntityClient;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;

[assembly: EdmSchemaAttribute()]
#region EDM Relationship Metadata

[assembly: EdmRelationshipAttribute("LightSwitchApplication", "FK_Zaal_Bioscoop", "Bioscoop", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(LightSwitchApplication.Implementation.Bioscoop), "Zaal", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(LightSwitchApplication.Implementation.Zaal), true)]
[assembly: EdmRelationshipAttribute("LightSwitchApplication", "FK_Voorstelling_Film", "Film", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(LightSwitchApplication.Implementation.Film), "Voorstelling", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(LightSwitchApplication.Implementation.Voorstelling), true)]
[assembly: EdmRelationshipAttribute("LightSwitchApplication", "FK_Voorstelling_Zaal", "Zaal", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(LightSwitchApplication.Implementation.Zaal), "Voorstelling", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(LightSwitchApplication.Implementation.Voorstelling), true)]

#endregion

namespace LightSwitchApplication.Implementation
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class CinemaData : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new CinemaData object using the connection string found in the 'CinemaData' section of the application configuration file.
        /// </summary>
        public CinemaData() : base("name=CinemaData", "CinemaData")
        {
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new CinemaData object.
        /// </summary>
        public CinemaData(string connectionString) : base(connectionString, "CinemaData")
        {
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new CinemaData object.
        /// </summary>
        public CinemaData(EntityConnection connection) : base(connection, "CinemaData")
        {
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Bioscoop> Bioscoops
        {
            get
            {
                if ((_Bioscoops == null))
                {
                    _Bioscoops = base.CreateObjectSet<Bioscoop>("Bioscoops");
                }
                return _Bioscoops;
            }
        }
        private ObjectSet<Bioscoop> _Bioscoops;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Film> Films
        {
            get
            {
                if ((_Films == null))
                {
                    _Films = base.CreateObjectSet<Film>("Films");
                }
                return _Films;
            }
        }
        private ObjectSet<Film> _Films;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Voorstelling> Voorstellings
        {
            get
            {
                if ((_Voorstellings == null))
                {
                    _Voorstellings = base.CreateObjectSet<Voorstelling>("Voorstellings");
                }
                return _Voorstellings;
            }
        }
        private ObjectSet<Voorstelling> _Voorstellings;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Zaal> Zaals
        {
            get
            {
                if ((_Zaals == null))
                {
                    _Zaals = base.CreateObjectSet<Zaal>("Zaals");
                }
                return _Zaals;
            }
        }
        private ObjectSet<Zaal> _Zaals;

        #endregion

        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Bioscoops EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToBioscoops(Bioscoop bioscoop)
        {
            base.AddObject("Bioscoops", bioscoop);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Films EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToFilms(Film film)
        {
            base.AddObject("Films", film);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Voorstellings EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToVoorstellings(Voorstelling voorstelling)
        {
            base.AddObject("Voorstellings", voorstelling);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Zaals EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToZaals(Zaal zaal)
        {
            base.AddObject("Zaals", zaal);
        }

        #endregion

    }

    #endregion

    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="LightSwitchApplication", Name="Bioscoop")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Bioscoop : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Bioscoop object.
        /// </summary>
        /// <param name="bioscoopId">Initial value of the BioscoopId property.</param>
        /// <param name="naam">Initial value of the Naam property.</param>
        /// <param name="stad">Initial value of the Stad property.</param>
        public static Bioscoop CreateBioscoop(global::System.Int32 bioscoopId, global::System.String naam, global::System.String stad)
        {
            Bioscoop bioscoop = new Bioscoop();
            bioscoop.BioscoopId = bioscoopId;
            bioscoop.Naam = naam;
            bioscoop.Stad = stad;
            return bioscoop;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 BioscoopId
        {
            get
            {
                return _BioscoopId;
            }
            set
            {
                if (_BioscoopId != value)
                {
                    OnBioscoopIdChanging(value);
                    ReportPropertyChanging("BioscoopId");
                    _BioscoopId = value;
                    ReportPropertyChanged("BioscoopId");
                    OnBioscoopIdChanged();
                }
            }
        }
        private global::System.Int32 _BioscoopId;
        partial void OnBioscoopIdChanging(global::System.Int32 value);
        partial void OnBioscoopIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Naam
        {
            get
            {
                return _Naam;
            }
            set
            {
                OnNaamChanging(value);
                ReportPropertyChanging("Naam");
                _Naam = value;
                ReportPropertyChanged("Naam");
                OnNaamChanged();
            }
        }
        private global::System.String _Naam;
        partial void OnNaamChanging(global::System.String value);
        partial void OnNaamChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Stad
        {
            get
            {
                return _Stad;
            }
            set
            {
                OnStadChanging(value);
                ReportPropertyChanging("Stad");
                _Stad = value;
                ReportPropertyChanged("Stad");
                OnStadChanged();
            }
        }
        private global::System.String _Stad;
        partial void OnStadChanging(global::System.String value);
        partial void OnStadChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Email
        {
            get
            {
                return _Email;
            }
            set
            {
                OnEmailChanging(value);
                ReportPropertyChanging("Email");
                _Email = value;
                ReportPropertyChanged("Email");
                OnEmailChanged();
            }
        }
        private global::System.String _Email;
        partial void OnEmailChanging(global::System.String value);
        partial void OnEmailChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Telefoon
        {
            get
            {
                return _Telefoon;
            }
            set
            {
                OnTelefoonChanging(value);
                ReportPropertyChanging("Telefoon");
                _Telefoon = value;
                ReportPropertyChanged("Telefoon");
                OnTelefoonChanged();
            }
        }
        private global::System.String _Telefoon;
        partial void OnTelefoonChanging(global::System.String value);
        partial void OnTelefoonChanged();

        #endregion

    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("LightSwitchApplication", "FK_Zaal_Bioscoop", "Zaal")]
        public EntityCollection<Zaal> Zaals
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Zaal>("LightSwitchApplication.FK_Zaal_Bioscoop", "Zaal");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Zaal>("LightSwitchApplication.FK_Zaal_Bioscoop", "Zaal", value);
                }
            }
        }

        #endregion

    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="LightSwitchApplication", Name="Film")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Film : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Film object.
        /// </summary>
        /// <param name="filmId">Initial value of the FilmId property.</param>
        /// <param name="titel">Initial value of the Titel property.</param>
        public static Film CreateFilm(global::System.Int32 filmId, global::System.String titel)
        {
            Film film = new Film();
            film.FilmId = filmId;
            film.Titel = titel;
            return film;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 FilmId
        {
            get
            {
                return _FilmId;
            }
            set
            {
                if (_FilmId != value)
                {
                    OnFilmIdChanging(value);
                    ReportPropertyChanging("FilmId");
                    _FilmId = value;
                    ReportPropertyChanged("FilmId");
                    OnFilmIdChanged();
                }
            }
        }
        private global::System.Int32 _FilmId;
        partial void OnFilmIdChanging(global::System.Int32 value);
        partial void OnFilmIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Titel
        {
            get
            {
                return _Titel;
            }
            set
            {
                OnTitelChanging(value);
                ReportPropertyChanging("Titel");
                _Titel = value;
                ReportPropertyChanged("Titel");
                OnTitelChanged();
            }
        }
        private global::System.String _Titel;
        partial void OnTitelChanging(global::System.String value);
        partial void OnTitelChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> Lengte
        {
            get
            {
                return _Lengte;
            }
            set
            {
                OnLengteChanging(value);
                ReportPropertyChanging("Lengte");
                _Lengte = value;
                ReportPropertyChanged("Lengte");
                OnLengteChanged();
            }
        }
        private Nullable<global::System.Int32> _Lengte;
        partial void OnLengteChanging(Nullable<global::System.Int32> value);
        partial void OnLengteChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.DateTime> ReleaseDatum
        {
            get
            {
                return _ReleaseDatum;
            }
            set
            {
                OnReleaseDatumChanging(value);
                ReportPropertyChanging("ReleaseDatum");
                _ReleaseDatum = value;
                ReportPropertyChanged("ReleaseDatum");
                OnReleaseDatumChanged();
            }
        }
        private Nullable<global::System.DateTime> _ReleaseDatum;
        partial void OnReleaseDatumChanging(Nullable<global::System.DateTime> value);
        partial void OnReleaseDatumChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Byte> DrieD
        {
            get
            {
                return _DrieD;
            }
            set
            {
                OnDrieDChanging(value);
                ReportPropertyChanging("DrieD");
                _DrieD = value;
                ReportPropertyChanged("DrieD");
                OnDrieDChanged();
            }
        }
        private Nullable<global::System.Byte> _DrieD;
        partial void OnDrieDChanging(Nullable<global::System.Byte> value);
        partial void OnDrieDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> LeeftijdIndicatie
        {
            get
            {
                return _LeeftijdIndicatie;
            }
            set
            {
                OnLeeftijdIndicatieChanging(value);
                ReportPropertyChanging("LeeftijdIndicatie");
                _LeeftijdIndicatie = value;
                ReportPropertyChanged("LeeftijdIndicatie");
                OnLeeftijdIndicatieChanged();
            }
        }
        private Nullable<global::System.Int32> _LeeftijdIndicatie;
        partial void OnLeeftijdIndicatieChanging(Nullable<global::System.Int32> value);
        partial void OnLeeftijdIndicatieChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.Byte[] Afbeelding
        {
            get
            {
                return StructuralObject.GetValidValue(_Afbeelding);
            }
            set
            {
                OnAfbeeldingChanging(value);
                ReportPropertyChanging("Afbeelding");
                _Afbeelding = value;
                ReportPropertyChanged("Afbeelding");
                OnAfbeeldingChanged();
            }
        }
        private global::System.Byte[] _Afbeelding;
        partial void OnAfbeeldingChanging(global::System.Byte[] value);
        partial void OnAfbeeldingChanged();

        #endregion

    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("LightSwitchApplication", "FK_Voorstelling_Film", "Voorstelling")]
        public EntityCollection<Voorstelling> Voorstellings
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Voorstelling>("LightSwitchApplication.FK_Voorstelling_Film", "Voorstelling");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Voorstelling>("LightSwitchApplication.FK_Voorstelling_Film", "Voorstelling", value);
                }
            }
        }

        #endregion

    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="LightSwitchApplication", Name="Voorstelling")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Voorstelling : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Voorstelling object.
        /// </summary>
        /// <param name="voorstellingId">Initial value of the VoorstellingId property.</param>
        /// <param name="datum">Initial value of the Datum property.</param>
        /// <param name="tijdstip">Initial value of the Tijdstip property.</param>
        /// <param name="filmId">Initial value of the FilmId property.</param>
        /// <param name="zaalId">Initial value of the ZaalId property.</param>
        public static Voorstelling CreateVoorstelling(global::System.Int32 voorstellingId, global::System.DateTime datum, global::System.TimeSpan tijdstip, global::System.Int32 filmId, global::System.Int32 zaalId)
        {
            Voorstelling voorstelling = new Voorstelling();
            voorstelling.VoorstellingId = voorstellingId;
            voorstelling.Datum = datum;
            voorstelling.Tijdstip = tijdstip;
            voorstelling.FilmId = filmId;
            voorstelling.ZaalId = zaalId;
            return voorstelling;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 VoorstellingId
        {
            get
            {
                return _VoorstellingId;
            }
            set
            {
                if (_VoorstellingId != value)
                {
                    OnVoorstellingIdChanging(value);
                    ReportPropertyChanging("VoorstellingId");
                    _VoorstellingId = value;
                    ReportPropertyChanged("VoorstellingId");
                    OnVoorstellingIdChanged();
                }
            }
        }
        private global::System.Int32 _VoorstellingId;
        partial void OnVoorstellingIdChanging(global::System.Int32 value);
        partial void OnVoorstellingIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.DateTime Datum
        {
            get
            {
                return _Datum;
            }
            set
            {
                OnDatumChanging(value);
                ReportPropertyChanging("Datum");
                _Datum = value;
                ReportPropertyChanged("Datum");
                OnDatumChanged();
            }
        }
        private global::System.DateTime _Datum;
        partial void OnDatumChanging(global::System.DateTime value);
        partial void OnDatumChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.TimeSpan Tijdstip
        {
            get
            {
                return _Tijdstip;
            }
            set
            {
                OnTijdstipChanging(value);
                ReportPropertyChanging("Tijdstip");
                _Tijdstip = value;
                ReportPropertyChanged("Tijdstip");
                OnTijdstipChanged();
            }
        }
        private global::System.TimeSpan _Tijdstip;
        partial void OnTijdstipChanging(global::System.TimeSpan value);
        partial void OnTijdstipChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Decimal> Prijs
        {
            get
            {
                return _Prijs;
            }
            set
            {
                OnPrijsChanging(value);
                ReportPropertyChanging("Prijs");
                _Prijs = value;
                ReportPropertyChanged("Prijs");
                OnPrijsChanged();
            }
        }
        private Nullable<global::System.Decimal> _Prijs;
        partial void OnPrijsChanging(Nullable<global::System.Decimal> value);
        partial void OnPrijsChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 FilmId
        {
            get
            {
                return _FilmId;
            }
            set
            {
                OnFilmIdChanging(value);
                ReportPropertyChanging("FilmId");
                _FilmId = value;
                ReportPropertyChanged("FilmId");
                OnFilmIdChanged();
            }
        }
        private global::System.Int32 _FilmId;
        partial void OnFilmIdChanging(global::System.Int32 value);
        partial void OnFilmIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 ZaalId
        {
            get
            {
                return _ZaalId;
            }
            set
            {
                OnZaalIdChanging(value);
                ReportPropertyChanging("ZaalId");
                _ZaalId = value;
                ReportPropertyChanged("ZaalId");
                OnZaalIdChanged();
            }
        }
        private global::System.Int32 _ZaalId;
        partial void OnZaalIdChanging(global::System.Int32 value);
        partial void OnZaalIdChanged();

        #endregion

    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("LightSwitchApplication", "FK_Voorstelling_Film", "Film")]
        public Film Film
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Film>("LightSwitchApplication.FK_Voorstelling_Film", "Film").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Film>("LightSwitchApplication.FK_Voorstelling_Film", "Film").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Film> FilmReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Film>("LightSwitchApplication.FK_Voorstelling_Film", "Film");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Film>("LightSwitchApplication.FK_Voorstelling_Film", "Film", value);
                }
            }
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("LightSwitchApplication", "FK_Voorstelling_Zaal", "Zaal")]
        public Zaal Zaal
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Zaal>("LightSwitchApplication.FK_Voorstelling_Zaal", "Zaal").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Zaal>("LightSwitchApplication.FK_Voorstelling_Zaal", "Zaal").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Zaal> ZaalReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Zaal>("LightSwitchApplication.FK_Voorstelling_Zaal", "Zaal");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Zaal>("LightSwitchApplication.FK_Voorstelling_Zaal", "Zaal", value);
                }
            }
        }

        #endregion

    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="LightSwitchApplication", Name="Zaal")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Zaal : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Zaal object.
        /// </summary>
        /// <param name="zaalId">Initial value of the ZaalId property.</param>
        /// <param name="zaalNummer">Initial value of the ZaalNummer property.</param>
        /// <param name="bioscoopId">Initial value of the BioscoopId property.</param>
        public static Zaal CreateZaal(global::System.Int32 zaalId, global::System.Int32 zaalNummer, global::System.Int32 bioscoopId)
        {
            Zaal zaal = new Zaal();
            zaal.ZaalId = zaalId;
            zaal.ZaalNummer = zaalNummer;
            zaal.BioscoopId = bioscoopId;
            return zaal;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 ZaalId
        {
            get
            {
                return _ZaalId;
            }
            set
            {
                if (_ZaalId != value)
                {
                    OnZaalIdChanging(value);
                    ReportPropertyChanging("ZaalId");
                    _ZaalId = value;
                    ReportPropertyChanged("ZaalId");
                    OnZaalIdChanged();
                }
            }
        }
        private global::System.Int32 _ZaalId;
        partial void OnZaalIdChanging(global::System.Int32 value);
        partial void OnZaalIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 ZaalNummer
        {
            get
            {
                return _ZaalNummer;
            }
            set
            {
                OnZaalNummerChanging(value);
                ReportPropertyChanging("ZaalNummer");
                _ZaalNummer = value;
                ReportPropertyChanged("ZaalNummer");
                OnZaalNummerChanged();
            }
        }
        private global::System.Int32 _ZaalNummer;
        partial void OnZaalNummerChanging(global::System.Int32 value);
        partial void OnZaalNummerChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> AantalStoelen
        {
            get
            {
                return _AantalStoelen;
            }
            set
            {
                OnAantalStoelenChanging(value);
                ReportPropertyChanging("AantalStoelen");
                _AantalStoelen = value;
                ReportPropertyChanged("AantalStoelen");
                OnAantalStoelenChanged();
            }
        }
        private Nullable<global::System.Int32> _AantalStoelen;
        partial void OnAantalStoelenChanging(Nullable<global::System.Int32> value);
        partial void OnAantalStoelenChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Byte> DrieD
        {
            get
            {
                return _DrieD;
            }
            set
            {
                OnDrieDChanging(value);
                ReportPropertyChanging("DrieD");
                _DrieD = value;
                ReportPropertyChanged("DrieD");
                OnDrieDChanged();
            }
        }
        private Nullable<global::System.Byte> _DrieD;
        partial void OnDrieDChanging(Nullable<global::System.Byte> value);
        partial void OnDrieDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 BioscoopId
        {
            get
            {
                return _BioscoopId;
            }
            set
            {
                OnBioscoopIdChanging(value);
                ReportPropertyChanging("BioscoopId");
                _BioscoopId = value;
                ReportPropertyChanged("BioscoopId");
                OnBioscoopIdChanged();
            }
        }
        private global::System.Int32 _BioscoopId;
        partial void OnBioscoopIdChanging(global::System.Int32 value);
        partial void OnBioscoopIdChanged();

        #endregion

    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("LightSwitchApplication", "FK_Voorstelling_Zaal", "Voorstelling")]
        public EntityCollection<Voorstelling> Voorstellings
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Voorstelling>("LightSwitchApplication.FK_Voorstelling_Zaal", "Voorstelling");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Voorstelling>("LightSwitchApplication.FK_Voorstelling_Zaal", "Voorstelling", value);
                }
            }
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("LightSwitchApplication", "FK_Zaal_Bioscoop", "Bioscoop")]
        public Bioscoop Bioscoop
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Bioscoop>("LightSwitchApplication.FK_Zaal_Bioscoop", "Bioscoop").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Bioscoop>("LightSwitchApplication.FK_Zaal_Bioscoop", "Bioscoop").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Bioscoop> BioscoopReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Bioscoop>("LightSwitchApplication.FK_Zaal_Bioscoop", "Bioscoop");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Bioscoop>("LightSwitchApplication.FK_Zaal_Bioscoop", "Bioscoop", value);
                }
            }
        }

        #endregion

    }

    #endregion

    
}
