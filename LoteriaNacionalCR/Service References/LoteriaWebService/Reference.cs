﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.34014
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LoteriaNacionalCR.LoteriaWebService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="sorteo", Namespace="http://schemas.datacontract.org/2004/07/AccesoDatos")]
    [System.SerializableAttribute()]
    public partial class sorteo : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime fechaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private LoteriaNacionalCR.LoteriaWebService.premio[] premioField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string tituloField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime fecha {
            get {
                return this.fechaField;
            }
            set {
                if ((this.fechaField.Equals(value) != true)) {
                    this.fechaField = value;
                    this.RaisePropertyChanged("fecha");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int id {
            get {
                return this.idField;
            }
            set {
                if ((this.idField.Equals(value) != true)) {
                    this.idField = value;
                    this.RaisePropertyChanged("id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public LoteriaNacionalCR.LoteriaWebService.premio[] premio {
            get {
                return this.premioField;
            }
            set {
                if ((object.ReferenceEquals(this.premioField, value) != true)) {
                    this.premioField = value;
                    this.RaisePropertyChanged("premio");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string titulo {
            get {
                return this.tituloField;
            }
            set {
                if ((object.ReferenceEquals(this.tituloField, value) != true)) {
                    this.tituloField = value;
                    this.RaisePropertyChanged("titulo");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="premio", Namespace="http://schemas.datacontract.org/2004/07/AccesoDatos")]
    [System.SerializableAttribute()]
    public partial class premio : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int importanciaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal montoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int numeroField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int sorteoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private LoteriaNacionalCR.LoteriaWebService.sorteo sorteo1Field;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int id {
            get {
                return this.idField;
            }
            set {
                if ((this.idField.Equals(value) != true)) {
                    this.idField = value;
                    this.RaisePropertyChanged("id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int importancia {
            get {
                return this.importanciaField;
            }
            set {
                if ((this.importanciaField.Equals(value) != true)) {
                    this.importanciaField = value;
                    this.RaisePropertyChanged("importancia");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal monto {
            get {
                return this.montoField;
            }
            set {
                if ((this.montoField.Equals(value) != true)) {
                    this.montoField = value;
                    this.RaisePropertyChanged("monto");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int numero {
            get {
                return this.numeroField;
            }
            set {
                if ((this.numeroField.Equals(value) != true)) {
                    this.numeroField = value;
                    this.RaisePropertyChanged("numero");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int sorteo {
            get {
                return this.sorteoField;
            }
            set {
                if ((this.sorteoField.Equals(value) != true)) {
                    this.sorteoField = value;
                    this.RaisePropertyChanged("sorteo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public LoteriaNacionalCR.LoteriaWebService.sorteo sorteo1 {
            get {
                return this.sorteo1Field;
            }
            set {
                if ((object.ReferenceEquals(this.sorteo1Field, value) != true)) {
                    this.sorteo1Field = value;
                    this.RaisePropertyChanged("sorteo1");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="LoteriaWebService.ILoteriaNacional")]
    public interface ILoteriaNacional {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILoteriaNacional/AgregarSorteo", ReplyAction="http://tempuri.org/ILoteriaNacional/AgregarSorteoResponse")]
        void AgregarSorteo(LoteriaNacionalCR.LoteriaWebService.sorteo sorteo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILoteriaNacional/AgregarSorteo", ReplyAction="http://tempuri.org/ILoteriaNacional/AgregarSorteoResponse")]
        System.Threading.Tasks.Task AgregarSorteoAsync(LoteriaNacionalCR.LoteriaWebService.sorteo sorteo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILoteriaNacional/EditarSorteo", ReplyAction="http://tempuri.org/ILoteriaNacional/EditarSorteoResponse")]
        void EditarSorteo(LoteriaNacionalCR.LoteriaWebService.sorteo sorteo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILoteriaNacional/EditarSorteo", ReplyAction="http://tempuri.org/ILoteriaNacional/EditarSorteoResponse")]
        System.Threading.Tasks.Task EditarSorteoAsync(LoteriaNacionalCR.LoteriaWebService.sorteo sorteo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILoteriaNacional/EliminarSorteo", ReplyAction="http://tempuri.org/ILoteriaNacional/EliminarSorteoResponse")]
        void EliminarSorteo(LoteriaNacionalCR.LoteriaWebService.sorteo sorteo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILoteriaNacional/EliminarSorteo", ReplyAction="http://tempuri.org/ILoteriaNacional/EliminarSorteoResponse")]
        System.Threading.Tasks.Task EliminarSorteoAsync(LoteriaNacionalCR.LoteriaWebService.sorteo sorteo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILoteriaNacional/AgregarPremio", ReplyAction="http://tempuri.org/ILoteriaNacional/AgregarPremioResponse")]
        void AgregarPremio(LoteriaNacionalCR.LoteriaWebService.premio premio);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILoteriaNacional/AgregarPremio", ReplyAction="http://tempuri.org/ILoteriaNacional/AgregarPremioResponse")]
        System.Threading.Tasks.Task AgregarPremioAsync(LoteriaNacionalCR.LoteriaWebService.premio premio);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILoteriaNacional/EditarPremio", ReplyAction="http://tempuri.org/ILoteriaNacional/EditarPremioResponse")]
        void EditarPremio(LoteriaNacionalCR.LoteriaWebService.premio premio);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILoteriaNacional/EditarPremio", ReplyAction="http://tempuri.org/ILoteriaNacional/EditarPremioResponse")]
        System.Threading.Tasks.Task EditarPremioAsync(LoteriaNacionalCR.LoteriaWebService.premio premio);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILoteriaNacional/EliminarPremio", ReplyAction="http://tempuri.org/ILoteriaNacional/EliminarPremioResponse")]
        void EliminarPremio(LoteriaNacionalCR.LoteriaWebService.premio premio);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILoteriaNacional/EliminarPremio", ReplyAction="http://tempuri.org/ILoteriaNacional/EliminarPremioResponse")]
        System.Threading.Tasks.Task EliminarPremioAsync(LoteriaNacionalCR.LoteriaWebService.premio premio);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ILoteriaNacionalChannel : LoteriaNacionalCR.LoteriaWebService.ILoteriaNacional, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class LoteriaNacionalClient : System.ServiceModel.ClientBase<LoteriaNacionalCR.LoteriaWebService.ILoteriaNacional>, LoteriaNacionalCR.LoteriaWebService.ILoteriaNacional {
        
        public LoteriaNacionalClient() {
        }
        
        public LoteriaNacionalClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public LoteriaNacionalClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public LoteriaNacionalClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public LoteriaNacionalClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void AgregarSorteo(LoteriaNacionalCR.LoteriaWebService.sorteo sorteo) {
            base.Channel.AgregarSorteo(sorteo);
        }
        
        public System.Threading.Tasks.Task AgregarSorteoAsync(LoteriaNacionalCR.LoteriaWebService.sorteo sorteo) {
            return base.Channel.AgregarSorteoAsync(sorteo);
        }
        
        public void EditarSorteo(LoteriaNacionalCR.LoteriaWebService.sorteo sorteo) {
            base.Channel.EditarSorteo(sorteo);
        }
        
        public System.Threading.Tasks.Task EditarSorteoAsync(LoteriaNacionalCR.LoteriaWebService.sorteo sorteo) {
            return base.Channel.EditarSorteoAsync(sorteo);
        }
        
        public void EliminarSorteo(LoteriaNacionalCR.LoteriaWebService.sorteo sorteo) {
            base.Channel.EliminarSorteo(sorteo);
        }
        
        public System.Threading.Tasks.Task EliminarSorteoAsync(LoteriaNacionalCR.LoteriaWebService.sorteo sorteo) {
            return base.Channel.EliminarSorteoAsync(sorteo);
        }
        
        public void AgregarPremio(LoteriaNacionalCR.LoteriaWebService.premio premio) {
            base.Channel.AgregarPremio(premio);
        }
        
        public System.Threading.Tasks.Task AgregarPremioAsync(LoteriaNacionalCR.LoteriaWebService.premio premio) {
            return base.Channel.AgregarPremioAsync(premio);
        }
        
        public void EditarPremio(LoteriaNacionalCR.LoteriaWebService.premio premio) {
            base.Channel.EditarPremio(premio);
        }
        
        public System.Threading.Tasks.Task EditarPremioAsync(LoteriaNacionalCR.LoteriaWebService.premio premio) {
            return base.Channel.EditarPremioAsync(premio);
        }
        
        public void EliminarPremio(LoteriaNacionalCR.LoteriaWebService.premio premio) {
            base.Channel.EliminarPremio(premio);
        }
        
        public System.Threading.Tasks.Task EliminarPremioAsync(LoteriaNacionalCR.LoteriaWebService.premio premio) {
            return base.Channel.EliminarPremioAsync(premio);
        }
    }
}
