// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 4.0.30319.42000
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace KbeBalls {
    using KbeBalls;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using uFrame.IOC;
    using uFrame.Kernel;
    using uFrame.Kernel.Serialization;
    using uFrame.MVVM;
    using uFrame.MVVM.Bindings;
    using uFrame.MVVM.ViewModels;
    using UniRx;
    using UnityEngine;
    
    
    public partial class EntityCommonViewModelBase : uFrame.MVVM.ViewModels.ViewModel {
        
        private P<Vector3> _PositionProperty;
        
        private P<Vector3> _DirectionProperty;
        
        private P<Int32> _modelIDProperty;
        
        public EntityCommonViewModelBase(uFrame.Kernel.IEventAggregator aggregator) : 
                base(aggregator) {
        }
        
        public virtual P<Vector3> PositionProperty {
            get {
                return _PositionProperty;
            }
            set {
                _PositionProperty = value;
            }
        }
        
        public virtual P<Vector3> DirectionProperty {
            get {
                return _DirectionProperty;
            }
            set {
                _DirectionProperty = value;
            }
        }
        
        public virtual P<Int32> modelIDProperty {
            get {
                return _modelIDProperty;
            }
            set {
                _modelIDProperty = value;
            }
        }
        
        public virtual Vector3 Position {
            get {
                return PositionProperty.Value;
            }
            set {
                PositionProperty.Value = value;
            }
        }
        
        public virtual Vector3 Direction {
            get {
                return DirectionProperty.Value;
            }
            set {
                DirectionProperty.Value = value;
            }
        }
        
        public virtual Int32 modelID {
            get {
                return modelIDProperty.Value;
            }
            set {
                modelIDProperty.Value = value;
            }
        }
        
        public override void Bind() {
            base.Bind();
            _PositionProperty = new P<Vector3>(this, "Position");
            _DirectionProperty = new P<Vector3>(this, "Direction");
            _modelIDProperty = new P<Int32>(this, "modelID");
        }
        
        public override void Read(uFrame.Kernel.Serialization.ISerializerStream stream) {
            base.Read(stream);
            this.Position = stream.DeserializeVector3("Position");;
            this.Direction = stream.DeserializeVector3("Direction");;
            this.modelID = stream.DeserializeInt("modelID");;
        }
        
        public override void Write(uFrame.Kernel.Serialization.ISerializerStream stream) {
            base.Write(stream);
            stream.SerializeVector3("Position", this.Position);
            stream.SerializeVector3("Direction", this.Direction);
            stream.SerializeInt("modelID", this.modelID);
        }
        
        protected override void FillCommands(System.Collections.Generic.List<uFrame.MVVM.ViewModels.ViewModelCommandInfo> list) {
            base.FillCommands(list);
        }
        
        protected override void FillProperties(System.Collections.Generic.List<uFrame.MVVM.ViewModels.ViewModelPropertyInfo> list) {
            base.FillProperties(list);
            // PropertiesChildItem
            list.Add(new ViewModelPropertyInfo(_PositionProperty, false, false, false, false));
            // PropertiesChildItem
            list.Add(new ViewModelPropertyInfo(_DirectionProperty, false, false, false, false));
            // PropertiesChildItem
            list.Add(new ViewModelPropertyInfo(_modelIDProperty, false, false, false, false));
        }
    }
    
    public partial class EntityCommonViewModel {
        
        public EntityCommonViewModel(uFrame.Kernel.IEventAggregator aggregator) : 
                base(aggregator) {
        }
    }
}
