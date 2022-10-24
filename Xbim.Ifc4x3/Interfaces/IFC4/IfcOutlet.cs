// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.Interfaces;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;

//## Custom using statements
//##

// ReSharper disable once CheckNamespace
namespace Xbim.Ifc4x3.ElectricalDomain
{
	public partial class @IfcOutlet : IIfcOutlet
	{

		[CrossSchemaAttribute(typeof(IIfcOutlet), 9)]
		Ifc4.Interfaces.IfcOutletTypeEnum? IIfcOutlet.PredefinedType 
		{ 
			get
			{
				//## Custom code to handle enumeration of PredefinedType
				//##
				switch (PredefinedType)
				{
					case IfcOutletTypeEnum.AUDIOVISUALOUTLET:
						return Ifc4.Interfaces.IfcOutletTypeEnum.AUDIOVISUALOUTLET;
					case IfcOutletTypeEnum.COMMUNICATIONSOUTLET:
						return Ifc4.Interfaces.IfcOutletTypeEnum.COMMUNICATIONSOUTLET;
					case IfcOutletTypeEnum.DATAOUTLET:
						return Ifc4.Interfaces.IfcOutletTypeEnum.DATAOUTLET;
					case IfcOutletTypeEnum.POWEROUTLET:
						return Ifc4.Interfaces.IfcOutletTypeEnum.POWEROUTLET;
					case IfcOutletTypeEnum.TELEPHONEOUTLET:
						return Ifc4.Interfaces.IfcOutletTypeEnum.TELEPHONEOUTLET;
					case IfcOutletTypeEnum.USERDEFINED:
						//## Optional custom handling of PredefinedType == .USERDEFINED. 
						//##
						return Ifc4.Interfaces.IfcOutletTypeEnum.USERDEFINED;
					case IfcOutletTypeEnum.NOTDEFINED:
						return Ifc4.Interfaces.IfcOutletTypeEnum.NOTDEFINED;
					case null: 
						return null;
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
			} 
			set
			{
				//## Custom code to handle setting of enumeration of PredefinedType
				//##
				switch (value)
				{
					case Ifc4.Interfaces.IfcOutletTypeEnum.AUDIOVISUALOUTLET:
						PredefinedType = IfcOutletTypeEnum.AUDIOVISUALOUTLET;
						return;
					case Ifc4.Interfaces.IfcOutletTypeEnum.COMMUNICATIONSOUTLET:
						PredefinedType = IfcOutletTypeEnum.COMMUNICATIONSOUTLET;
						return;
					case Ifc4.Interfaces.IfcOutletTypeEnum.POWEROUTLET:
						PredefinedType = IfcOutletTypeEnum.POWEROUTLET;
						return;
					case Ifc4.Interfaces.IfcOutletTypeEnum.DATAOUTLET:
						PredefinedType = IfcOutletTypeEnum.DATAOUTLET;
						return;
					case Ifc4.Interfaces.IfcOutletTypeEnum.TELEPHONEOUTLET:
						PredefinedType = IfcOutletTypeEnum.TELEPHONEOUTLET;
						return;
					case Ifc4.Interfaces.IfcOutletTypeEnum.USERDEFINED:
						PredefinedType = IfcOutletTypeEnum.USERDEFINED;
						return;
					case Ifc4.Interfaces.IfcOutletTypeEnum.NOTDEFINED:
						PredefinedType = IfcOutletTypeEnum.NOTDEFINED;
						return;
					
					case null:
						PredefinedType = null;
						return;
					default:
						throw new System.ArgumentOutOfRangeException();
				}
				
			}
		}
	//## Custom code
	//##
	}
}