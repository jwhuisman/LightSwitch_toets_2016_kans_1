﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using global::System.Linq;

namespace LightSwitchApplication.Implementation
{
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "14.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public class ApplicationDataDataService
        : global::Microsoft.LightSwitch.ServerGenerated.Implementation.DataService<global::LightSwitchApplication.Implementation.ApplicationData>
    {
    
        public ApplicationDataDataService() : base()
        {
        }
    
        protected override global::Microsoft.LightSwitch.IDataService GetDataService(global::Microsoft.LightSwitch.IDataWorkspace dataWorkspace)
        {
            return ((global::LightSwitchApplication.DataWorkspace)dataWorkspace).ApplicationData;
        }
    }
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "14.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public class ApplicationDataServiceImplementation
        : global::Microsoft.LightSwitch.ServerGenerated.Implementation.DataServiceImplementation<global::LightSwitchApplication.Implementation.ApplicationData>
    {
        public ApplicationDataServiceImplementation(global::Microsoft.LightSwitch.IDataService dataService) : base(dataService)
        {
        }
    
    #region Queries
    #endregion

    #region Protected Methods
        protected override object CreateObject(global::System.Type type)
        {
            if (type == typeof(global::LightSwitchApplication.Implementation.Beoordeling))
            {
                return new global::LightSwitchApplication.Implementation.Beoordeling();
            }
            if (type == typeof(global::LightSwitchApplication.Implementation.BioscoopReview))
            {
                return new global::LightSwitchApplication.Implementation.BioscoopReview();
            }
    
            return base.CreateObject(type);
        }
    
        protected override global::LightSwitchApplication.Implementation.ApplicationData CreateObjectContext()
        {
            string assemblyName = global::System.Reflection.Assembly.GetExecutingAssembly().GetName().Name;
            return new global::LightSwitchApplication.Implementation.ApplicationData(this.GetEntityConnectionString(
                "_IntrinsicData",
                "res://" + assemblyName + "/ApplicationData.csdl|res://" + assemblyName + "/ApplicationData.ssdl|res://" + assemblyName + "/ApplicationData.msl",
                "System.Data.SqlClient",
                true));
        }
    
        protected override global::Microsoft.LightSwitch.Internal.IEntityImplementation CreateEntityImplementation<T>()
        {
            if (typeof(T) == typeof(global::LightSwitchApplication.Beoordeling))
            {
                return new global::LightSwitchApplication.Implementation.Beoordeling();
            }
            if (typeof(T) == typeof(global::LightSwitchApplication.BioscoopReview))
            {
                return new global::LightSwitchApplication.Implementation.BioscoopReview();
            }
            return null;
        }
    
    #endregion
    
    }
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "14.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public class CinemaDataDataService
        : global::Microsoft.LightSwitch.ServerGenerated.Implementation.DataService<global::LightSwitchApplication.Implementation.CinemaData>
    {
    
        public CinemaDataDataService() : base()
        {
        }
    
        protected override global::Microsoft.LightSwitch.IDataService GetDataService(global::Microsoft.LightSwitch.IDataWorkspace dataWorkspace)
        {
            return ((global::LightSwitchApplication.DataWorkspace)dataWorkspace).CinemaData;
        }
    }
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "14.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public class CinemaDataServiceImplementation
        : global::Microsoft.LightSwitch.ServerGenerated.Implementation.DataServiceImplementation<global::LightSwitchApplication.Implementation.CinemaData>
    {
        public CinemaDataServiceImplementation(global::Microsoft.LightSwitch.IDataService dataService) : base(dataService)
        {
        }
    
    #region Queries
    #endregion

    #region Protected Methods
        protected override object CreateObject(global::System.Type type)
        {
            if (type == typeof(global::LightSwitchApplication.Implementation.Bioscoop))
            {
                return new global::LightSwitchApplication.Implementation.Bioscoop();
            }
            if (type == typeof(global::LightSwitchApplication.Implementation.Film))
            {
                return new global::LightSwitchApplication.Implementation.Film();
            }
            if (type == typeof(global::LightSwitchApplication.Implementation.Voorstelling))
            {
                return new global::LightSwitchApplication.Implementation.Voorstelling();
            }
            if (type == typeof(global::LightSwitchApplication.Implementation.Zaal))
            {
                return new global::LightSwitchApplication.Implementation.Zaal();
            }
    
            return base.CreateObject(type);
        }
    
        protected override global::LightSwitchApplication.Implementation.CinemaData CreateObjectContext()
        {
            string assemblyName = global::System.Reflection.Assembly.GetExecutingAssembly().GetName().Name;
            return new global::LightSwitchApplication.Implementation.CinemaData(this.GetEntityConnectionString(
                "CinemaData",
                "res://" + assemblyName + "/CinemaData.csdl|res://" + assemblyName + "/CinemaData.ssdl|res://" + assemblyName + "/CinemaData.msl",
                "System.Data.SqlClient",
                true));
        }
    
        protected override global::Microsoft.LightSwitch.Internal.IEntityImplementation CreateEntityImplementation<T>()
        {
            if (typeof(T) == typeof(global::LightSwitchApplication.Bioscoop))
            {
                return new global::LightSwitchApplication.Implementation.Bioscoop();
            }
            if (typeof(T) == typeof(global::LightSwitchApplication.Film))
            {
                return new global::LightSwitchApplication.Implementation.Film();
            }
            if (typeof(T) == typeof(global::LightSwitchApplication.Voorstelling))
            {
                return new global::LightSwitchApplication.Implementation.Voorstelling();
            }
            if (typeof(T) == typeof(global::LightSwitchApplication.Zaal))
            {
                return new global::LightSwitchApplication.Implementation.Zaal();
            }
            return null;
        }
    
    #endregion
    
    }
    
    #region DataServiceImplementationFactory
    [global::System.ComponentModel.Composition.PartCreationPolicy(global::System.ComponentModel.Composition.CreationPolicy.Shared)]
    [global::System.ComponentModel.Composition.Export(typeof(global::Microsoft.LightSwitch.Internal.IDataServiceFactory))]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "14.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public class __DataServiceFactory :
        global::Microsoft.LightSwitch.ServerGenerated.Implementation.DataServiceFactory
    {
    
        protected override global::Microsoft.LightSwitch.IDataService CreateDataService(global::System.Type dataServiceType)
        {
            if (dataServiceType == typeof(global::LightSwitchApplication.ApplicationDataService))
            {
                return new global::LightSwitchApplication.ApplicationDataService();
            }
            if (dataServiceType == typeof(global::LightSwitchApplication.CinemaDataService))
            {
                return new global::LightSwitchApplication.CinemaDataService();
            }
            return base.CreateDataService(dataServiceType);
        }
    
        protected override global::Microsoft.LightSwitch.Internal.IDataServiceImplementation CreateDataServiceImplementation<TDataService>(TDataService dataService)
        {
            if (typeof(TDataService) == typeof(global::LightSwitchApplication.ApplicationDataService))
            {
                return new global::LightSwitchApplication.Implementation.ApplicationDataServiceImplementation(dataService);
            }
            if (typeof(TDataService) == typeof(global::LightSwitchApplication.CinemaDataService))
            {
                return new global::LightSwitchApplication.Implementation.CinemaDataServiceImplementation(dataService);
            }
            return base.CreateDataServiceImplementation(dataService);
        }
    }
    #endregion
    
    [global::System.ComponentModel.Composition.PartCreationPolicy(global::System.ComponentModel.Composition.CreationPolicy.Shared)]
    [global::System.ComponentModel.Composition.Export(typeof(global::Microsoft.LightSwitch.Internal.ITypeMappingProvider))]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "14.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public class __TypeMapping
        : global::Microsoft.LightSwitch.Internal.ITypeMappingProvider
    {
        global::System.Type global::Microsoft.LightSwitch.Internal.ITypeMappingProvider.GetImplementationType(global::System.Type definitionType)
        {
            if (typeof(global::LightSwitchApplication.Beoordeling) == definitionType)
            {
                return typeof(global::LightSwitchApplication.Implementation.Beoordeling);
            }
            if (typeof(global::LightSwitchApplication.BioscoopReview) == definitionType)
            {
                return typeof(global::LightSwitchApplication.Implementation.BioscoopReview);
            }
            if (typeof(global::LightSwitchApplication.Bioscoop) == definitionType)
            {
                return typeof(global::LightSwitchApplication.Implementation.Bioscoop);
            }
            if (typeof(global::LightSwitchApplication.Film) == definitionType)
            {
                return typeof(global::LightSwitchApplication.Implementation.Film);
            }
            if (typeof(global::LightSwitchApplication.Voorstelling) == definitionType)
            {
                return typeof(global::LightSwitchApplication.Implementation.Voorstelling);
            }
            if (typeof(global::LightSwitchApplication.Zaal) == definitionType)
            {
                return typeof(global::LightSwitchApplication.Implementation.Zaal);
            }
            return null;
        }
    }
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "14.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public partial class Beoordeling :
        global::LightSwitchApplication.Beoordeling.DetailsClass.IImplementation,
        global::Microsoft.LightSwitch.Internal.ICreatedModifiedPropertiesImplementation
    
    {
    
        global::System.Collections.IEnumerable global::LightSwitchApplication.Beoordeling.DetailsClass.IImplementation.BioscoopReviews
        {
            get
            {
                return this.BioscoopReviews;
            }
        }
        
        #region IEntityImplementation Members
        private global::Microsoft.LightSwitch.Internal.IEntityImplementationHost __host;
        
        global::Microsoft.LightSwitch.Internal.IEntityImplementationHost global::Microsoft.LightSwitch.Internal.IEntityImplementation.Host
        {
            get
            {
                return this.__host;
            }
        }
        
        void global::Microsoft.LightSwitch.Internal.IEntityImplementation.Initialize(global::Microsoft.LightSwitch.Internal.IEntityImplementationHost host)
        {
            this.__host = host;
        }
        
        protected override void OnPropertyChanged(string propertyName)
        {
            base.OnPropertyChanged(propertyName);
            if (this.__host != null)
            {
                this.__host.RaisePropertyChanged(propertyName);
            }
        }
        #endregion
    }
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "14.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public partial class BioscoopReview :
        global::LightSwitchApplication.BioscoopReview.DetailsClass.IImplementation,
        global::Microsoft.LightSwitch.Internal.ICreatedModifiedPropertiesImplementation
    
    {
    
        global::Microsoft.LightSwitch.Internal.IEntityImplementation global::LightSwitchApplication.BioscoopReview.DetailsClass.IImplementation.Beoordeling
        {
            get
            {
                return this.Beoordeling;
            }
            set
            {
                this.Beoordeling = (global::LightSwitchApplication.Implementation.Beoordeling)value;
                if (this.__host != null)
                {
                    this.__host.RaisePropertyChanged("Beoordeling");
                }
            }
        }
        
        partial void OnBioscoopReview_BeoordelingChanged()
        {
            if (this.__host != null)
            {
                this.__host.RaisePropertyChanged("Beoordeling");
            }
        }
        
        #region IEntityImplementation Members
        private global::Microsoft.LightSwitch.Internal.IEntityImplementationHost __host;
        
        global::Microsoft.LightSwitch.Internal.IEntityImplementationHost global::Microsoft.LightSwitch.Internal.IEntityImplementation.Host
        {
            get
            {
                return this.__host;
            }
        }
        
        void global::Microsoft.LightSwitch.Internal.IEntityImplementation.Initialize(global::Microsoft.LightSwitch.Internal.IEntityImplementationHost host)
        {
            this.__host = host;
        }
        
        protected override void OnPropertyChanged(string propertyName)
        {
            base.OnPropertyChanged(propertyName);
            if (this.__host != null)
            {
                this.__host.RaisePropertyChanged(propertyName);
            }
        }
        #endregion
    }
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "14.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public partial class Bioscoop :
        global::LightSwitchApplication.Bioscoop.DetailsClass.IImplementation
    {
    
        global::System.Collections.IEnumerable global::LightSwitchApplication.Bioscoop.DetailsClass.IImplementation.Zaals
        {
            get
            {
                return this.Zaals;
            }
        }
        
        #region IEntityImplementation Members
        private global::Microsoft.LightSwitch.Internal.IEntityImplementationHost __host;
        
        global::Microsoft.LightSwitch.Internal.IEntityImplementationHost global::Microsoft.LightSwitch.Internal.IEntityImplementation.Host
        {
            get
            {
                return this.__host;
            }
        }
        
        void global::Microsoft.LightSwitch.Internal.IEntityImplementation.Initialize(global::Microsoft.LightSwitch.Internal.IEntityImplementationHost host)
        {
            this.__host = host;
        }
        
        protected override void OnPropertyChanged(string propertyName)
        {
            base.OnPropertyChanged(propertyName);
            if (this.__host != null)
            {
                this.__host.RaisePropertyChanged(propertyName);
            }
        }
        #endregion
    }
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "14.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public partial class Film :
        global::LightSwitchApplication.Film.DetailsClass.IImplementation
    {
    
        global::System.Collections.IEnumerable global::LightSwitchApplication.Film.DetailsClass.IImplementation.Voorstellings
        {
            get
            {
                return this.Voorstellings;
            }
        }
        
        #region IEntityImplementation Members
        private global::Microsoft.LightSwitch.Internal.IEntityImplementationHost __host;
        
        global::Microsoft.LightSwitch.Internal.IEntityImplementationHost global::Microsoft.LightSwitch.Internal.IEntityImplementation.Host
        {
            get
            {
                return this.__host;
            }
        }
        
        void global::Microsoft.LightSwitch.Internal.IEntityImplementation.Initialize(global::Microsoft.LightSwitch.Internal.IEntityImplementationHost host)
        {
            this.__host = host;
        }
        
        protected override void OnPropertyChanged(string propertyName)
        {
            base.OnPropertyChanged(propertyName);
            if (this.__host != null)
            {
                this.__host.RaisePropertyChanged(propertyName);
            }
        }
        #endregion
    }
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "14.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public partial class Voorstelling :
        global::LightSwitchApplication.Voorstelling.DetailsClass.IImplementation
    {
    
        global::Microsoft.LightSwitch.Internal.IEntityImplementation global::LightSwitchApplication.Voorstelling.DetailsClass.IImplementation.Film
        {
            get
            {
                return this.Film;
            }
            set
            {
                this.Film = (global::LightSwitchApplication.Implementation.Film)value;
                if (this.__host != null)
                {
                    this.__host.RaisePropertyChanged("Film");
                }
            }
        }
        
        global::Microsoft.LightSwitch.Internal.IEntityImplementation global::LightSwitchApplication.Voorstelling.DetailsClass.IImplementation.Zaal
        {
            get
            {
                return this.Zaal;
            }
            set
            {
                this.Zaal = (global::LightSwitchApplication.Implementation.Zaal)value;
                if (this.__host != null)
                {
                    this.__host.RaisePropertyChanged("Zaal");
                }
            }
        }
        
        partial void OnFilmIdChanged()
        {
            if (this.__host != null)
            {
                this.__host.RaisePropertyChanged("Film");
            }
        }
        
        partial void OnZaalIdChanged()
        {
            if (this.__host != null)
            {
                this.__host.RaisePropertyChanged("Zaal");
            }
        }
        
        #region IEntityImplementation Members
        private global::Microsoft.LightSwitch.Internal.IEntityImplementationHost __host;
        
        global::Microsoft.LightSwitch.Internal.IEntityImplementationHost global::Microsoft.LightSwitch.Internal.IEntityImplementation.Host
        {
            get
            {
                return this.__host;
            }
        }
        
        void global::Microsoft.LightSwitch.Internal.IEntityImplementation.Initialize(global::Microsoft.LightSwitch.Internal.IEntityImplementationHost host)
        {
            this.__host = host;
        }
        
        protected override void OnPropertyChanged(string propertyName)
        {
            base.OnPropertyChanged(propertyName);
            if (this.__host != null)
            {
                this.__host.RaisePropertyChanged(propertyName);
            }
        }
        #endregion
    }
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "14.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public partial class Zaal :
        global::LightSwitchApplication.Zaal.DetailsClass.IImplementation
    {
    
        global::System.Collections.IEnumerable global::LightSwitchApplication.Zaal.DetailsClass.IImplementation.Voorstellings
        {
            get
            {
                return this.Voorstellings;
            }
        }
        
        global::Microsoft.LightSwitch.Internal.IEntityImplementation global::LightSwitchApplication.Zaal.DetailsClass.IImplementation.Bioscoop
        {
            get
            {
                return this.Bioscoop;
            }
            set
            {
                this.Bioscoop = (global::LightSwitchApplication.Implementation.Bioscoop)value;
                if (this.__host != null)
                {
                    this.__host.RaisePropertyChanged("Bioscoop");
                }
            }
        }
        
        partial void OnBioscoopIdChanged()
        {
            if (this.__host != null)
            {
                this.__host.RaisePropertyChanged("Bioscoop");
            }
        }
        
        #region IEntityImplementation Members
        private global::Microsoft.LightSwitch.Internal.IEntityImplementationHost __host;
        
        global::Microsoft.LightSwitch.Internal.IEntityImplementationHost global::Microsoft.LightSwitch.Internal.IEntityImplementation.Host
        {
            get
            {
                return this.__host;
            }
        }
        
        void global::Microsoft.LightSwitch.Internal.IEntityImplementation.Initialize(global::Microsoft.LightSwitch.Internal.IEntityImplementationHost host)
        {
            this.__host = host;
        }
        
        protected override void OnPropertyChanged(string propertyName)
        {
            base.OnPropertyChanged(propertyName);
            if (this.__host != null)
            {
                this.__host.RaisePropertyChanged(propertyName);
            }
        }
        #endregion
    }
    
}
